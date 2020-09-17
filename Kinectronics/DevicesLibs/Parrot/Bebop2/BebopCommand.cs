using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

// Based on Bebop2-C#-SDK by u10116032 [https://github.com/u10116032/Bebop2-csharp-SDK]

namespace Kinectronics.DevicesLibs.Parrot.Bebop2
{
    public class BebopCommand
    {
        private readonly int[] seq = new int[256];
        private Command cmd;
        private PCmd pcmd;

        private readonly CancellationTokenSource cts = new CancellationTokenSource();
        private CancellationToken cancelToken;

        private UdpClient arstreamClient;
        private IPEndPoint remoteIpEndPoint;

        private UdpClient d2c_client;

        private static readonly object _thisLock = new object();
        private readonly string _ServerIP;


        public BebopCommand(string ServerIp)
        {
            _ServerIP = ServerIp ?? throw new ArgumentNullException(ServerIp);
        }

        public bool Discover()
        {
            bool discoverResult = true;

            try
            {

                //d2c_client = new UdpClient(CommandSet.IP, 54321);
                d2c_client = new UdpClient(_ServerIP, CommandSet.C2D_PORT);

                //make handshake with TCP_client, and the port is set to be 4444
                TcpClient tcpClient = new TcpClient(_ServerIP, CommandSet.DISCOVERY_PORT);
                NetworkStream stream = new NetworkStream(tcpClient.Client);

                //initialize reader and writer
                StreamWriter streamWriter = new StreamWriter(stream);
                StreamReader streamReader = new StreamReader(stream);

                //when the drone receive the message bellow, it will return the confirmation
                string handshake_Message = "{\"controller_type\":\"computer\", \"controller_name\":\"halley\", \"d2c_port\":\"43210\", \"arstream2_client_stream_port\":\"55004\", \"arstream2_client_control_port\":\"55005\"}";
                streamWriter.WriteLine(handshake_Message);
                streamWriter.Flush();

                string receive_Message = streamReader.ReadLine();
                if (receive_Message == null)
                {
                    discoverResult = false;
                }
                else
                {
                    //initialize
                    cmd = default;
                    pcmd = default;

                    //All State setting
                    GenerateAllStates();
                    GenerateAllSettings();

                    //enable video streaming
                    VideoEnable();

                    //init CancellationToken
                    cancelToken = cts.Token;

                    PcmdThreadActive();
                }
            }
            catch (Exception e) when (e is SocketException)
            {
                discoverResult = false;
            }
            return discoverResult;
        }


        public void SendCommandAdpator(ref Command cmd, int type = CommandSet.ARNETWORKAL_FRAME_TYPE_DATA, int id = CommandSet.BD_NET_CD_NONACK_ID)
        {
            int bufSize = cmd.size + 7;
            byte[] buf = new byte[bufSize];

            seq[id]++;
            if (seq[id] > 255) seq[id] = 0;

            buf[0] = (byte)type;
            buf[1] = (byte)id;
            buf[2] = (byte)seq[id];
            buf[3] = (byte)(bufSize & 0xff);
            buf[4] = (byte)((bufSize & 0xff00) >> 8);
            buf[5] = (byte)((bufSize & 0xff0000) >> 16);
            buf[6] = (byte)((bufSize & 0xff000000) >> 24);

            cmd.cmd.CopyTo(buf, 7);

            d2c_client.Send(buf, buf.Length);
        }

        public void Takeoff()
        {
            cmd = default;
            cmd.size = 4;
            cmd.cmd = new byte[4];

            cmd.cmd[0] = CommandSet.ARCOMMANDS_ID_PROJECT_ARDRONE3;
            cmd.cmd[1] = CommandSet.ARCOMMANDS_ID_ARDRONE3_CLASS_PILOTING;
            cmd.cmd[2] = CommandSet.ARCOMMANDS_ID_ARDRONE3_PILOTING_CMD_TAKEOFF;
            cmd.cmd[3] = 0;

            SendCommandAdpator(ref cmd, CommandSet.ARNETWORKAL_FRAME_TYPE_DATA_WITH_ACK, CommandSet.BD_NET_CD_ACK_ID);
        }

        public void Landing()
        {
            cmd = default;
            cmd.size = 4;
            cmd.cmd = new byte[4];

            cmd.cmd[0] = CommandSet.ARCOMMANDS_ID_PROJECT_ARDRONE3;
            cmd.cmd[1] = CommandSet.ARCOMMANDS_ID_ARDRONE3_CLASS_PILOTING;
            cmd.cmd[2] = CommandSet.ARCOMMANDS_ID_ARDRONE3_PILOTING_CMD_LANDING;
            cmd.cmd[3] = 0;

            SendCommandAdpator(ref cmd, CommandSet.ARNETWORKAL_FRAME_TYPE_DATA_WITH_ACK, CommandSet.BD_NET_CD_ACK_ID);
        }

