// 1. Arms45DownPosition
// 2. Arms45UpPosition
// 3. ArmsFrontPosition_L
// 4. ArmsFrontPosition_R
// 5. ArmsHRectanglePosition_L
// 6. ArmsHRectanglePosition_R
// 7. ArmsRectanglePosition_L
// 8. ArmsRectanglePosition_R
// 9. ArmsSidePosition_L
// 10. ArmsSidePosition_R
// 11. ArmsSquarePosition_L
// 12. ArmsSquarePosition_R

namespace Kinectronics.GestureDataBases
{
    using Microsoft.Kinect;

    public class KTDef1
    {

        public KTDef1()
        {
            
        }

        public string getGesture(Body body)
        {
            string gesture = "none";
            if (body != null)
            {
                if (body.IsTracked)
                {
                    if (ArmsHRectanglePosition_R(body))
                    {
                        gesture = "ArmsHRectanglePosition_R";
                    }
                }
            }
            return gesture;
        }

        private bool ArmsHRectanglePosition_R(Body body)
        {
            FloatBody floatBody;
            bool detected = false;
            floatBody = new FloatBody();
            floatBody.wristRight.coo_x = body.Joints[JointType.WristRight].Position.X;
            floatBody.wristRight.coo_y = body.Joints[JointType.WristRight].Position.Y;
            floatBody.wristRight.coo_z = body.Joints[JointType.WristRight].Position.Z;
            floatBody.head.coo_x = body.Joints[JointType.Head].Position.X;
            floatBody.head.coo_y = body.Joints[JointType.Head].Position.Y;
            floatBody.head.coo_z = body.Joints[JointType.Head].Position.Z;
            floatBody.spineMid.coo_x = body.Joints[JointType.SpineMid].Position.X;
            floatBody.spineMid.coo_y = body.Joints[JointType.SpineMid].Position.Y;
            floatBody.spineMid.coo_z = body.Joints[JointType.SpineMid].Position.Z;

            if (floatBody.wristRight.coo_y >= floatBody.head.coo_y)
            {
                if (floatBody.wristRight.coo_y < floatBody.head.coo_y + 0.05)
                {
                    if (floatBody.wristRight.coo_x > floatBody.spineMid.coo_x)
                    {
                        if (floatBody.wristRight.coo_z <= floatBody.spineMid.coo_z + 0.5 && floatBody.wristRight.coo_z >= floatBody.spineMid.coo_z - 0.5)
                        {
                            detected = true;
                        }
                    }
                }
            }

            return detected;
        }
    }
}
