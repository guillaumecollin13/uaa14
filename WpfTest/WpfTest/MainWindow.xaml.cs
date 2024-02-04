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

namespace WpfTest
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

        public void agencement()
        {
            ColumnDefinition[] colDef = new ColumnDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                colDef[i] = new ColumnDefinition();
            }
            for (int i = 0; i < 10; i++)
            {
                grille.ColumnDefinitions.Add(colDef[i]);
            }
            RowDefinition[] rowDef = new RowDefinition[10];
            for (int i = 0; i < 10; i++)
            {
                rowDef[i] = new RowDefinition();
            }
            for (int i = 0; i < 10; i++)
            {
                grille.RowDefinitions.Add(rowDef[i]);
            }
            Button bouton = new Button();
            Grid.SetColumn(bouton, 0);
            Grid.SetRow(bouton, 0);
            grille.Children.Add(bouton);

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("assets/portalAlertParadox.png", UriKind.Relative);
            image.EndInit();

            Image monImage = new Image();
            monImage.Source = image;
            monImage.Stretch = System.Windows.Media.Stretch.None;
            bouton.Content= monImage;

            radio.Content = "va te faire";
            Grid.SetColumn(radio, 1);
            Grid.SetRow(radio, 1);
            grille.Add(radio);
            

        }
    }
}
