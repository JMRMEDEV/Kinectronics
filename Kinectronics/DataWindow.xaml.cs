using System.Windows;

namespace Kinectronics
{
    public partial class DataWindow : Window
    {
        public VisualDataTracker.SelectedJoints selectedJoints;
        private int currentJointNumber = 0;
        private int jointSlotCount = 0;

        public DataWindow()
        {
            InitializeComponent();
            selectedJoints = new VisualDataTracker.SelectedJoints();
        }

        private void Joint1_DropDownOpened(object sender, System.EventArgs e)
        {
            currentJointNumber = 1;

        }

        private void Joint2_DropDownOpened(object sender, System.EventArgs e)
        {
            currentJointNumber = 2;
        }

        private void Joint3_DropDownOpened(object sender, System.EventArgs e)
        {
            currentJointNumber = 3;
        }

        private void Joint4_DropDownOpened(object sender, System.EventArgs e)
        {
            currentJointNumber = 4;
        }

        private void Joint5_DropDownOpened(object sender, System.EventArgs e)
        {
            currentJointNumber = 5;
        }

        public void Head_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.head.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.head.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.head.joint_number = currentJointNumber;
                        selectedJoints.head.tracked = true;
                        this.HeadActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Neck_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.neck.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.neck.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.neck.joint_number = currentJointNumber;
                        selectedJoints.neck.tracked = true;
                        this.NeckActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Spine_S_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.spineShoulder.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.spineShoulder.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.spineShoulder.joint_number = currentJointNumber;
                        selectedJoints.spineShoulder.tracked = true;
                        this.Spine_SActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Shoulder_R_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.shoulderRight.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.shoulderRight.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.shoulderRight.joint_number = currentJointNumber;
                        selectedJoints.shoulderRight.tracked = true;
                        this.Shoulder_RActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Shoulder_L_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.shoulderLeft.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.shoulderLeft.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.shoulderLeft.joint_number = currentJointNumber;
                        selectedJoints.shoulderLeft.tracked = true;
                        this.Shoulder_LActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Spine_M_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.spineMid.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.spineMid.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.spineMid.joint_number = currentJointNumber;
                        selectedJoints.spineMid.tracked = true;
                        this.Spine_MActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Elbow_R_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.elbowRight.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.elbowRight.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.elbowRight.joint_number = currentJointNumber;
                        selectedJoints.elbowRight.tracked = true;
                        this.Elbow_RActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Elbow_L_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.elbowLeft.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.elbowLeft.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.elbowLeft.joint_number = currentJointNumber;
                        selectedJoints.elbowLeft.tracked = true;
                        this.Elbow_LActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Spine_B_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.spineBase.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.spineBase.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.spineBase.joint_number = currentJointNumber;
                        selectedJoints.spineBase.tracked = true;
                        this.Spine_BActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Hip_R_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.hipRight.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.hipRight.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.hipRight.joint_number = currentJointNumber;
                        selectedJoints.hipRight.tracked = true;
                        this.Hip_RActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Hip_L_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.hipLeft.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.hipLeft.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.hipLeft.joint_number = currentJointNumber;
                        selectedJoints.hipLeft.tracked = true;
                        this.Hip_LActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Wrist_R_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.wristRight.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.wristRight.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.wristRight.joint_number = currentJointNumber;
                        selectedJoints.wristRight.tracked = true;
                        this.Wrist_RActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Wrist_L_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.wristLeft.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.wristLeft.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.wristLeft.joint_number = currentJointNumber;
                        selectedJoints.wristLeft.tracked = true;
                        this.Wrist_LActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Thumb_R_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.thumbRight.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.thumbRight.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.thumbRight.joint_number = currentJointNumber;
                        selectedJoints.thumbRight.tracked = true;
                        this.Thumb_RActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Thumb_L_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.thumbLeft.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.thumbLeft.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.thumbLeft.joint_number = currentJointNumber;
                        selectedJoints.thumbLeft.tracked = true;
                        this.Thumb_LActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Hand_R_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.handRight.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.handRight.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.handRight.joint_number = currentJointNumber;
                        selectedJoints.handRight.tracked = true;
                        this.Hand_RActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Hand_L_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.handLeft.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.handLeft.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.handLeft.joint_number = currentJointNumber;
                        selectedJoints.handLeft.tracked = true;
                        this.Hand_LActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Hand_TR_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.handTipRight.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.handTipRight.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.handTipRight.joint_number = currentJointNumber;
                        selectedJoints.handTipRight.tracked = true;
                        this.Hand_TRActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Hand_TL_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.handTipLeft.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.handTipLeft.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.handTipLeft.joint_number = currentJointNumber;
                        selectedJoints.handTipLeft.tracked = true;
                        this.Hand_TLActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Knee_R_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.kneeRight.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.kneeRight.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.kneeRight.joint_number = currentJointNumber;
                        selectedJoints.kneeRight.tracked = true;
                        this.Knee_RActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Knee_L_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.kneeLeft.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.kneeLeft.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.kneeLeft.joint_number = currentJointNumber;
                        selectedJoints.kneeLeft.tracked = true;
                        this.Knee_LActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Ankle_R_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.ankleRight.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.ankleRight.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.ankleRight.joint_number = currentJointNumber;
                        selectedJoints.ankleRight.tracked = true;
                        this.Ankle_RActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Ankle_L_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.ankleLeft.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.ankleLeft.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.ankleLeft.joint_number = currentJointNumber;
                        selectedJoints.ankleLeft.tracked = true;
                        this.Ankle_RActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Foot_R_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.footRight.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.footRight.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.footRight.joint_number = currentJointNumber;
                        selectedJoints.footRight.tracked = true;
                        this.Foot_RActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        public void Foot_L_CB_Item_Selected(object sender, RoutedEventArgs e)
        {
            if (jointSlotCount == 5)
            {
                MessageBox.Show("You're already using this joint slot");
            }
            else
            {
                if (selectedJoints.footLeft.joint_number == currentJointNumber || currentJointNumber == jointSlotCount)
                {
                    MessageBox.Show("You're already using this joint slot");
                }
                else
                {
                    if (selectedJoints.footLeft.tracked == true)
                    {
                        MessageBox.Show("You already selected this joint", "Invalid selection");
                    }
                    else
                    {
                        selectedJoints.footLeft.joint_number = currentJointNumber;
                        selectedJoints.footLeft.tracked = true;
                        this.Foot_LActiveJoint.Visibility = Visibility.Visible;
                        jointSlotCount++;
                    }
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Hide();
        }
    }
}
