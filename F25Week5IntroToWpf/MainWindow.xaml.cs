using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace F25Week5IntroToWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            string name = txtFirstname.Text;
            var result = MessageBox.Show("Hello " + name, "Message", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
                MessageBox.Show("YES clicked");
            else
                MessageBox.Show("NO clicked");
        }

        private void txtFirstname_GotFocus(object sender, RoutedEventArgs e)
        {
            txtFirstname.Background = Brushes.Cyan;
        }

        private void txtFirstname_LostFocus(object sender, RoutedEventArgs e)
        {
            txtFirstname.Background = Brushes.White;
        }

        private void btnShowGridWin_Click(object sender, RoutedEventArgs e)
        {
            GridExample win = new GridExample();
            //win.Owner = this;
            //this.Close();
            win.ShowDialog();
        }
    }
}