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
            float tal1 = float.Parse(tal1Ruta.Text);
            float tal2 = float.Parse(tal2Ruta.Text);

            resultatRuta.Text = $"{tal1} + {tal2} = {tal1 + tal2}";
        }

        private void knappMinusClick(Object sender, RoutedEventArgs e)
        {
            float tal1 = float.Parse(tal1Ruta.Text);
            float tal2 = float.Parse(tal2Ruta.Text);

            resultatRuta.Text = $"{tal1} - {tal2} = {tal1 - tal2}";
        }

        private void knappGångerClick(Object sender, RoutedEventArgs e)
        {
            float tal1 = float.Parse(tal1Ruta.Text);
            float tal2 = float.Parse(tal2Ruta.Text);

            resultatRuta.Text = $"{tal1} * {tal2} = {tal1 * tal2}";
        }

        private void knappDivideraClick(Object sender, RoutedEventArgs e)
        {
            float tal1 = float.Parse(tal1Ruta.Text);
            float tal2 = float.Parse(tal2Ruta.Text);

            resultatRuta.Text = $"{tal1} / {tal2} = {tal1 / tal2}";
        }
    }
}