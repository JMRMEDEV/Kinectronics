namespace Kinectronics.Devices.LEGO.Mindstorms
{
    using MonoBrickx64.EV3;
    using MonoLibUsb;
    using System;

    class EV3ArmV1 : Arm
    {
        public string _connectionString = null;
        public Brick<Sensor, Sensor, Sensor, Sensor> ev3;

        public EV3ArmV1(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }

        public override void StablishConnection()
        {
            base.StablishConnection();
            ev3 = new Brick<Sensor, Sensor, Sensor, Sensor>(_connectionString);
            try
            {
                ev3.Connection.Open();
            }
            catch (Exception exc)
            {
                throw new System.NotImplementedException();
            }
        }

        public void MoveRight()
        {
            ev3.MotorC.On(15);
        }

        public void MoveLeft()
        {
            ev3.MotorC.On(-15);
        }

        public void MoveUp()
        {
            ev3.MotorB.On(15);
        }

        public void MoveDown()
        {
            ev3.MotorB.On(-15);
        }

        public void Stop()
        {
            ev3.MotorB.Off();
            ev3.MotorC.Off();
        }

        public override void ActivateTool()
        {
            base.ActivateTool();
            ev3.MotorA.MoveTo(20, -15, true);
        }

        public override void DeactivateTool()
        {
            base.DeactivateTool();
            ev3.MotorA.MoveTo(20, 15, true);
        }

        public override void StopConnection()
        {
            base.StopConnection();
            ev3.Connection.Close();
        }
    }
}
