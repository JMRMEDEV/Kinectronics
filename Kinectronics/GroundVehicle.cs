namespace Kinectronics
{
    public class GroundVehicle : Vehicle
    {
        public GroundVehicle(string connectionString) : base(connectionString)
        {
        }

        public override void DecreaseSpeed()
        {
            base.DecreaseSpeed();
        }

        public override void IncreaseSpeed()
        {
            base.IncreaseSpeed();
        }

        public override void MoveForward()
        {
            base.MoveForward();
        }

        public override void Return()
        {
            base.Return();
        }

        public override void SecuritySpeed()
        {
            base.SecuritySpeed();
        }

        public override void StablishConnection()
        {
            base.StablishConnection();
        }

        public override void Stop()
        {
            base.Stop();
        }

        public override void StopConnection()
        {
            base.StopConnection();
        }
    }
}
