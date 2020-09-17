namespace Kinectronics
{
    using Microsoft.Kinect;
    using System;
    using Kinectronics.GestureDataBases;
    using System.Windows.Controls;

    public class GestureDetector
    {

        // Textblocks for displaying data in the GUI
        private TextBlock database_gd;
        private TextBlock gesture_gd;
        private TextBlock device_gd;
        private TextBlock command_gd;

        // Here you can make reference to another gesture db
        private KinectronicsDefaultGestureDataBase gestureDB;

        public string detectedGesture = null;

        // Definition of the device to use, e.g.
        // private EV3MobileRobot eV3Mobile = null;

        // Definition of the connection type (Uncomment for your app)
        // private string connectionType = "WiFi";

        public GestureDetector(KinectSensor kinectSensor, TextBlock database, TextBlock gesture, TextBlock device, TextBlock command)
        {
            if (kinectSensor == null)
            {
                throw new ArgumentNullException("kinectSensor");
            }
            gestureDB = new KinectronicsDefaultGestureDataBase();
            database_gd = database;
            gesture_gd = gesture;
            device_gd = device;
            command_gd = command;

            // Show in the UI the db used, so far is a manual task
            this.database_gd.Text = "KinectronicsDefaultGestureDataBase";

            // Write your program's logic from this point:

            // Show the device in the GUI, so far is a manual task
            this.device_gd.Text = "Undefined Device";

            // Example of a Bebop2 App:
            /*
            // Inicialization of the Bebop2 Object
            eV3Mobile = new EV3MobileRobot(connectionType);

            // Try to reach ev3 through WiFi
            eV3Mobile.StablishConnection();
            */
        }

        public string DetectGesture(Body body)
        {
            if (body != null)
            {
                if (body.IsTracked)
                {
                    detectedGesture = gestureDB.GetGesture(body);
                    // Show the tracked gesture in the UI
                    this.gesture_gd.Text = detectedGesture;
                    // Send the detected gesture to the controller method
                    Controller(detectedGesture);
                }
            }
            return "no tracked body";
        }

        // Controller Method, here a task for a device should be linked to a defined gesture
        // With the assignation of a string to command_gd, in the UI is displayed the command
        // This controller works for the DefaultGestureDataBase. For custom ones, the cases
        // have to be modified.
        private void Controller(string detectedGesture)
        {
            switch (detectedGesture)
            {
                case "Arms45UpPosition":
                    // E.G: this.command_gd.Text = "Move Up";
                    break;
                case "Arms45DownPosition":
                    break;
                case "ArmsFrontPosition_L":
                    break;
                case "ArmsFrontPosition_R":
                    break;
                case "ArmsHRectanglePosition_L":
                    break;
                case "ArmsHRectanglePosition_R":
                    break;
                case "ArmsRectanglePosition_L":
                    break;
                case "ArmsRectanglePosition_R":
                    break;
                case "ArmsSidePosition_L":
                    break;
                case "ArmsSidePosition_R":
                    break;
                case "ArmsSquarePosition_L":
                    break;
                case "ArmsSquarePosition_R":
                    break;
                default:
                    break;
            }
        }

        // Dispose Method
        public void Dispose()
        {
            // Here a the StopConnection for a device should be called.
            // E.G. eV3Mobile.StopConnection();
        }

    }
}
