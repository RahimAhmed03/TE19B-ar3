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

namespace Labb19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //static List<Bok> bokSamling = new List<Bok>();
        //static List<Film> filmSamling = new List<Film>();
        static List<Media> samling = new List<Media>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void KlickSparaBok(object sender, RoutedEventArgs e)
        {
            // Skapa en instans av bok för att lagra bokens data
            Bok boken = new Bok(rutaBoktitel.Text, rutaFörfattare.Text, rutaAntalSidor.Text);
            //bokSamling.Add(boken);
            samling.Add(boken);

            // Fyll på i stora textrutan
            rutaResultat.Items.Add(boken.TillText());
        }
        private void KlickSparaFilm(object sender, RoutedEventArgs e)
        {
            // Skapa en instans av film för att lagra filmens data
            Film filmen = new Film(rutaFilmtitel.Text, rutaRegissör.Text, rutaLängd.Text);
            //filmSamling.Add(filmen);
            samling.Add(filmen);

            // Fyll på i stora textrutan
            rutaResultat.Items.Add(filmen.TillText());
        }
        private void KlickRadio(object sender, RoutedEventArgs e)
        {
            if (allt.IsChecked == true)
            {
                Console.WriteLine("Radiobutton allt trycktes!");
            }
            if (bocker.IsChecked == true)
            {
                Console.WriteLine("Radiobutton böcker trycktes!");
            }
            if (filmer.IsChecked == true)
            {
                Console.WriteLine("Radiobutton filmer trycktes!");
            }

            // Alternativ 2

            string typ = ((RadioButton)sender).Name;
            bool ärBok = false;
            bool ärFilm = false;
            switch (typ)
            {
                case "allt":
                ärBok = true;
                ärFilm = true;
                break;


                case "böcker":
                ärBok = true;  
                break;


                case "filmer":
                ärFilm = true;
                break;
            }

            // Vilken typ av instans är det?
            /*
            if (instans is Bok)
            {
                
            }
            if (instans is Media)
            {
                
            }
            */

            // Loopa igenom samling
            foreach (var sak in samling)
            {
                if (sak is Bok && ärBok)
                {
                    textRuta.Item.Add(((Bok)sak).TillText);
                }
                
            }
        }
    }
}
