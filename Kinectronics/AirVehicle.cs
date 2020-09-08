using System;

namespace Kinectronics
{
    public class AirVehicle : Vehicle
    {
        public AirVehicle(string connectionString) : base(connectionString)
        {
        }

        protected bool TakeOff()
        {
            // Console.WriteLine("Taking off");
            return true;
        }

        protected bool Land()
        {
            // Console.WriteLine("Landing...\nLanded");
            return true;
        }

        protected void IncreaseAltitude()
        {

        }

        protected void DecreaseAltitude()
        {
            // Console.WriteLine("Decreasing Altitude");
        }
    }
}
