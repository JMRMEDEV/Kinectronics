namespace Kinectronics.DeviceLibs.Vehicles.AirVehicles.Drones.Parrot.Bebop2
{
    public struct PCmd
    {
        public int flag;
        public int roll;
        public int pitch;
        public int yaw;
        public int gaz;

        public override bool Equals(object obj)
        {
            throw new System.NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }

        public static bool operator ==(PCmd left, PCmd right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(PCmd left, PCmd right)
        {
            return !(left == right);
        }
    }
}
