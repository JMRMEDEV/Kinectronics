namespace Kinectronics
{
    public class Drone : AirVehicle
    {
        public Drone(string connectionString) : base(connectionString)
        {
        }

        public override void TurnRight()
        {
            base.TurnRight();
        }

        public override void TurnLeft()
        {
            base.TurnLeft();
        }

        public override void MoveForward()
        {
            base.MoveForward();
        }

        public override void MoveBackward()
        {
            base.MoveBackward();
        }

        public virtual void MoveLeft()
        {
        }

        public virtual void MoveRight()
        {
        }

        public virtual void Pause()
        {
        }
    }
}

