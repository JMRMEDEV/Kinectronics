using Microsoft.Kinect;
using System.ComponentModel;
using System.Windows.Controls;

namespace Kinectronics
{
    public class ConnectionManager
    {
        private KinectSensor kinectSensor = null; //Create and initializes a KinectSensor object, used for setting the sensor active
        private TextBlock _statusMessage = null;

        public ConnectionManager(TextBlock statusMessage)
        {
            _statusMessage = statusMessage;
        }

        //Method used for stablishing a connection with the sensor and opening the needed sensor data acquirers
        public KinectSensor KinectConnect()
        {
            this.kinectSensor = KinectSensor.GetDefault();
            this.kinectSensor.IsAvailableChanged += this.Sensor_IsAvailableChanged;
            this.kinectSensor.Open();
            return this.kinectSensor;
        }

        //Method used for stoping the connection with the sensor and opening sensor data acquirers used
        public void KinnectDisconnect()
        {
            if (this.kinectSensor != null)
            {
                this.kinectSensor.IsAvailableChanged -= this.Sensor_IsAvailableChanged;
                this.kinectSensor.Close();
                this.kinectSensor = null;
            }
        }

        //Method for cheking the sensor physical connection status
        private void Sensor_IsAvailableChanged(object sender, IsAvailableChangedEventArgs e)
        {
            if (kinectSensor != null)
            {
                if (this.kinectSensor.IsAvailable != true)
                {
                    this._statusMessage.Text = "Triyng to reach the Kinect Sensor";
                }
                else
                {
                    this._statusMessage.Text = "Connection stablished";
                }
            }
        }
    }
}
