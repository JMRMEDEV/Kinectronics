using System.ComponentModel;
using System.Windows;

namespace Kinectronics
{

    public partial class MainWindow : Window
    {
        private ConnectionManager connection = null;
        private BodyManager bodyManager = null;
        private DataWindow dataWindow;

        public MainWindow()
        {
            // Do not edit this section, unless you know what are you doing

            this.InitializeComponent();
            dataWindow = new DataWindow();
            connection = new ConnectionManager(this.statusMessage);
            bodyManager = new BodyManager(this.dataWindow, this.gesture);
            bodyManager.OpenBodyReader(connection.KinectConnect());

            this.DataContext = this;
            this.BodyViewbox.DataContext = this.bodyManager.viewer;

            // Write your program's logic from this point:
        }

        private void TrackJointData_Click(object sender, RoutedEventArgs e)
        {
            dataWindow.Show();
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            bodyManager.CloseBodyReader();
            connection.KinnectDisconnect();
            Application.Current.Shutdown();
        }

    }
}
