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

namespace Dobbel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd;
        int worp;
        int aantalWorpen;
        StringBuilder sb;
        public MainWindow()
        {
            InitializeComponent();
            // worp dobbelsteen van 1 tot 6
            rnd = new Random();
            worp = rnd.Next(1, 7);
            aantalWorpen = 0;

            sb = new StringBuilder();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            // automatisch laten gooien tot 6 is bereikt


            while (worp != 6)
            {
                aantalWorpen++;
                sb.AppendLine($"Worp {aantalWorpen.ToString()} is: {worp.ToString()}");
                resultTextBox.Text = sb.ToString();
                worp = rnd.Next(1, 7);
            }

            if (worp == 6)
            {
                aantalWorpen++;
                sb.AppendLine($"Worp {aantalWorpen.ToString()} is: {worp.ToString()}");
                resultTextBox.Text = sb.ToString();
            }
        }
           

        
        private void againButton_Click(object sender, RoutedEventArgs e)
        {
            worp = rnd.Next(1, 7);
            startButton.Focus();
            resultTextBox.Clear();
            aantalWorpen = 0;
            sb.Clear();
        }
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       
    }
}