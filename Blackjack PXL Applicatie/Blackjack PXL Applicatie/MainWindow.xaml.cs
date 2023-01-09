using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        string Tester = "Welkom";
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private async void btnDeel_Click(object sender, RoutedEventArgs e)
        {
            var randomnr = new Random();
            int randomnr1 = randomnr.Next(1, 11);
            string rndmnr1 = Convert.ToString(randomnr1);


            int randomnr001 = randomnr.Next(1, 11);
            string rndmnr01 = Convert.ToString(randomnr001);

            int randomnrdealer = randomnr.Next(1, 11);
            string rndmnrdealer = Convert.ToString(randomnrdealer);
            
            lblTotaalSpeler.Content = randomnr001 + randomnr1;

            string Space = Environment.NewLine;

            var rndmsymb = new Random();
            string[] randomsymbolen = { "Klaver", "Ruit", "Schoppen", "Harten" };
            string randomsymbolen1 = randomsymbolen[rndmsymb.Next(randomsymbolen.Length)]; 
            string randomkaart = (randomsymbolen1 + " " + rndmnr1);


            string[] randomsymbolen0 = { "Klaver", "Ruit", "Schoppen", "Harten" };
            string randomsymbolen01 = randomsymbolen0[rndmsymb.Next(randomsymbolen0.Length)];
            string randomkaart0 = (randomsymbolen01 + " " + rndmnr01);


            string[] randomsymbolendealer = { "Klaver", "Ruit", "Schoppen", "Harten" };
            string randomsymbolendealer1 = randomsymbolen[rndmsymb.Next(randomsymbolendealer.Length)];
            string randomkaartdealer = (randomsymbolendealer1 + " " + rndmnrdealer);

            StringBuilder builder= new StringBuilder();
            var newstringbuilder = builder;
            builder.Append(randomkaart + Space + randomkaart0);

            txtSpeler1.Text =(randomkaart + Space + randomkaart0);
            txtSpeler2.Text = (randomkaartdealer + Space + "Nog onbekend");
        }

        private void btnHit_Click(object sender, RoutedEventArgs e)
        {
            var rndmnr = new Random();
            int randomn1 = rndmnr.Next(1, 11);
            string rndmnrummer = Convert.ToString(randomn1);

            var rndmsymb = new Random();
            string[] randomsymbolen = { "Klaver", "Ruit", "Schoppen", "Harten" };
            string randomsymbolen1 = randomsymbolen[rndmsymb.Next(randomsymbolen.Length)];
            string randomkaart = (randomsymbolen1 + " ");
                        
            StringBuilder strng = new StringBuilder(txtSpeler1.Text);
            var newstrng = strng;
            newstrng.Append(randomkaart);
           
        }


        private void btnQuit_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnReset_Click_1(object sender, RoutedEventArgs e)
        {
            txtSpeler1.Text = string.Empty;
            txtSpeler2.Text = string.Empty;
            lblBankScore.Content = "0";
            lblSpelerScore.Content = "0";
            lblTotaalBank.Content = "0";
            lblTotaalSpeler.Content = "0";
        }
    }
}
