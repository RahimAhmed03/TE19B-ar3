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

namespace WpfUppgift1
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
            // Läs in text som ska krypteras
            string text = rutaText.Text;

            // Läs in nyckeln
            string nyckelString = rutaNyckel.Text;

            // Kolla om nyckeln verkligen är ett tal
            int nyckel = 0;
            while (!int.TryParse(nyckelString, out nyckel))
            {
                MessageBox.Show("Du måste mata in ett tal (1-9). Försök igen.");
                nyckelString = rutaNyckel.Text;
            }

            // Kryptera tecken för tecken
            string kryptadText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char bokstav = text[i];
                int ascii = (int)bokstav;
                int kryptadAscii = ascii + nyckel;

                if (kryptadAscii >= 90)
                {
                    kryptadAscii -= 26;
                }

                char kryptadBokstav = (char)(kryptadAscii);
                kryptadText += kryptadBokstav.ToString();
            }

            Console.WriteLine($"Den krypterade texten blir: {kryptadText}");
            rutaKrypterad.Text = kryptadText;
        }

    }
}
