using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace ACT_6_WPF_GuillaumeCollin
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

            int m;
            int j;
            ColumnDefinition[] colDef = new ColumnDefinition[8];
            for (int i = 0; i < 8; i++)
            {
                colDef[i] = new ColumnDefinition();
            }
            for (int i = 0; i < 8; i++)
            {
                grille.ColumnDefinitions.Add(colDef[i]);
            }
            RowDefinition[] rowDef = new RowDefinition[8];
            for (int i = 0; i < 8; i++)
            {
                rowDef[i] = new RowDefinition();
            }
            for (int i = 0; i < 8; i++)
            {
                grille.RowDefinitions.Add(rowDef[i]);
            }
            for (int i = 0; i < 8; i++)
            {
                j = 0;
                do
                {
                    TextBlock textBlock = new TextBlock();
                    textBlock.Height = 80;
                    textBlock.Width = 80;

                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            textBlock.Background = Brushes.White;
                        }
                        else
                        {
                            textBlock.Background = Brushes.Black;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            textBlock.Background = Brushes.Black;
                        }
                        else
                        {
                            textBlock.Background = Brushes.White;
                        }
                    }
                    grille.Children.Add(textBlock);
                    Grid.SetColumn(textBlock, j);
                    Grid.SetRow(textBlock, i);
                    m = j;
                    j = j + 1;
                } while (j != 8);

            }


            for (int i = 0; i < 8; i++)
            {
                for (int n = 0; n < 8; n++)
                {
                    Button bouton = new Button();
                    BitmapImage image = new BitmapImage();
                    System.Windows.Controls.Image monImage = new System.Windows.Controls.Image();
                    switch (i)
                    {
                        case 0:
                            if (n == 0 || n == 7)
                            {
                                bouton.Background = Brushes.Transparent;
                                Grid.SetColumn(bouton, n);
                                Grid.SetRow(bouton, i);
                                grille.Children.Add(bouton);

                                image.BeginInit();
                                image.UriSource = new Uri("asset/t.png", UriKind.Relative);
                                image.EndInit();


                                monImage.Source = image;
                                monImage.Stretch = System.Windows.Media.Stretch.None;
                                bouton.Content = monImage;
                            }
                            else if (n == 1 || n == 6)
                            {
                                bouton.Background = Brushes.Transparent;
                                Grid.SetColumn(bouton, n);
                                Grid.SetRow(bouton, i);
                                grille.Children.Add(bouton);

                                image.BeginInit();
                                image.UriSource = new Uri("asset/kn.png", UriKind.Relative);
                                image.EndInit();

                                monImage.Source = image;
                                monImage.Stretch = System.Windows.Media.Stretch.None;
                                bouton.Content = monImage;
                            }
                            else if (n == 2 || n == 5)
                            {
                                bouton.Background = Brushes.Transparent;
                                Grid.SetColumn(bouton, n);
                                Grid.SetRow(bouton, i);
                                grille.Children.Add(bouton);

                                image.BeginInit();
                                image.UriSource = new Uri("asset/b.png", UriKind.Relative);
                                image.EndInit();

                                monImage.Source = image;
                                monImage.Stretch = System.Windows.Media.Stretch.None;
                                bouton.Content = monImage;
                            }
                            else if (n == 3)
                            {
                                bouton.Background = Brushes.Transparent;
                                Grid.SetColumn(bouton, n);
                                Grid.SetRow(bouton, i);
                                grille.Children.Add(bouton);

                                image.BeginInit();
                                image.UriSource = new Uri("asset/k.png", UriKind.Relative);
                                image.EndInit();

                                monImage.Source = image;
                                monImage.Stretch = System.Windows.Media.Stretch.None;
                                bouton.Content = monImage;
                            }
                            else
                            {
                                bouton.Background = Brushes.Transparent;
                                Grid.SetColumn(bouton, n);
                                Grid.SetRow(bouton, i);
                                grille.Children.Add(bouton);

                                image.BeginInit();
                                image.UriSource = new Uri("asset/q.png", UriKind.Relative);
                                image.EndInit();

                                monImage.Source = image;
                                monImage.Stretch = System.Windows.Media.Stretch.None;
                                bouton.Content = monImage;
                            }
                            break;

                        case 1:
                            bouton.Background = Brushes.Transparent;
                            Grid.SetColumn(bouton, n);
                            Grid.SetRow(bouton, i);
                            grille.Children.Add(bouton);


                            image.BeginInit();
                            image.UriSource = new Uri("asset/p.png", UriKind.Relative);
                            image.EndInit();

                            monImage.Source = image;
                            monImage.Stretch = System.Windows.Media.Stretch.None;
                            bouton.Content = monImage;
                            break;

                        case 6:
                            bouton.Background = Brushes.Transparent;
                            Grid.SetColumn(bouton, n);
                            Grid.SetRow(bouton, i);
                            grille.Children.Add(bouton);

                            image.BeginInit();
                            image.UriSource = new Uri("asset/p.png", UriKind.Relative);
                            image.EndInit();


                            monImage.Source = image;
                            monImage.Stretch = System.Windows.Media.Stretch.None;
                            bouton.Content = monImage;
                            break;

                        case 7:
                            if (n == 0 || n == 7)
                            {
                                bouton.Background = Brushes.Transparent;
                                Grid.SetColumn(bouton, n);
                                Grid.SetRow(bouton, i);
                                grille.Children.Add(bouton);

                                image.BeginInit();
                                image.UriSource = new Uri("asset/t.png", UriKind.Relative);
                                image.EndInit();


                                monImage.Source = image;
                                monImage.Stretch = System.Windows.Media.Stretch.None;
                                bouton.Content = monImage;
                            }
                            else if (n == 1 || n == 6)
                            {
                                bouton.Background = Brushes.Transparent;
                                Grid.SetColumn(bouton, n);
                                Grid.SetRow(bouton, i);
                                grille.Children.Add(bouton);

                                image.BeginInit();
                                image.UriSource = new Uri("asset/kn.png", UriKind.Relative);
                                image.EndInit();

                                monImage.Source = image;
                                monImage.Stretch = System.Windows.Media.Stretch.None;
                                bouton.Content = monImage;
                            }
                            else if (n == 2 || n == 5)
                            {
                                bouton.Background = Brushes.Transparent;
                                Grid.SetColumn(bouton, n);
                                Grid.SetRow(bouton, i);
                                grille.Children.Add(bouton);

                                image.BeginInit();
                                image.UriSource = new Uri("asset/b.png", UriKind.Relative);
                                image.EndInit();

                                monImage.Source = image;
                                monImage.Stretch = System.Windows.Media.Stretch.None;
                                bouton.Content = monImage;
                            }
                            else if (n == 3)
                            {
                                bouton.Background = Brushes.Transparent;
                                Grid.SetColumn(bouton, n);
                                Grid.SetRow(bouton, i);
                                grille.Children.Add(bouton);

                                image.BeginInit();
                                image.UriSource = new Uri("asset/k.png", UriKind.Relative);
                                image.EndInit();

                                monImage.Source = image;
                                monImage.Stretch = System.Windows.Media.Stretch.None;
                                bouton.Content = monImage;
                            }
                            else
                            {
                                bouton.Background = Brushes.Transparent;
                                Grid.SetColumn(bouton, n);
                                Grid.SetRow(bouton, i);
                                grille.Children.Add(bouton);

                                image.BeginInit();
                                image.UriSource = new Uri("asset/q.png", UriKind.Relative);
                                image.EndInit();

                                monImage.Source = image;
                                monImage.Stretch = System.Windows.Media.Stretch.None;
                                bouton.Content = monImage;
                            }
                            break;

                        default:

                            break;
                    }


                }
            }

        }
    }
}