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
            this.InitializeComponent();
            dataWindow = new DataWindow();
            connection = new ConnectionManager(this.statusMessage);
            bodyManager = new BodyManager(this.dataWindow, this.database, this.gesture, this.device, this.command);
            bodyManager.OpenBodyReader(connection.KinectConnect());

            this.DataContext = this;
            this.BodyViewbox.DataContext = this.bodyManager.viewer;
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
