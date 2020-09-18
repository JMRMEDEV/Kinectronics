namespace Kinectronics
{
    public class Arm : Device
    {
        public Arm(string connectionString) : base(connectionString)
        {
        }

        public virtual void RotateBaseJoint()
        {
        }

        public virtual void RotateShoulderJoint()
        {
        }

        public virtual void RotateElbowJoint()
        {
        }

        public virtual void RotateWristJoint1()
        {
        }

        public virtual void RotateWristJoint2()
        {
        }

        public virtual void RotateWristJoint3()
        {
        }

        public virtual void ActivateTool()
        {
        }

        public virtual void DeactivateTool()
        {
        }
    }
}
