// 1. Arms45DownPosition (working) --Requires Closed Hand States
// 2. Arms45UpPosition (working) --Requires Closed Hand States
// 3. ArmsFrontPosition_L (working)
// 4. ArmsFrontPosition_R (working)
// 5. ArmsHRectanglePosition_L (working)
// 6. ArmsHRectanglePosition_R (working)
// 7. ArmsRectanglePosition_L (working) --Requires Closed Hand State
// 8. ArmsRectanglePosition_R (working) --Requires Closed Hand State
// 9. ArmsSidePosition_L (working)
// 10. ArmsSidePosition_R (working
// 11. ArmsSquarePosition_L (working) --Requires Closed Hand State
// 12. ArmsSquarePosition_R (working) --Requires Closed Hand State

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
                    if (Arms45DownPosition(body) && body.HandLeftState == HandState.Closed && body.HandRightState == HandState.Closed) // Gesture 1
                    {
                        gesture = "Arms45DownPosition";
                    }
                    if (Arms45UpPosition(body) && body.HandLeftState == HandState.Closed && body.HandRightState == HandState.Closed) // Gesture 2
                    {
                        gesture = "Arms45UpPosition";
                    }
                    if (ArmsFrontPosition_L(body) && !twoHandedGesture && body.HandLeftState == HandState.Open) // Gesture 3
                    {
                        gesture = "ArmsFrontPosition_L";
                    }
                    if (ArmsFrontPosition_R(body) && !twoHandedGesture && body.HandRightState == HandState.Open) // Gesture 4
                    {
                        gesture = "ArmsFrontPosition_R";
                    }
                    if (ArmsHRectanglePosition_L(body) && !twoHandedGesture && body.HandLeftState == HandState.Open) // Gesture 5
                    {
                        gesture = "ArmsHRectanglePosition_L";
                    }
                    if (ArmsHRectanglePosition_R(body) && !twoHandedGesture && body.HandRightState == HandState.Open) // Gesture 6
                    {
                        gesture = "ArmsHRectanglePosition_R";
                    }
                    if (ArmsRectanglePosition_L(body)) // Gesture 7
                    {
                        gesture = "ArmsRectanglePosition_L";
                    }
                    if (ArmsRectanglePosition_R(body)) // Gesture 8
                    {
                        gesture = "ArmsRectanglePosition_R";
                    }
                    if (ArmsSidePosition_L(body) && !twoHandedGesture && body.HandLeftState == HandState.Open) // Gesture 9
                    {
                        gesture = "ArmsSidePosition_L";
                    }
                    if (ArmsSidePosition_R(body) && !twoHandedGesture && body.HandRightState == HandState.Open) // Gesture 10
                    {
                        gesture = "ArmsSidePosition_R";
                    }
                    if (ArmsSquarePosition_L(body)) // Gesture 11
                    {
                        gesture = "ArmsSquarePosition_L";
                    }
                    if (ArmsSquarePosition_R(body)) // Gesture 12
                    {
                        gesture = "ArmsSquarePosition_R";
                    }
                }
            }

            return gesture;
        }

        // Gesture 1
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
                            if (floatBody.handTipRight.coo_y >= floatBody.spineBase.coo_y && floatBody.handTipLeft.coo_y >= floatBody.spineBase.coo_y)
                            {
                                detected = true;
                            }
                        }
                    }
                }
            }

            return detected;
        }

        // Gesture 2
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

        // Gesture 3
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
                        if (floatBody.wristLeft.coo_x < floatBody.elbowLeft.coo_x)
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

        // Gesture 4
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
                if (floatBody.wristRight.coo_y < floatBody.neck.coo_y)
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

        // Gesture 5
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

        // Gesture 6
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

        // Gesture 7
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

        // Gesture 8
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

        // Gesture 9
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

        // Gesture 10
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

        // Gesture 11
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

        // Gesture 12
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
    }
}
