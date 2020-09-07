// 1. Arms45DownPosition (working)
// 2. Arms45UpPosition (working)
// 3. ArmsFrontPosition_L (working)
// 4. ArmsFrontPosition_R (working)
// 5. ArmsHRectanglePosition_L (working)
// 6. ArmsHRectanglePosition_R (working)
// 7. ArmsRectanglePosition_L (working with some bugs)
// 8. ArmsRectanglePosition_R (working with some bugs)
// 9. ArmsSidePosition_L (working)
// 10. ArmsSidePosition_R (working
// 11. ArmsSquarePosition_L
// 12. ArmsSquarePosition_R

namespace Kinectronics.GestureDataBases
{
    using Microsoft.Kinect;

    public class KinectronicsDefaultGestureDataBase
    {
        private bool twoHandedGesture = false;

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
                    if (ArmsHRectanglePosition_R(body) && !twoHandedGesture)
                    {
                        gesture = "ArmsHRectanglePosition_R";
                    }
                    if (ArmsHRectanglePosition_L(body) && !twoHandedGesture)
                    {
                        gesture = "ArmsHRectanglePosition_L";
                    }
                    if (ArmsSidePosition_L(body) && !twoHandedGesture)
                    {
                        gesture = "ArmsSidePosition_L";
                    }
                    if (ArmsSidePosition_R(body) && !twoHandedGesture)
                    {
                        gesture = "ArmsSidePosition_R";
                    }
                    if (ArmsFrontPosition_R(body) && !twoHandedGesture)
                    {
                        gesture = "ArmsFrontPosition_R";
                    }
                    if (ArmsFrontPosition_L(body) && !twoHandedGesture)
                    {
                        gesture = "ArmsFrontPosition_L";
                    }
                    if (Arms45UpPosition(body))
                    {
                        gesture = "Arms45UpPosition";
                    }
                    if (Arms45DownPosition(body))
                    {
                        gesture = "Arms45DownPosition";
                    }
                    if (ArmsRectanglePosition_L(body))
                    {
                        gesture = "ArmsRectanglePosition_L";
                    }
                    if (ArmsRectanglePosition_R(body))
                    {
                        gesture = "ArmsRectanglePosition_R";
                    }
                    if (ArmsSquarePosition_L(body))
                    {
                        gesture = "ArmsSquarePosition_L";
                    }
                    if (ArmsSquarePosition_R(body))
                    {
                        gesture = "ArmsSquarePosition_R";
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
            floatBody.head.coo_y = body.Joints[JointType.Head].Position.Y;
            floatBody.shoulderRight.coo_x = body.Joints[JointType.ShoulderRight].Position.X;
            floatBody.shoulderRight.coo_y = body.Joints[JointType.ShoulderRight].Position.Y;
            floatBody.spineShoulder.coo_y = body.Joints[JointType.SpineShoulder].Position.Y;
            floatBody.spineShoulder.coo_z = body.Joints[JointType.SpineShoulder].Position.Z;
            floatBody.elbowRight.coo_x = body.Joints[JointType.ElbowRight].Position.X;
            floatBody.elbowRight.coo_y = body.Joints[JointType.ElbowRight].Position.Y;
            floatBody.elbowRight.coo_z = body.Joints[JointType.ElbowRight].Position.Z;
            floatBody.wristRight.coo_x = body.Joints[JointType.WristRight].Position.X;
            floatBody.wristRight.coo_y = body.Joints[JointType.WristRight].Position.Y;

            if (floatBody.elbowRight.coo_z <= floatBody.spineShoulder.coo_z + 0.5 && floatBody.elbowRight.coo_z >= floatBody.spineShoulder.coo_z - 0.5)
            {
                if (floatBody.wristRight.coo_y >= floatBody.head.coo_y)
                {
                    if (floatBody.shoulderRight.coo_y <= floatBody.spineShoulder.coo_y + 0.1 && floatBody.shoulderRight.coo_y >= floatBody.spineShoulder.coo_y - 0.1)
                    {
                        if (floatBody.wristRight.coo_x >= floatBody.shoulderRight.coo_x + 0.2)
                        {
                            if (floatBody.elbowRight.coo_y <= floatBody.shoulderRight.coo_y + 0.1 && floatBody.elbowRight.coo_y >= floatBody.shoulderRight.coo_y - 0.1)
                            {
                                if (floatBody.wristRight.coo_x >= floatBody.elbowRight.coo_x - 0.1 && floatBody.wristRight.coo_x <= floatBody.elbowRight.coo_x + 0.1)
                                {
                                    detected = true;
                                }
                            }
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
            floatBody.head.coo_y = body.Joints[JointType.Head].Position.Y;
            floatBody.shoulderLeft.coo_y = body.Joints[JointType.ShoulderLeft].Position.Y;
            floatBody.spineShoulder.coo_y = body.Joints[JointType.SpineShoulder].Position.Y;
            floatBody.spineShoulder.coo_z = body.Joints[JointType.SpineShoulder].Position.Z;
            floatBody.elbowLeft.coo_x = body.Joints[JointType.ElbowLeft].Position.X;
            floatBody.elbowLeft.coo_y = body.Joints[JointType.ElbowLeft].Position.Y;
            floatBody.elbowLeft.coo_z = body.Joints[JointType.ElbowLeft].Position.Z;
            floatBody.wristLeft.coo_x = body.Joints[JointType.WristLeft].Position.X;
            floatBody.wristLeft.coo_y = body.Joints[JointType.WristLeft].Position.Y;

            if (floatBody.elbowLeft.coo_z <= floatBody.spineShoulder.coo_z + 0.5 && floatBody.elbowLeft.coo_z >= floatBody.spineShoulder.coo_z - 0.5)
            {
                if (floatBody.wristLeft.coo_y >= floatBody.head.coo_y)
                {
                    if (floatBody.shoulderLeft.coo_y <= floatBody.spineShoulder.coo_y + 0.1 && floatBody.shoulderLeft.coo_y >= floatBody.spineShoulder.coo_y - 0.1)
                    {
                        if (floatBody.wristLeft.coo_x <= floatBody.shoulderRight.coo_x - 0.2)
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

        private bool ArmsFrontPosition_R(Body body)
        {
            FloatBody floatBody;
            bool detected = false;
            floatBody = new FloatBody();
            floatBody.neck.coo_y = body.Joints[JointType.Neck].Position.Y;
            floatBody.spineMid.coo_y = body.Joints[JointType.SpineMid].Position.Y;
            floatBody.shoulderRight.coo_x = body.Joints[JointType.ShoulderRight].Position.X;
            floatBody.shoulderRight.coo_y = body.Joints[JointType.ShoulderRight].Position.Y;
            floatBody.spineShoulder.coo_z = body.Joints[JointType.SpineShoulder].Position.Z;
            floatBody.wristRight.coo_x = body.Joints[JointType.WristRight].Position.X;
            floatBody.wristRight.coo_y = body.Joints[JointType.WristRight].Position.Y;
            floatBody.wristRight.coo_z = body.Joints[JointType.WristRight].Position.Z;

            if (floatBody.wristRight.coo_z < floatBody.spineShoulder.coo_z && floatBody.spineShoulder.coo_z - 0.4 > floatBody.wristRight.coo_z)
            {
                if(floatBody.wristRight.coo_y < floatBody.neck.coo_y)
                {
                    if (floatBody.wristRight.coo_x <= floatBody.shoulderRight.coo_x + 0.25 && floatBody.wristRight.coo_y <= floatBody.shoulderRight.coo_y)
                    {
                        if (floatBody.wristRight.coo_x > floatBody.elbowLeft.coo_x)
                        {
                            if (floatBody.wristRight.coo_y >= floatBody.shoulderRight.coo_y - 0.5)
                            {
                                if (floatBody.wristRight.coo_y >= floatBody.spineMid.coo_y)
                                {
                                    detected = true;
                                }
                            }
                        }
                    }
                }
            }

            return detected;
        }

        private bool ArmsFrontPosition_L(Body body)
        {
            FloatBody floatBody;
            bool detected = false;
            floatBody = new FloatBody();
            floatBody.neck.coo_y = body.Joints[JointType.Neck].Position.Y;
            floatBody.spineMid.coo_y = body.Joints[JointType.SpineMid].Position.Y;
            floatBody.elbowLeft.coo_x = body.Joints[JointType.ElbowLeft].Position.X;
            floatBody.shoulderLeft.coo_x = body.Joints[JointType.ShoulderLeft].Position.X;
            floatBody.shoulderLeft.coo_y = body.Joints[JointType.ShoulderLeft].Position.Y;
            floatBody.spineShoulder.coo_z = body.Joints[JointType.SpineShoulder].Position.Z;
            floatBody.wristLeft.coo_x = body.Joints[JointType.WristLeft].Position.X;
            floatBody.wristLeft.coo_y = body.Joints[JointType.WristLeft].Position.Y;
            floatBody.wristLeft.coo_z = body.Joints[JointType.WristLeft].Position.Z;

            if (floatBody.wristLeft.coo_z < floatBody.spineShoulder.coo_z && floatBody.spineShoulder.coo_z - 0.4 > floatBody.wristLeft.coo_z)
            {
                if (floatBody.wristLeft.coo_y < floatBody.neck.coo_y)
                {
                    if (floatBody.wristLeft.coo_x >= floatBody.shoulderLeft.coo_x - 0.25 && floatBody.wristLeft.coo_y <= floatBody.shoulderLeft.coo_y)
                    {
                        if(floatBody.wristLeft.coo_x < floatBody.elbowLeft.coo_x)
                        {
                            if (floatBody.wristLeft.coo_y >= floatBody.shoulderLeft.coo_y - 0.5)
                            {
                                if (floatBody.wristLeft.coo_y >= floatBody.spineMid.coo_y)
                                {
                                    detected = true;
                                }
                            }
                        }
                    }
                }
            }

            return detected;
        }

        private bool Arms45UpPosition(Body body)
        {
            FloatBody floatBody;
            bool detected = false;
            floatBody = new FloatBody();
            floatBody.head.coo_y = body.Joints[JointType.Head].Position.Y;
            floatBody.shoulderLeft.coo_x = body.Joints[JointType.ShoulderLeft].Position.X;
            floatBody.shoulderRight.coo_x = body.Joints[JointType.ShoulderRight].Position.X;
            floatBody.elbowRight.coo_z = body.Joints[JointType.ElbowRight].Position.Z;
            floatBody.elbowLeft.coo_z = body.Joints[JointType.ElbowLeft].Position.Z;
            floatBody.wristLeft.coo_x = body.Joints[JointType.WristLeft].Position.X;
            floatBody.wristLeft.coo_y = body.Joints[JointType.WristLeft].Position.Y;
            floatBody.wristLeft.coo_z = body.Joints[JointType.WristLeft].Position.Z;
            floatBody.wristRight.coo_x = body.Joints[JointType.WristRight].Position.X;
            floatBody.wristRight.coo_y = body.Joints[JointType.WristRight].Position.Y;
            floatBody.wristRight.coo_z = body.Joints[JointType.WristRight].Position.Z;

            if (floatBody.wristLeft.coo_z < floatBody.elbowLeft.coo_z && floatBody.wristRight.coo_z < floatBody.elbowRight.coo_z)
            {
                if (floatBody.wristLeft.coo_x <= floatBody.shoulderLeft.coo_x)
                {
                    if (floatBody.wristRight.coo_x >= floatBody.shoulderRight.coo_x)
                    {
                        if (floatBody.wristRight.coo_y >= floatBody.head.coo_y && floatBody.wristLeft.coo_y >= floatBody.head.coo_y)
                        {
                            detected = true;
                        }
                    }
                }
            }

            return detected;
        }

        private bool Arms45DownPosition(Body body)
        {
            FloatBody floatBody;
            bool detected = false;
            floatBody = new FloatBody();
            floatBody.spineMid.coo_y = body.Joints[JointType.SpineMid].Position.Y;
            floatBody.spineBase.coo_y = body.Joints[JointType.SpineBase].Position.Y;
            floatBody.shoulderLeft.coo_x = body.Joints[JointType.ShoulderLeft].Position.X;
            floatBody.shoulderRight.coo_x = body.Joints[JointType.ShoulderRight].Position.X;
            floatBody.elbowRight.coo_z = body.Joints[JointType.ElbowRight].Position.Z;
            floatBody.elbowLeft.coo_z = body.Joints[JointType.ElbowLeft].Position.Z;
            floatBody.handTipLeft.coo_x = body.Joints[JointType.HandTipLeft].Position.X;
            floatBody.handTipLeft.coo_y = body.Joints[JointType.HandTipLeft].Position.Y;
            floatBody.handTipLeft.coo_z = body.Joints[JointType.HandTipLeft].Position.Z;
            floatBody.handTipRight.coo_x = body.Joints[JointType.HandTipRight].Position.X;
            floatBody.handTipRight.coo_y = body.Joints[JointType.HandTipRight].Position.Y;
            floatBody.handTipRight.coo_z = body.Joints[JointType.HandTipRight].Position.Z;

            if (floatBody.handTipLeft.coo_z < floatBody.elbowLeft.coo_z && floatBody.handTipRight.coo_z < floatBody.elbowRight.coo_z)
            {
                if (floatBody.handTipLeft.coo_x <= floatBody.shoulderLeft.coo_x)
                {
                    if (floatBody.handTipRight.coo_x >= floatBody.shoulderRight.coo_x)
                    {
                        if (floatBody.handTipRight.coo_y <= floatBody.spineMid.coo_y && floatBody.handTipLeft.coo_y <= floatBody.spineMid.coo_y)
                        {
                            if(floatBody.handTipRight.coo_y >= floatBody.spineBase.coo_y && floatBody.handTipLeft.coo_y >= floatBody.spineBase.coo_y)
                            {
                                detected = true;
                            }                           
                        }
                    }
                }
            }

            return detected;
        }

        private bool ArmsRectanglePosition_L(Body body)
        {
            bool detected = false;
            twoHandedGesture = false;
            if (ArmsHRectanglePosition_L(body) && ArmsSidePosition_R(body))
            {
                twoHandedGesture = true;
                detected = true;
            }

            return detected;
        }

        private bool ArmsRectanglePosition_R(Body body)
        {
            bool detected = false;
            twoHandedGesture = false;
            if (ArmsHRectanglePosition_R(body) && ArmsSidePosition_L(body))
            {
                twoHandedGesture = true;
                detected = true;
            }

            return detected;
        }

        private bool ArmsSquarePosition_L(Body body)
        {
            bool detected = false;
            twoHandedGesture = false;
            if (ArmsFrontPosition_L(body) && ArmsSidePosition_R(body))
            {
                twoHandedGesture = true;
                detected = true;
            }

            return detected;
        }

        private bool ArmsSquarePosition_R(Body body)
        {
            bool detected = false;
            twoHandedGesture = false;
            if (ArmsFrontPosition_R(body) && ArmsSidePosition_L(body))
            {
                twoHandedGesture = true;
                detected = true;
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
