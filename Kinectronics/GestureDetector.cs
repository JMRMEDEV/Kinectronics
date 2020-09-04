namespace Kinectronics
{
    using Microsoft.Kinect;
    using System;
    using Kinectronics.GestureDataBases;
    using System.Windows.Controls;

    public class GestureDetector
    {

        private TextBlock textblock_gd;
        private KinectronicsDefaultGestureDataBase gestureDB;

        public GestureDetector(KinectSensor kinectSensor, TextBlock textblock)
        {
            if (kinectSensor == null)
            {
                throw new ArgumentNullException("kinectSensor");
            }
            gestureDB = new KinectronicsDefaultGestureDataBase();
            textblock_gd = textblock;
        }

        public void DetectGesture(Body body)
        {
            if (body != null)
            {
                if (body.IsTracked)
                {
                    this.textblock_gd.Text = gestureDB.GetGesture(body);
                }
            }
        }

    }
}
