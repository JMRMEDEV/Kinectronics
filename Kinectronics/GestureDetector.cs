namespace Kinectronics
{
    using Microsoft.Kinect;
    using System;
    using Kinectronics.GestureDataBases;
    using System.Windows.Controls;

    public class GestureDetector
    {

        private TextBlock textblock_gd;
        private KTDef1 gestureDB;

        public GestureDetector(KinectSensor kinectSensor, TextBlock textblock)
        {
            if (kinectSensor == null)
            {
                throw new ArgumentNullException("kinectSensor");
            }
            gestureDB = new KTDef1();
            textblock_gd = textblock;
        }

        public void detectGesture(Body body)
        {
            if (body != null)
            {
                if (body.IsTracked)
                {
                    this.textblock_gd.Text = gestureDB.getGesture(body);
                }
            }
        }

    }
}
