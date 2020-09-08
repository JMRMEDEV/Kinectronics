using System;

namespace Kinectronics
{
    public class AirVehicle : Vehicle
    {
        public AirVehicle(string connectionString) : base(connectionString)
        {
        }

        public virtual void TakeOff()
        {
        }

        public virtual void Land()
        {
        }

        public virtual void IncreaseAltitude()
        {
        }

        public virtual void DecreaseAltitude()
        {
        }
    }
}