        public void Move(int flag, int roll, int pitch, int yaw, int gaz)
        {
            pcmd.flag = flag;
            pcmd.roll = roll;
            pcmd.pitch = pitch;
            pcmd.yaw = yaw;
            pcmd.gaz = gaz;
        }

        public void GeneratePCMD()
        {
            lock (_thisLock)
            {
                cmd = default;
                cmd.size = 13;
                cmd.cmd = new byte[13];

                cmd.cmd[0] = CommandSet.ARCOMMANDS_ID_PROJECT_ARDRONE3;
                cmd.cmd[1] = CommandSet.ARCOMMANDS_ID_ARDRONE3_CLASS_PILOTING;
                cmd.cmd[2] = CommandSet.ARCOMMANDS_ID_ARDRONE3_PILOTING_CMD_PCMD;
                cmd.cmd[3] = 0;

                cmd.cmd[4] = (byte)pcmd.flag;  // flag
                cmd.cmd[5] = (pcmd.roll >= 0) ? (byte)pcmd.roll : (byte)(256 + pcmd.roll);  // roll: fly left or right [-100 ~ 100]
                cmd.cmd[6] = (pcmd.pitch >= 0) ? (byte)pcmd.pitch : (byte)(256 + pcmd.pitch);  // pitch: backward or forward [-100 ~ 100]
                cmd.cmd[7] = (pcmd.yaw >= 0) ? (byte)pcmd.yaw : (byte)(256 + pcmd.yaw);  // yaw: rotate left or right [-100 ~ 100]
                cmd.cmd[8] = (pcmd.gaz >= 0) ? (byte)pcmd.gaz : (byte)(256 + pcmd.gaz);  // gaze: down or up [-100 ~ 100]


                // for Debug Mode
                cmd.cmd[9] = 0;
                cmd.cmd[10] = 0;
                cmd.cmd[11] = 0;
                cmd.cmd[12] = 0;

                SendCommandAdpator(ref cmd);
            }

        }

        public void PcmdThreadActive()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    GeneratePCMD();
                    Thread.Sleep(50);  //sleep 50ms each time.
                }
            }, cancelToken);
        }

        public void CancelAllTask()
        {
            cts.Cancel();
        }

        public void GenerateAllStates()
        {
            cmd = default;
            cmd.size = 4;
            cmd.cmd = new byte[4];

            cmd.cmd[0] = CommandSet.ARCOMMANDS_ID_PROJECT_COMMON;
            cmd.cmd[1] = CommandSet.ARCOMMANDS_ID_COMMON_CLASS_COMMON;
            cmd.cmd[2] = (CommandSet.ARCOMMANDS_ID_COMMON_COMMON_CMD_ALLSTATES & 0xff);
            cmd.cmd[3] = (CommandSet.ARCOMMANDS_ID_COMMON_COMMON_CMD_ALLSTATES & 0xff00 >> 8);

            SendCommandAdpator(ref cmd, CommandSet.ARNETWORKAL_FRAME_TYPE_DATA_WITH_ACK, CommandSet.BD_NET_CD_ACK_ID);
        }

        public void GenerateAllSettings()
        {
            cmd = default;
            cmd.size = 4;
            cmd.cmd = new byte[4];

            cmd.cmd[0] = CommandSet.ARCOMMANDS_ID_PROJECT_COMMON;
            cmd.cmd[1] = CommandSet.ARCOMMANDS_ID_COMMON_CLASS_SETTINGS;
            cmd.cmd[2] = (0 & 0xff); // ARCOMMANDS_ID_COMMON_CLASS_SETTINGS_CMD_ALLSETTINGS = 0
            cmd.cmd[3] = (0 & 0xff00 >> 8);

            SendCommandAdpator(ref cmd, CommandSet.ARNETWORKAL_FRAME_TYPE_DATA_WITH_ACK, CommandSet.BD_NET_CD_ACK_ID);
        }

        public void VideoEnable()
        {
            cmd = default;
            cmd.size = 5;
            cmd.cmd = new byte[5];

            cmd.cmd[0] = CommandSet.ARCOMMANDS_ID_PROJECT_ARDRONE3;
            cmd.cmd[1] = CommandSet.ARCOMMANDS_ID_ARDRONE3_CLASS_MEDIASTREAMING;
            cmd.cmd[2] = (0 & 0xff); // ARCOMMANDS_ID_COMMON_CLASS_SETTINGS_CMD_VIDEOENABLE = 0
            cmd.cmd[3] = (0 & 0xff00 >> 8);
            cmd.cmd[4] = 1; //arg: Enable

            SendCommandAdpator(ref cmd, CommandSet.ARNETWORKAL_FRAME_TYPE_DATA_WITH_ACK, CommandSet.BD_NET_CD_ACK_ID);
        }

        public void InitARStream()
        {
            arstreamClient = new UdpClient(55004);
            remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
        }

        public byte[] GetImageData()
        {
            byte[] receivedData = arstreamClient.Receive(ref remoteIpEndPoint);
            return receivedData;
        }

        public void ArStreamThreadActive()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    GetImageData();
                }
            }, cancelToken);
        }
    }
}
