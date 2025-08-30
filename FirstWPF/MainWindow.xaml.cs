using System.Windows;

namespace FirstWPF
{
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow() // code behind
        {
            InitializeComponent();
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e) // From UI
        {
            if (running) //stop
            {
                tbStatus.Text = "The test has been stopped";
                btnToggleRun.Content = "Run";
            } else //stop
            {
                tbStatus.Text = "The test is running";
                btnToggleRun.Content = "Stop";
            }
            running = !running;
        }
    }
}