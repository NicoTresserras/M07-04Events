using System.Diagnostics;
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

namespace Pr01
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Has clicat el Butó 2!!!!!!!!!!!!");
            //Trace.WriteLine("text");
            //MessageBox.Show("Has clicat el Butó 2!!!!!!!!!!!!");
        }

        /*private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Has clicat l'Stack!!!!!!!!!!!!");
        }*/

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Panel panel = sender as Panel;
            string nom = panel.Name;
            Debug.WriteLine("{0}: Has clicat {1}!!!!!!!!!!!!!", sender.GetType().Name.ToString(), nom);
            e.Handled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Has clicat el Butó 3!!!!!!!!!!!!");
            
        }

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Aixó de l'stack va després del butó!!!!!");
            e.Handled = true;
        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("La window té un click?!?!?!");
        }

        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Aquest text de Window és el primer");
        }
    }
}