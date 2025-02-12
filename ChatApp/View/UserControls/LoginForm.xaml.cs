using System.Windows;
using System.Windows.Controls;

namespace ChatApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : UserControl
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private int placeHolder;

        public int Placeholder
        {
            get { return placeHolder; }
            set { placeHolder = value; }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tboxInput.Clear();
            tboxInput.Focus();
        }

        private void tboxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(tboxInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
