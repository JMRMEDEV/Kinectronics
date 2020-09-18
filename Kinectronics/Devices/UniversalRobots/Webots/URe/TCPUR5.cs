namespace Kinectronics.Devices.UniversalRobots.Webots.URe
{
    using System;
    using System.Net.Sockets;
    using Kinectronics;
    class TCPUR5 : Arm 
    {
        // Create a TcpClient
        private Int32 port = 27015;

        private TcpClient client;

        // Get a client stream for reading and writing
        //  Stream stream = client.GetStream();
        static NetworkStream stream;

        public TCPUR5(string connectionString) : base(connectionString) 
        {
            client = new TcpClient("localhost", port);
        }

        private void SendMessage(String message)
        {

            // Translate the passed message into ASCII and store it as a Byte array.
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            stream = client.GetStream();

            // Send the message to the connected TcpServer.
            stream.Write(data, 0, data.Length);

            Console.WriteLine("Sent: {0}", message);

            // Receive the TcpServer.response.

            // Buffer to store the response bytes.
            data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine("Received: {0}", responseData);
        }

        private void moveRight()
        {
            // Side Position
            SendMessage("aSP");
        }

        private void moveFront()
        {
            // Front Position
            SendMessage("aFP");
        }

        private void moveDown()
        {
            // Default Position
            SendMessage("aDP");
        }

        private void moveHRPosition()
        {
            // HRectangle Position
            SendMessage("aHRP");
        }

        public override void ActivateTool()
        {
            base.ActivateTool();
            // Close Gripper
            SendMessage("cGr");
        }

        public override void DeactivateTool()
        {
            base.DeactivateTool();
            // Open Gripper
            SendMessage("oGr");
        }

        public override void StopConnection()
        {
            base.StopConnection();
            Disconnect();
        }

        private void Disconnect()
        {
            // Close everything.
            SendMessage("cCo");
            stream.Close();
            client.Close();
        }
    }
}
