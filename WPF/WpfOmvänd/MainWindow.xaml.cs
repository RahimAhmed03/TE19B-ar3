using System.Net.Mime;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfOmvänd
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

        private void Click_KÖR(object sender, RoutedEventArgs e)
        {
            // Läs in texten
            string text = rutaText.Text;

            // Skicka ut omvänd text
            string omvändText= "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                omvändText += text[i];
            }
            omvändRuta.Text = omvändText;
        }
    }
}
