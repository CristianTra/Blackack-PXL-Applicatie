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

namespace Blackjack_PXL_Applicatie
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

        private void btnDeel_Click(object sender, RoutedEventArgs e)
        {
            var randomnr = new Random();
            int randomnr1 = randomnr.Next(1, 11);
            string rndmnr1 = Convert.ToString(randomnr1);

            var randomnr01 = new Random();
            int randomnr001 = randomnr01.Next(1, 11);
            string rndmnr01 = Convert.ToString(randomnr1);

            lblTotaalSpeler.Content = randomnr001 + randomnr1;


            var rndmsymb = new Random();
            string[] randomsymbolen = { "Klaver", "Ruit", "Schoppen", "Harten" };
            string randomsymbolen1 = randomsymbolen[rndmsymb.Next(randomsymbolen.Length)];
            string randomkaart = (randomsymbolen1 + " " + rndmnr1);

            var rndmsymb0 = new Random();
            string[] randomsymbolen0 = { "Klaver", "Ruit", "Schoppen", "Harten" };
            string randomsymbolen01 = randomsymbolen0[rndmsymb0.Next(randomsymbolen0.Length)];
            string randomkaart0 = (randomsymbolen01 + " " + rndmnr01);

            txtSpeler1.Text = (randomkaart + randomkaart);
            txtSpeler1.Text = (randomkaart0); 
        }
    }
}
