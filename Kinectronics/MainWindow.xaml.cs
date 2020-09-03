using System;
using System.ComponentModel;
using System.Windows;

namespace Kinectronics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConnectionManager connection = null;
        private BodyManager bodyManager = null;
        private TextBlockBody textBlockBody = null;
        private DataWindow dataWindow;

        public MainWindow()
        {
            this.InitializeComponent();
            dataWindow = new DataWindow();
            connection = new ConnectionManager(this.statusMessage);
            bodyManager = new BodyManager(this.dataWindow);
            bodyManager.OpenBodyReader(connection.KinectConnect());

            this.DataContext = this;
            this.BodyViewbox.DataContext = this.bodyManager.viewer;
        }

        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            bodyManager.CloseBodyReader();
            connection.KinnectDisconnect();
        }

        private void TrackJointData_Click(object sender, RoutedEventArgs e)
        {
            dataWindow.Show();
        }
    }
}
