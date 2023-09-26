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

namespace MatchingGame_GuillaumeCollin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index;
        string nextmoji;
        Random nbAlea;
        bool trouverPaire;
        TextBlock derniereTBClique;
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }
    

       private void SetUpGame()
        {
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
            foreach (TextBlock textBlock in grdMain.children.oftype<TextBlock>()) 
            {
                index = nbAlea.Next(animalsEmoji.Count);
                nextmoji = animalsEmoji[index];
                textBlock.Text = nextmoji;
                animalsEmoji.RemoveAt(index);
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
                textBlockactif.Visibility = Visibility.Hidden;
                trouverPaire = true;
            }else
            {
                derniereTBClique.Visibility = Visibility.Visible;
                trouverPaire = false;
            }

        }
    }
}
