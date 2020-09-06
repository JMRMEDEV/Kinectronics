// 1. Arms45DownPosition
// 2. Arms45UpPosition
// 3. ArmsFrontPosition_L
// 4. ArmsFrontPosition_R
// 5. ArmsHRectanglePosition_L (working)
// 6. ArmsHRectanglePosition_R (working)
// 7. ArmsRectanglePosition_L
// 8. ArmsRectanglePosition_R
// 9. ArmsSidePosition_L (working)
// 10. ArmsSidePosition_R (working
// 11. ArmsSquarePosition_L
// 12. ArmsSquarePosition_R

namespace Kinectronics.GestureDataBases
{
    using Microsoft.Kinect;

    public class KinectronicsDefaultGestureDataBase
    {

        public KinectronicsDefaultGestureDataBase()
        {
        }

        public string GetGesture(Body body)
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
                    if (ArmsHRectanglePosition_L(body))
                    {
                        gesture = "ArmsHRectanglePosition_L";
                    }
                    if (ArmsSidePosition_L(body))
                    {
                        gesture = "ArmsSidePosition_L";
                    }
                    if (ArmsSidePosition_R(body))
                    {
                        gesture = "ArmsSidePosition_R";
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
            floatBody.shoulderRight.coo_y = body.Joints[JointType.ShoulderRight].Position.Y;
            floatBody.spineShoulder.coo_y = body.Joints[JointType.SpineShoulder].Position.Y;
            floatBody.spineShoulder.coo_z = body.Joints[JointType.SpineShoulder].Position.Z;
            floatBody.elbowRight.coo_x = body.Joints[JointType.ElbowRight].Position.X;
            floatBody.elbowRight.coo_y = body.Joints[JointType.ElbowRight].Position.Y;
            floatBody.elbowRight.coo_z = body.Joints[JointType.ElbowRight].Position.Z;
            floatBody.wristRight.coo_x = body.Joints[JointType.WristRight].Position.X;

            if (floatBody.elbowRight.coo_z <= floatBody.spineShoulder.coo_z + 0.5 && floatBody.elbowRight.coo_z >= floatBody.spineShoulder.coo_z - 0.5)
            {
                if (floatBody.shoulderRight.coo_y <= floatBody.spineShoulder.coo_y + 0.1 && floatBody.shoulderRight.coo_y >= floatBody.spineShoulder.coo_y - 0.1)
                {
                    if (floatBody.elbowRight.coo_y <= floatBody.shoulderRight.coo_y + 0.1 && floatBody.elbowRight.coo_y >= floatBody.shoulderRight.coo_y - 0.1)
                    {
                        if (floatBody.wristRight.coo_x <= floatBody.elbowRight.coo_x + 0.1 && floatBody.wristRight.coo_x >= floatBody.elbowRight.coo_x - 0.1)
                        {
                            detected = true;
                        }
                    }
                }
            }

            return detected;
        }

        private bool ArmsHRectanglePosition_L(Body body)
        {
            FloatBody floatBody;
            bool detected = false;
            floatBody = new FloatBody();
            floatBody.shoulderLeft.coo_y = body.Joints[JointType.ShoulderLeft].Position.Y;
            floatBody.spineShoulder.coo_y = body.Joints[JointType.SpineShoulder].Position.Y;
            floatBody.spineShoulder.coo_z = body.Joints[JointType.SpineShoulder].Position.Z;
            floatBody.elbowLeft.coo_x = body.Joints[JointType.ElbowLeft].Position.X;
            floatBody.elbowLeft.coo_y = body.Joints[JointType.ElbowLeft].Position.Y;
            floatBody.elbowLeft.coo_z = body.Joints[JointType.ElbowLeft].Position.Z;
            floatBody.wristLeft.coo_x = body.Joints[JointType.WristLeft].Position.X;

            if (floatBody.elbowLeft.coo_z <= floatBody.spineShoulder.coo_z + 0.5 && floatBody.elbowLeft.coo_z >= floatBody.spineShoulder.coo_z - 0.5)
            {
                if (floatBody.shoulderLeft.coo_y <= floatBody.spineShoulder.coo_y + 0.1 && floatBody.shoulderLeft.coo_y >= floatBody.spineShoulder.coo_y - 0.1)
                {
                    if (floatBody.elbowLeft.coo_y <= floatBody.shoulderLeft.coo_y + 0.1 && floatBody.elbowLeft.coo_y >= floatBody.shoulderLeft.coo_y - 0.1)
                    {
                        if (floatBody.wristLeft.coo_x <= floatBody.elbowLeft.coo_x + 0.1 && floatBody.wristLeft.coo_x >= floatBody.elbowLeft.coo_x - 0.1)
                        {
                            detected = true;
                        }
                    }
                }
            }

            return detected;
        }

