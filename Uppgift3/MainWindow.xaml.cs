using System;
using System.Windows;

namespace Uppgift3
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

        private void knappPlusClick(Object sender, RoutedEventArgs e)
        {
            // Flagga
            bool ärKorrektInmattat = true;

            // Töm resultatRutan
            resultatRuta.Text= "";

            // Försöker konvertera tal1 till en float
            float tal1;
            if (!float.TryParse( tal1Ruta.Text, out tal1 ))
            {
                MessageBox.Show("Tal1 Fel inmatning.\n Formatet Tex 2,5");
                ärKorrektInmattat = false;
            }

            // Försöker konvertera tal2 till en float
            float tal2;
            if (!float.TryParse( tal2Ruta.Text, out tal2 ))
            {
                MessageBox.Show("Tal2 Fel inmatning.\n Formatet Tex 2,5");
                ärKorrektInmattat = false;
            }

            if (ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} + {tal2} = {tal1 + tal2}";
            }
        }

        private void knappMinusClick(Object sender, RoutedEventArgs e)
        {
            // Flagga
            bool ärKorrektInmattat = true;

            // Töm resultatRutan
            resultatRuta.Text= "";

            // Försöker konvertera tal1 till en float
            float tal1;
            if (!float.TryParse( tal1Ruta.Text, out tal1 ))
            {
                MessageBox.Show("Tal1 Fel inmatning.\n Formatet Tex 2,5");
                ärKorrektInmattat = false;
            }

            // Försöker konvertera tal2 till en float
            float tal2;
            if (!float.TryParse( tal2Ruta.Text, out tal2 ))
            {
                MessageBox.Show("Tal2 Fel inmatning.\n Formatet Tex 2,5");
                ärKorrektInmattat = false;
            }

            if (ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} - {tal2} = {tal1 - tal2}";
            }
        }
        

        private void knappGångerClick(Object sender, RoutedEventArgs e)
        {
                     // Flagga
            bool ärKorrektInmattat = true;

            // Töm resultatRutan
            resultatRuta.Text= "";

            // Försöker konvertera tal1 till en float
            float tal1;
            if (!float.TryParse( tal1Ruta.Text, out tal1 ))
            {
                MessageBox.Show("Tal1 Fel inmatning.\n Formatet Tex 2,5");
                ärKorrektInmattat = false;
            }

            // Försöker konvertera tal2 till en float
            float tal2;
            if (!float.TryParse( tal2Ruta.Text, out tal2 ))
            {
                MessageBox.Show("Tal2 Fel inmatning.\n Formatet Tex 2,5");
                ärKorrektInmattat = false;
            }

            if (ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} * {tal2} = {tal1 * tal2}";
            }
        }

        private void knappDivideraClick(Object sender, RoutedEventArgs e)
        {
            // Flagga
            bool ärKorrektInmattat = true;

            // Töm resultatRutan
            resultatRuta.Text= "";

            // Försöker konvertera tal1 till en float
            float tal1;
            if (!float.TryParse( tal1Ruta.Text, out tal1 ))
            {
                MessageBox.Show("Tal1 Fel inmatning.\n Formatet Tex 2,5");
                ärKorrektInmattat = false;
            }

            // Försöker konvertera tal2 till en float
            float tal2;
            if (!float.TryParse( tal2Ruta.Text, out tal2 ))
            {
                MessageBox.Show("Tal2 Fel inmatning.\n Formatet Tex 2,5");
                ärKorrektInmattat = false;
            }

            if (ärKorrektInmattat)
            {
                resultatRuta.Text = $"{tal1} / {tal2} = {tal1 / tal2}";
            }
        }
    }
}