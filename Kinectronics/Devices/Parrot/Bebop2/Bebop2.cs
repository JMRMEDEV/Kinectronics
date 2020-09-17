namespace Kinectronics
{
    using DeviceLibs.Vehicles.AirVehicles.Drones.Parrot.Bebop2;
    class Bebop2:Drone
    {
        private string _connectionString = null;
        private BebopCommand bebop;
        public Bebop2(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }

        public override void StablishConnection()
        {
            base.StablishConnection();
            if(_connectionString == "WiFi")
            {
                bebop = new BebopCommand(CommandSet.DEFAULT_IP);
            }
            if (bebop.Discover() == false)
            {
                // Console.WriteLine("Discover failed!");
                return;
            }
        }

        public override void MoveRight()
        {
            base.MoveRight();
            bebop.Move(1, 10, 0, 0, 0);
        }

        public override void MoveLeft()
        {
            base.MoveLeft();
            bebop.Move(1, -10, 0, 0, 0);
        }

        public override void TurnRight()
        {
            base.TurnRight();
            bebop.Move(0, 0, 0, 10, 0);
        }

        public override void TurnLeft()
        {
            base.TurnLeft();
            bebop.Move(0, 0, 0, -10, 0);
        }

        public override void MoveForward()
        {
            base.MoveForward();
            bebop.Move(1, 0, 10, 0, 0);
        }

        public override void MoveBackward()
        {
            base.MoveBackward();
            bebop.Move(1, 0, -10, 0, 0);
        }

        public override void TakeOff()
        {
            base.TakeOff();
            bebop.Takeoff();
        }

        public override void Land()
        {
            base.Land();
            bebop.Landing();
        }

        public override void IncreaseAltitude()
        {
            base.IncreaseAltitude();
            bebop.Move(0, 0, 0, 0, 10);
        }

        public override void DecreaseAltitude()
        {
            base.DecreaseAltitude();
            bebop.Move(0, 0, 0, 0, -10);
        }

        public override void Pause()
        {
            base.Pause();
            bebop.Move(0, 0, 0, 0, 0);
        }
    }
}
