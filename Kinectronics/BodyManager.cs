using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.Kinect;

namespace Kinectronics
{
    public class BodyManager
    {
        private KinectSensor kinect = null;
        private BodyFrameReader bodyFrameReader = null; //Create and initializes a BodyFrameReader object, used to get Body data from the sensor
        private DataTracker tracker = null;
        private DataWindow dataWindow_bm;
        private TextBlock textBlock_bm;
        public GestureDetector gestureDetector = null;
        public BodyViewer viewer = null;

        public BodyManager(DataWindow dataWindow, TextBlock textblock)
        {
            dataWindow_bm = dataWindow;
            textBlock_bm = textblock;
        }
        
        public void OpenBodyReader(KinectSensor kinectSensor)
        {
            kinect = kinectSensor;
            this.bodyFrameReader = this.kinect.BodyFrameSource.OpenReader();
            this.bodyFrameReader.FrameArrived += this.Reader_BodyFrameArrived;
            this.viewer = new BodyViewer(this.kinect);
            this.tracker = new DataTracker(this.kinect, this.dataWindow_bm);
            this.gestureDetector = new GestureDetector(this.kinect, this.textBlock_bm);
        }

        public void CloseBodyReader()
        {
            if (this.bodyFrameReader != null)
            {
                // BodyFrameReader is IDisposable
                this.bodyFrameReader.FrameArrived -= this.Reader_BodyFrameArrived;
                this.bodyFrameReader.Dispose();
                this.bodyFrameReader = null;
            }
        }

        //Method for measuring distance to a specific point
        private static double VectorLength(CameraSpacePoint point)
        {
            var result = Math.Pow(point.X, 2) + Math.Pow(point.Y, 2) + Math.Pow(point.Z, 2);

            result = Math.Sqrt(result);

            return result;
        }

        //Method that tracks all the available bodies at the environment and only considers the closest one
        private static Body FindClosestBody(BodyFrame bodyFrame)
        {
            Body result = null;
            double closestBodyDistance = double.MaxValue;

            Body[] bodies = new Body[bodyFrame.BodyCount];
            bodyFrame.GetAndRefreshBodyData(bodies);

            foreach (var body in bodies)
            {
                if (body.IsTracked)
                {
                    var currentLocation = body.Joints[JointType.SpineBase].Position;

                    var currentDistance = VectorLength(currentLocation);

                    if (result == null || currentDistance < closestBodyDistance)
                    {
                        result = body;
                        closestBodyDistance = currentDistance;
                    }
                }
            }

            return result;
        }

        private void Reader_BodyFrameArrived(object sender, BodyFrameArrivedEventArgs e)
        {
            var frameReference = e.FrameReference;

            using (var frame = frameReference.AcquireFrame())
            {
                if (frame == null)
                {
                    // We might miss the chance to acquire the frame, it will be null if it's missed
                    return;
                }

                Body selectedBody = FindClosestBody(frame);

                if (selectedBody == null)
                {
                    return;
                } else
                {
                    this.viewer.UpdateBodyFrame(selectedBody);
                    this.tracker.GetJointsCoordinates(selectedBody);
                    this.gestureDetector.detectGesture(selectedBody);
                }
            }
        }

        protected virtual void OnKinectEventTriggered(KinectEventArgs e)
        {
            EventHandler<KinectEventArgs> handler = KinectEventTriggered;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<KinectEventArgs> KinectEventTriggered;

    }
}
