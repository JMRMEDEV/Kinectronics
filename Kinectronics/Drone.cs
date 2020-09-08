namespace Kinectronics
{
    public class Drone : AirVehicle
    {
        public Drone(string connectionString) : base(connectionString)
        {
        }

        protected void TurnRight()
        {

        }

        protected void TurnLeft()
        {

        }

        protected void MoveBackward()
        {

        }

        protected void SecurityState()
        {
            // Console.WriteLine("Executing security state procedure...");
            this.SecuritySpeed();
            this.DecreaseAltitude();
            this.Land();
            this.StopConnection();
        }
    }
}