        private bool ArmsSidePosition_L(Body body)
        {
            FloatBody floatBody;
            bool detected = false;
            floatBody = new FloatBody();
            floatBody.shoulderLeft.coo_y = body.Joints[JointType.ShoulderLeft].Position.Y;
            floatBody.spineShoulder.coo_y = body.Joints[JointType.SpineShoulder].Position.Y;
            floatBody.spineShoulder.coo_z = body.Joints[JointType.SpineShoulder].Position.Z;
            floatBody.elbowLeft.coo_y = body.Joints[JointType.ElbowLeft].Position.Y;
            floatBody.wristLeft.coo_x = body.Joints[JointType.WristLeft].Position.X;
            floatBody.wristLeft.coo_y = body.Joints[JointType.WristLeft].Position.Y;
            floatBody.wristLeft.coo_z = body.Joints[JointType.WristLeft].Position.Z;

            if (floatBody.wristLeft.coo_z <= floatBody.spineShoulder.coo_z + 0.2 && floatBody.wristLeft.coo_z >= floatBody.spineShoulder.coo_z - 0.2)
            {
                if (floatBody.elbowLeft.coo_y <= floatBody.shoulderLeft.coo_y + 0.1 && floatBody.elbowLeft.coo_y >= floatBody.shoulderLeft.coo_y - 0.1)
                {
                    if (floatBody.wristLeft.coo_y <= floatBody.spineShoulder.coo_y + 0.1 && floatBody.wristLeft.coo_y >= floatBody.spineShoulder.coo_y - 0.1)
                    {
                        if (floatBody.wristLeft.coo_y + 0.25 > 0 || floatBody.wristLeft.coo_y - 0.25 < 0)
                        {
                            detected = true;
                        }
                    }
                }
            }

            return detected;
        }

        private bool ArmsSidePosition_R(Body body)
        {
            FloatBody floatBody;
            bool detected = false;
            floatBody = new FloatBody();
            floatBody.shoulderRight.coo_y = body.Joints[JointType.ShoulderRight].Position.Y;
            floatBody.spineShoulder.coo_y = body.Joints[JointType.SpineShoulder].Position.Y;
            floatBody.spineShoulder.coo_z = body.Joints[JointType.SpineShoulder].Position.Z;
            floatBody.elbowRight.coo_y = body.Joints[JointType.ElbowRight].Position.Y;
            floatBody.wristRight.coo_x = body.Joints[JointType.WristRight].Position.X;
            floatBody.wristRight.coo_y = body.Joints[JointType.WristRight].Position.Y;
            floatBody.wristRight.coo_z = body.Joints[JointType.WristRight].Position.Z;

            if (floatBody.wristRight.coo_z <= floatBody.spineShoulder.coo_z + 0.2 && floatBody.wristRight.coo_z >= floatBody.spineShoulder.coo_z - 0.2)
            {
                if (floatBody.elbowRight.coo_y <= floatBody.shoulderRight.coo_y + 0.1 && floatBody.elbowRight.coo_y >= floatBody.shoulderRight.coo_y - 0.1)
                {
                    if (floatBody.wristRight.coo_y <= floatBody.spineShoulder.coo_y + 0.1 && floatBody.wristRight.coo_y >= floatBody.spineShoulder.coo_y - 0.1)
                    {
                        if (floatBody.wristRight.coo_y + 0.25 > 0 || floatBody.wristRight.coo_y - 0.25 < 0)
                        {
                            detected = true;
                        }
                    }
                }
            }

            return detected;
        }

        /*
        private bool ArmsSidePosition_L(Body body)
        {
            FloatBody floatBody;
            bool detected = false;
            floatBody = new FloatBody();
            return detected;
        } 
        */
    }
}
