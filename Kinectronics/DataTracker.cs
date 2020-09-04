namespace Kinectronics
{
    using System;
    using Microsoft.Kinect;
    public sealed class DataTracker
    {

        private DataWindow dataWindow_dt;

        public DataTracker(KinectSensor kinectSensor, DataWindow dataWindow)
        {

            dataWindow_dt = dataWindow;

            if (kinectSensor == null)
            {
                throw new ArgumentNullException("kinectSensor");
            }

        }

        private void ShowJointPosition(int jointSlot, float x, float y, float z)
        {
            switch (jointSlot)
            {
                case 1:
                    dataWindow_dt.J1_X_Cor.Text = x.ToString();
                    dataWindow_dt.J1_Y_Cor.Text = y.ToString();
                    dataWindow_dt.J1_Z_Cor.Text = z.ToString();
                    break;
                case 2:
                    dataWindow_dt.J2_X_Cor.Text = x.ToString();
                    dataWindow_dt.J2_Y_Cor.Text = y.ToString();
                    dataWindow_dt.J2_Z_Cor.Text = z.ToString();
                    break;
                case 3:
                    dataWindow_dt.J3_X_Cor.Text = x.ToString();
                    dataWindow_dt.J3_Y_Cor.Text = y.ToString();
                    dataWindow_dt.J3_Z_Cor.Text = z.ToString();
                    break;
                case 4:
                    dataWindow_dt.J4_X_Cor.Text = x.ToString();
                    dataWindow_dt.J4_Y_Cor.Text = y.ToString();
                    dataWindow_dt.J4_Z_Cor.Text = z.ToString();
                    break;
                case 5:
                    dataWindow_dt.J5_X_Cor.Text = x.ToString();
                    dataWindow_dt.J5_Y_Cor.Text = y.ToString();
                    dataWindow_dt.J5_Z_Cor.Text = z.ToString();
                    break;
                default:
                    break;
            }
        }

        public void GetJointsCoordinates(Body body)
        {
            if (body != null)
            {
                if (body.IsTracked)
                {
                    int i = 0;
                    float[] x_coor;
                    float[] y_coor;
                    float[] z_coor;
                    Joint[] jointsToTrack;

                    jointsToTrack = new Joint[6];
                    x_coor = new float[6];
                    y_coor = new float[6];
                    z_coor = new float[6];

                    if (dataWindow_dt.selectedJoints.head.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.head.joint_number] = body.Joints[JointType.Head];
                        x_coor[dataWindow_dt.selectedJoints.head.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.head.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.head.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.head.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.head.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.head.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.head.joint_number, x_coor[dataWindow_dt.selectedJoints.head.joint_number], y_coor[dataWindow_dt.selectedJoints.head.joint_number], z_coor[dataWindow_dt.selectedJoints.head.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.neck.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.neck.joint_number] = body.Joints[JointType.Neck];
                        x_coor[dataWindow_dt.selectedJoints.neck.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.neck.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.neck.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.neck.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.neck.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.neck.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.neck.joint_number, x_coor[dataWindow_dt.selectedJoints.neck.joint_number], y_coor[dataWindow_dt.selectedJoints.neck.joint_number], z_coor[dataWindow_dt.selectedJoints.neck.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.spineShoulder.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.spineShoulder.joint_number] = body.Joints[JointType.SpineShoulder];
                        x_coor[dataWindow_dt.selectedJoints.spineShoulder.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.spineShoulder.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.spineShoulder.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.spineShoulder.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.spineShoulder.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.spineShoulder.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.spineShoulder.joint_number, x_coor[dataWindow_dt.selectedJoints.spineShoulder.joint_number], y_coor[dataWindow_dt.selectedJoints.spineShoulder.joint_number], z_coor[dataWindow_dt.selectedJoints.spineShoulder.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.shoulderRight.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.shoulderRight.joint_number] = body.Joints[JointType.ShoulderRight];
                        x_coor[dataWindow_dt.selectedJoints.shoulderRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.shoulderRight.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.shoulderRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.shoulderRight.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.shoulderRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.shoulderRight.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.shoulderRight.joint_number, x_coor[dataWindow_dt.selectedJoints.shoulderRight.joint_number], y_coor[dataWindow_dt.selectedJoints.shoulderRight.joint_number], z_coor[dataWindow_dt.selectedJoints.shoulderRight.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.shoulderLeft.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.shoulderLeft.joint_number] = body.Joints[JointType.ShoulderLeft];
                        x_coor[dataWindow_dt.selectedJoints.shoulderLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.shoulderLeft.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.shoulderLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.shoulderLeft.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.shoulderLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.shoulderLeft.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.shoulderLeft.joint_number, x_coor[dataWindow_dt.selectedJoints.shoulderLeft.joint_number], y_coor[dataWindow_dt.selectedJoints.shoulderLeft.joint_number], z_coor[dataWindow_dt.selectedJoints.shoulderLeft.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.spineMid.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.spineMid.joint_number] = body.Joints[JointType.SpineMid];
                        x_coor[dataWindow_dt.selectedJoints.spineMid.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.spineMid.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.spineMid.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.spineMid.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.spineMid.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.spineMid.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.spineMid.joint_number, x_coor[dataWindow_dt.selectedJoints.spineMid.joint_number], y_coor[dataWindow_dt.selectedJoints.spineMid.joint_number], z_coor[dataWindow_dt.selectedJoints.spineMid.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.elbowRight.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.elbowRight.joint_number] = body.Joints[JointType.ElbowRight];
                        x_coor[dataWindow_dt.selectedJoints.elbowRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.elbowRight.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.elbowRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.elbowRight.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.elbowRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.elbowRight.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.elbowRight.joint_number, x_coor[dataWindow_dt.selectedJoints.elbowRight.joint_number], y_coor[dataWindow_dt.selectedJoints.elbowRight.joint_number], z_coor[dataWindow_dt.selectedJoints.elbowRight.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.elbowLeft.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.elbowLeft.joint_number] = body.Joints[JointType.ElbowLeft];
                        x_coor[dataWindow_dt.selectedJoints.elbowLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.elbowLeft.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.elbowLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.elbowLeft.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.elbowLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.elbowLeft.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.elbowLeft.joint_number, x_coor[dataWindow_dt.selectedJoints.elbowLeft.joint_number], y_coor[dataWindow_dt.selectedJoints.elbowLeft.joint_number], z_coor[dataWindow_dt.selectedJoints.elbowLeft.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.wristRight.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.wristRight.joint_number] = body.Joints[JointType.WristRight];
                        x_coor[dataWindow_dt.selectedJoints.wristRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.wristRight.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.wristRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.wristRight.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.wristRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.wristRight.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.wristRight.joint_number, x_coor[dataWindow_dt.selectedJoints.wristRight.joint_number], y_coor[dataWindow_dt.selectedJoints.wristRight.joint_number], z_coor[dataWindow_dt.selectedJoints.wristRight.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.wristLeft.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.wristLeft.joint_number] = body.Joints[JointType.WristLeft];
                        x_coor[dataWindow_dt.selectedJoints.wristLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.wristLeft.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.wristLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.wristLeft.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.wristLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.wristLeft.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.wristLeft.joint_number, x_coor[dataWindow_dt.selectedJoints.wristLeft.joint_number], y_coor[dataWindow_dt.selectedJoints.wristLeft.joint_number], z_coor[dataWindow_dt.selectedJoints.wristLeft.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.handRight.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.handRight.joint_number] = body.Joints[JointType.HandRight];
                        x_coor[dataWindow_dt.selectedJoints.handRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handRight.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.handRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handRight.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.handRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handRight.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.handRight.joint_number, x_coor[dataWindow_dt.selectedJoints.handRight.joint_number], y_coor[dataWindow_dt.selectedJoints.handRight.joint_number], z_coor[dataWindow_dt.selectedJoints.handRight.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.handLeft.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.handLeft.joint_number] = body.Joints[JointType.HandLeft];
                        x_coor[dataWindow_dt.selectedJoints.handLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handLeft.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.handLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handLeft.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.handLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handLeft.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.handLeft.joint_number, x_coor[dataWindow_dt.selectedJoints.handLeft.joint_number], y_coor[dataWindow_dt.selectedJoints.handLeft.joint_number], z_coor[dataWindow_dt.selectedJoints.handLeft.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.thumbRight.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.thumbRight.joint_number] = body.Joints[JointType.ThumbRight];
                        x_coor[dataWindow_dt.selectedJoints.thumbRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.thumbRight.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.thumbRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.thumbRight.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.thumbRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.thumbRight.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.thumbRight.joint_number, x_coor[dataWindow_dt.selectedJoints.thumbRight.joint_number], y_coor[dataWindow_dt.selectedJoints.thumbRight.joint_number], z_coor[dataWindow_dt.selectedJoints.thumbRight.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.thumbLeft.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.thumbLeft.joint_number] = body.Joints[JointType.ThumbLeft];
                        x_coor[dataWindow_dt.selectedJoints.thumbLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.thumbLeft.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.thumbLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.thumbLeft.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.thumbLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.thumbLeft.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.thumbLeft.joint_number, x_coor[dataWindow_dt.selectedJoints.thumbLeft.joint_number], y_coor[dataWindow_dt.selectedJoints.thumbLeft.joint_number], z_coor[dataWindow_dt.selectedJoints.thumbLeft.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.handTipRight.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.handTipRight.joint_number] = body.Joints[JointType.HandTipRight];
                        x_coor[dataWindow_dt.selectedJoints.handTipRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handTipRight.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.handTipRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handTipRight.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.handTipRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handTipRight.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.handTipRight.joint_number, x_coor[dataWindow_dt.selectedJoints.handTipRight.joint_number], y_coor[dataWindow_dt.selectedJoints.handTipRight.joint_number], z_coor[dataWindow_dt.selectedJoints.handTipRight.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.handTipLeft.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.handTipLeft.joint_number] = body.Joints[JointType.HandTipLeft];
                        x_coor[dataWindow_dt.selectedJoints.handTipLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handTipLeft.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.handTipLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handTipLeft.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.handTipLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.handTipLeft.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.handTipLeft.joint_number, x_coor[dataWindow_dt.selectedJoints.handTipLeft.joint_number], y_coor[dataWindow_dt.selectedJoints.handTipLeft.joint_number], z_coor[dataWindow_dt.selectedJoints.handTipLeft.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.spineBase.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.spineBase.joint_number] = body.Joints[JointType.SpineBase];
                        x_coor[dataWindow_dt.selectedJoints.spineBase.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.spineBase.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.spineBase.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.spineBase.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.spineBase.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.spineBase.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.spineBase.joint_number, x_coor[dataWindow_dt.selectedJoints.spineBase.joint_number], y_coor[dataWindow_dt.selectedJoints.spineBase.joint_number], z_coor[dataWindow_dt.selectedJoints.spineBase.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.hipRight.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.hipRight.joint_number] = body.Joints[JointType.HipRight];
                        x_coor[dataWindow_dt.selectedJoints.hipRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.hipRight.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.hipRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.hipRight.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.hipRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.hipRight.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.hipRight.joint_number, x_coor[dataWindow_dt.selectedJoints.hipRight.joint_number], y_coor[dataWindow_dt.selectedJoints.hipRight.joint_number], z_coor[dataWindow_dt.selectedJoints.hipRight.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.hipLeft.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.hipLeft.joint_number] = body.Joints[JointType.HipLeft];
                        x_coor[dataWindow_dt.selectedJoints.hipLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.hipLeft.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.hipLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.hipLeft.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.hipLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.hipLeft.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.hipLeft.joint_number, x_coor[dataWindow_dt.selectedJoints.hipLeft.joint_number], y_coor[dataWindow_dt.selectedJoints.hipLeft.joint_number], z_coor[dataWindow_dt.selectedJoints.hipLeft.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.kneeRight.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.kneeRight.joint_number] = body.Joints[JointType.KneeRight];
                        x_coor[dataWindow_dt.selectedJoints.kneeRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.kneeRight.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.kneeRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.kneeRight.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.kneeRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.kneeRight.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.kneeRight.joint_number, x_coor[dataWindow_dt.selectedJoints.kneeRight.joint_number], y_coor[dataWindow_dt.selectedJoints.kneeRight.joint_number], z_coor[dataWindow_dt.selectedJoints.kneeRight.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.kneeLeft.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.kneeLeft.joint_number] = body.Joints[JointType.KneeLeft];
                        x_coor[dataWindow_dt.selectedJoints.kneeLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.kneeLeft.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.kneeLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.kneeLeft.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.kneeLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.kneeLeft.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.kneeLeft.joint_number, x_coor[dataWindow_dt.selectedJoints.kneeLeft.joint_number], y_coor[dataWindow_dt.selectedJoints.kneeLeft.joint_number], z_coor[dataWindow_dt.selectedJoints.kneeLeft.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.ankleRight.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.ankleRight.joint_number] = body.Joints[JointType.AnkleRight];
                        x_coor[dataWindow_dt.selectedJoints.ankleRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.ankleRight.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.ankleRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.ankleRight.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.ankleRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.ankleRight.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.ankleRight.joint_number, x_coor[dataWindow_dt.selectedJoints.ankleRight.joint_number], y_coor[dataWindow_dt.selectedJoints.ankleRight.joint_number], z_coor[dataWindow_dt.selectedJoints.ankleRight.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.ankleLeft.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.ankleLeft.joint_number] = body.Joints[JointType.AnkleLeft];
                        x_coor[dataWindow_dt.selectedJoints.ankleLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.ankleLeft.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.ankleLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.ankleLeft.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.ankleLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.ankleLeft.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.ankleLeft.joint_number, x_coor[dataWindow_dt.selectedJoints.ankleLeft.joint_number], y_coor[dataWindow_dt.selectedJoints.ankleLeft.joint_number], z_coor[dataWindow_dt.selectedJoints.ankleLeft.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.footRight.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.footRight.joint_number] = body.Joints[JointType.FootRight];
                        x_coor[dataWindow_dt.selectedJoints.footRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.footRight.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.footRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.footRight.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.footRight.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.footRight.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.footRight.joint_number, x_coor[dataWindow_dt.selectedJoints.footRight.joint_number], y_coor[dataWindow_dt.selectedJoints.footRight.joint_number], z_coor[dataWindow_dt.selectedJoints.footRight.joint_number]);
                        i++;
                    }
                    if (dataWindow_dt.selectedJoints.footLeft.tracked && i < 6)
                    {
                        jointsToTrack[dataWindow_dt.selectedJoints.footLeft.joint_number] = body.Joints[JointType.FootLeft];
                        x_coor[dataWindow_dt.selectedJoints.footLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.footLeft.joint_number].Position.X;
                        y_coor[dataWindow_dt.selectedJoints.footLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.footLeft.joint_number].Position.Y;
                        z_coor[dataWindow_dt.selectedJoints.footLeft.joint_number] = jointsToTrack[dataWindow_dt.selectedJoints.footLeft.joint_number].Position.Z;
                        ShowJointPosition(dataWindow_dt.selectedJoints.footLeft.joint_number, x_coor[dataWindow_dt.selectedJoints.footLeft.joint_number], y_coor[dataWindow_dt.selectedJoints.footLeft.joint_number], z_coor[dataWindow_dt.selectedJoints.footLeft.joint_number]);
                        i++;
                    }
                }
            }
        }
    }
}
