namespace Kinectronics
{
    public class Vehicle : Device
    {
        protected static float speed;
        protected static float charge;

        public Vehicle(string connectionString) : base(connectionString)
        {
        }

        public virtual void MoveForward()
        {

        }

        public virtual void MoveBackward()
        {

        }

        public virtual void TurnRight()
        {

        }

        public virtual void TurnLeft()
        {

        }

        public virtual void IncreaseSpeed()
        {

        }

        public virtual void DecreaseSpeed()
        {

        }

        public virtual void SecuritySpeed()
        {
            // Console.WriteLine("Setting vehicle security speed");
            // Console.WriteLine("Security speed reached");
        }

        public virtual void Stop()
        {
            // Console.WriteLine("Vehicle on standby state");
        }

        public virtual void Return()
        {

        }
    }
}
