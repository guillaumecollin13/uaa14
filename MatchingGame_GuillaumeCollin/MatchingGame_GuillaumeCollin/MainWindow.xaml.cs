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
using System.Windows.Threading;

namespace MatchingGame_GuillaumeCollin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int index;
        string nextmoji;
        Random nbAlea =new Random();
        bool trouverPaire =false;
        TextBlock derniereTBClique;
        DispatcherTimer timer = new DispatcherTimer();
        int tempsEcoule;
        int nbPairesTrouvees;
        public MainWindow()
        {
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += new EventHandler(Timer_Tick);
            InitializeComponent();
            SetUpGame();
        }
    

       private void SetUpGame()
        {
            tempsEcoule = 0;
            nbPairesTrouvees = 0;
            timer.Start();
            List<string> animalsEmoji = new List<string>()
        {
            "🐵","🐵",
            "🐶","🐶",
            "🐱","🐱",
            "🦊","🦊",
            "🐺","🐺",
            "🦁","🦁",
            "🐴","🐴",
            "🐸","🐸",
        };
            foreach (TextBlock textBlock in grdMain.Children.OfType<TextBlock>()) 
            {
                if (textBlock.Name != "txtTemps")
                {
                    index = nbAlea.Next(animalsEmoji.Count);
                    nextmoji = animalsEmoji[index];
                    textBlock.Text = nextmoji;
                    animalsEmoji.RemoveAt(index);
                }
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlockactif = sender as TextBlock;
            if (!trouverPaire)
            {
                textBlockactif.Visibility = Visibility.Hidden;
                derniereTBClique = textBlockactif;
                trouverPaire = true;
            } else if(textBlockactif.Text == derniereTBClique.Text)
            {
                nbPairesTrouvees++;
                textBlockactif.Visibility = Visibility.Hidden;
                trouverPaire = false;
            }else
            {
                derniereTBClique.Visibility = Visibility.Visible;
                trouverPaire = false;
            }

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tempsEcoule++;
            txtTemps.Text= (tempsEcoule/10).ToString("0.0s");
            if (nbPairesTrouvees==8)
            {
                timer.Stop();
                txtTemps.Text = txtTemps.Text + "- Rejouer";
            }
        }
        private void txtTemps_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (nbPairesTrouvees == 8)
            {
                SetUpGame();
            }
        }



    }

}
