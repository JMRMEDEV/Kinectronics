namespace Kinectronics.DeviceLibs.Vehicles.AirVehicles.Drones.Parrot.Bebop2
{
    public struct Command
    {
        public byte[] cmd;
        public int size;

        public override bool Equals(object obj)
        {
            throw new System.NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }

        public static bool operator ==(Command left, Command right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Command left, Command right)
        {
            return !(left == right);
        }
    }
}
