using System.Windows;

namespace ChatApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
      
            InitializeComponent();


        }

        private void clickEpic_Click(object sender, RoutedEventArgs e)
        {
        
        }

        private void moveWindow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if(e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void clickMinimize_Click(object sender, RoutedEventArgs e)
        {
          Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void clickMaximize_Click(object sender, RoutedEventArgs e)
        {
          if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void clickClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}