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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            agencement();
        }
        public void  agencement()
        {
            ///ColumnDefinition col1 = new ColumnDefinition();
            ///grille.ColumnDefinitions.Add(col1); 
            ///Button btnB = new Button();
            ///btnB.Content = "Calculer";
            ///btnB.Height = 150;
            ///btnB.Width = 150;
            ///btnB.HorizontalAlignment = 0;
            ///btnB.HorizontalAlignment = HorizontalAlignment.Left;
            ///Grid.SetColumn(btnB, 0);
            ///grille.Children.Add(btnB);
            
            //definition de la grille
            ColumnDefinition[] colDef = new ColumnDefinition[3];
            for (int i = 0; i < 3; i++)
            {
                colDef[i] = new ColumnDefinition();
            }
            for (int i = 0; i < 3; i++)
            {
                grille.ColumnDefinitions.Add(colDef[i]);
            }
            RowDefinition[] rowDef = new RowDefinition[3];
            for (int i = 0; i < 3; i++)
            {
                rowDef[i] = new RowDefinition();
            }
            for (int i = 0; i < 3; i++)
            {
                grille.RowDefinitions.Add(rowDef[i]);
            }

            ///definition du stack pannel
            StackPanel stack = new StackPanel();

            Grid.SetColumnSpan(stack, 2);

            //defenition des texte block
            TextBlock text1= new TextBlock();
           
            text1.Text = "confidential liar";
            text1.FontFamily = new FontFamily("comic sans MS");
            text1.FontSize = 25;
            text1.Foreground = Brushes.Red;
            text1.Background = Brushes.Yellow;

            TextBlock text2 = new TextBlock();
            text2.Text = "attack:";
            text1.FontFamily = new FontFamily("comic sans MS");
            text1.FontSize = 20;
            text1.Foreground = Brushes.Black;
            text1.Background = Brushes.Yellow;


            stack.Children.Add(text2);
            Grid.SetColumnSpan(text1, 3);
            Grid.SetRow(text1, 0);

            grille.Children.Add(text1);

            //definition des boutons
            Button nouton1 = new Button();
            Button nouton2 = new Button();
            Button nouton3 = new Button();

            nouton1.Content = "bouton1";
            nouton2.Content = "bouton2";
            nouton3.Content = "bouton3";

            Grid.SetColumn(nouton1,0);
            Grid.SetRow(nouton1, 1);
            Grid.SetColumn(nouton2, 1);
            Grid.SetRow(nouton2, 1);
            Grid.SetColumn(nouton3, 2);
            Grid.SetRow(nouton3, 1);

            grille.Children.Add(nouton1);
            grille.Children.Add(nouton2);
            grille.Children.Add(nouton3);

          

           //definition de la zone de texte
           TextBox textBox1 = new TextBox();

            stack.Children.Add(textBox1);
        }


    }
}
