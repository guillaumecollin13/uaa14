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
using Image = System.Windows.Controls.Image;


namespace CE_UAA14WPF24_GuillaumeCollin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid grille2;
        public MainWindow()
        {
            InitializeComponent();
            grille2 = new Grid();
            Grid.SetColumn(grille2, 0);
            Grid.SetRow(grille2, 1);
            grille2.Margin = new Thickness(20);
            grille.Children.Add(grille2);
            Solitaire.Checked += Solitaire_Checked;
            marelle.Checked += new RoutedEventHandler(Marelle_Checked);
            forCreuCar.Checked += new RoutedEventHandler(ForCreuCar_Checked);
            btnres.Click += new RoutedEventHandler(reset);


        }


        private void Marelle_Checked(object sender, RoutedEventArgs e)
        {

            lignes.Text = "7";
            Colonnes.Text = "7";
            grille2.ColumnDefinitions.Clear();
            grille2.RowDefinitions.Clear();
            grille2.Children.Clear();
            ColumnDefinition[] colonne = new ColumnDefinition[7];
            RowDefinition[] row = new RowDefinition[7];
            for (int i = 0; i < 7; i++)
            {
                colonne[i] = new ColumnDefinition();
                grille2.ColumnDefinitions.Add(colonne[i]);
                row[i] = new RowDefinition();
                grille2.RowDefinitions.Add(row[i]);
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 || i == 6)
                    {
                        if (j == 0 || j == 3 || j == 6)
                        {
                            Button btn = new Button();
                            btn.Height = this.Height;
                            btn.Width = this.Width;
                            btn.Background = Brushes.Khaki;

                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("assets/petitCercleRouge.png", UriKind.Relative);
                            imageBouton.EndInit();

                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;
                            imBouton.Height = 50;
                            imBouton.Width = 50;

                            btn.Content = imBouton;

                            Grid.SetColumn(btn, j);
                            Grid.SetRow(btn, i);
                            grille2.Children.Add(btn);

                            btn.Click += new RoutedEventHandler(btn_click);
                            void btn_click(object sender, RoutedEventArgs e)
                            {
                                BitmapImage imageBouton = new BitmapImage();
                                imageBouton.BeginInit();
                                imageBouton.UriSource = new Uri("assets/volvik.png", UriKind.Relative);
                                imageBouton.EndInit();

                                Image imBouton = new Image();
                                imBouton.Source = imageBouton;
                                imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                                btn.Content = imBouton;
                                btn.Background = Brushes.Red;
                            }
                        }
                    }
                    else if (i == 1 || i == 5)
                    {
                        if (j == 1 || j == 3 || j == 5)
                        {
                            Button btn = new Button();
                            btn.Height = this.Height;
                            btn.Width = this.Width;
                            btn.Background = Brushes.Khaki;

                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("assets/petitCercleRouge.png", UriKind.Relative);
                            imageBouton.EndInit();

                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;
                            imBouton.Height = 50;
                            imBouton.Width = 50;

                            btn.Content = imBouton;

                            Grid.SetColumn(btn, j);
                            Grid.SetRow(btn, i);
                            grille2.Children.Add(btn);


                            btn.Click += new RoutedEventHandler(btn_click);
                            void btn_click(object sender, RoutedEventArgs e)
                            {
                                BitmapImage imageBouton = new BitmapImage();
                                imageBouton.BeginInit();
                                imageBouton.UriSource = new Uri("assets/volvik.png", UriKind.Relative);
                                imageBouton.EndInit();

                                Image imBouton = new Image();
                                imBouton.Source = imageBouton;
                                imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                                btn.Content = imBouton;
                                btn.Background = Brushes.Red;
                            }
                        }
                    }
                    else if (i == 2 || i == 4)
                    {
                        if (j == 2 || j == 3 || j == 4)
                        {
                            Button btn = new Button();
                            btn.Height = this.Height;
                            btn.Width = this.Width;
                            btn.Background = Brushes.Khaki;

                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("assets/petitCercleRouge.png", UriKind.Relative);
                            imageBouton.EndInit();

                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;
                            imBouton.Height = 50;
                            imBouton.Width = 50;

                            btn.Content = imBouton;

                            Grid.SetColumn(btn, j);
                            Grid.SetRow(btn, i);
                            grille2.Children.Add(btn);


                            btn.Click += new RoutedEventHandler(btn_click);
                            void btn_click(object sender, RoutedEventArgs e)
                            {
                                BitmapImage imageBouton = new BitmapImage();
                                imageBouton.BeginInit();
                                imageBouton.UriSource = new Uri("assets/volvik.png", UriKind.Relative);
                                imageBouton.EndInit();

                                Image imBouton = new Image();
                                imBouton.Source = imageBouton;
                                imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                                btn.Content = imBouton;
                                btn.Background = Brushes.Red;
                            }
                        }
                    }
                    else if (i == 3)
                    {
                        if (j != 3)
                        {
                            Button btn = new Button();
                            btn.Height = this.Height;
                            btn.Width = this.Width;
                            btn.Background = Brushes.Khaki;

                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("assets/petitCercleRouge.png", UriKind.Relative);
                            imageBouton.EndInit();

                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;
                            imBouton.Height = 50;
                            imBouton.Width = 50;

                            btn.Content = imBouton;

                            Grid.SetColumn(btn, j);
                            Grid.SetRow(btn, i);
                            grille2.Children.Add(btn);

                            btn.Click += new RoutedEventHandler(btn_click);
                            void btn_click(object sender, RoutedEventArgs e)
                            {
                                BitmapImage imageBouton = new BitmapImage();
                                imageBouton.BeginInit();
                                imageBouton.UriSource = new Uri("assets/volvik.png", UriKind.Relative);
                                imageBouton.EndInit();

                                Image imBouton = new Image();
                                imBouton.Source = imageBouton;
                                imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                                btn.Content = imBouton;
                                btn.Background = Brushes.Red;
                            }
                        }
                    }
                }

            }
        }

        private void Solitaire_Checked(object sender, RoutedEventArgs e)
        {
            lignes.Text = "9";
            Colonnes.Text = "9";
            grille2.ColumnDefinitions.Clear();
            grille2.RowDefinitions.Clear();
            grille2.Children.Clear();

            ColumnDefinition[] colonne = new ColumnDefinition[9];
            RowDefinition[] row = new RowDefinition[9];
            for (int i = 0; i < 9; i++)
            {
                colonne[i] = new ColumnDefinition();
                grille2.ColumnDefinitions.Add(colonne[i]);
                row[i] = new RowDefinition();
                grille2.RowDefinitions.Add(row[i]);
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == 0 || i == 1 || i == 2 || i == 6 || i == 7 || i == 8)
                    {
                        if (j == 3 || j == 4 || j == 5)
                        {
                            Button btn = new Button();
                            btn.Height = this.Height;
                            btn.Width = this.Width;
                            btn.Background = Brushes.Khaki;

                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("assets/petitCercleRouge.png", UriKind.Relative);
                            imageBouton.EndInit();

                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;
                            imBouton.Height = 50;
                            imBouton.Width = 50;

                            btn.Content = imBouton;

                            Grid.SetColumn(btn, j);
                            Grid.SetRow(btn, i);
                            grille2.Children.Add(btn);

                            btn.Click += new RoutedEventHandler(btn_click);
                            void btn_click(object sender, RoutedEventArgs e)
                            {
                                BitmapImage imageBouton = new BitmapImage();
                                imageBouton.BeginInit();
                                imageBouton.UriSource = new Uri("assets/volvik.png", UriKind.Relative);
                                imageBouton.EndInit();

                                Image imBouton = new Image();
                                imBouton.Source = imageBouton;
                                imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                                btn.Content = imBouton;
                                btn.Background = Brushes.Red;
                            }
                        }
                    }
                    else if (i == 3 || i == 4 || i == 5)
                    {
                        Button btn = new Button();
                        btn.Height = this.Height;
                        btn.Width = this.Width;
                        btn.Background = Brushes.Khaki;

                        BitmapImage imageBouton = new BitmapImage();
                        imageBouton.BeginInit();
                        imageBouton.UriSource = new Uri("assets/petitCercleRouge.png", UriKind.Relative);
                        imageBouton.EndInit();

                        Image imBouton = new Image();
                        imBouton.Source = imageBouton;
                        imBouton.Stretch = System.Windows.Media.Stretch.Fill;
                        imBouton.Height = 50;
                        imBouton.Width = 50;

                        btn.Content = imBouton;

                        Grid.SetColumn(btn, j);
                        Grid.SetRow(btn, i);
                        grille2.Children.Add(btn);

                        btn.Click += new RoutedEventHandler(btn_click);
                        void btn_click(object sender, RoutedEventArgs e)
                        {
                            BitmapImage imageBouton = new BitmapImage();
                            imageBouton.BeginInit();
                            imageBouton.UriSource = new Uri("assets/volvik.png", UriKind.Relative);
                            imageBouton.EndInit();

                            Image imBouton = new Image();
                            imBouton.Source = imageBouton;
                            imBouton.Stretch = System.Windows.Media.Stretch.Fill;

                            btn.Content = imBouton;
                            btn.Background = Brushes.Red;
                        }
                    }
                }
            }
        }
        private void ForCreuCar_Checked(object sender, RoutedEventArgs e)
        {
            //int lig = int.Parse(lignes.Text);
            //int col = int.Parse(Colonnes.Text);
            this.lignes.TextInput += Lignes_TextInput1;
            this.Colonnes.TextInput += Colonnes_TextInput1; ;
            btnVal.Click += new RoutedEventHandler(BtnVal_click);
        }

        private void Colonnes_TextInput1(object sender, TextCompositionEventArgs e)
        {
            MessageBox.Show("passé");
            if (e.Text == "1" || e.Text == "2" || e.Text == "3" || e.Text == "4" || e.Text == "5" || e.Text == "6" || e.Text == "7" || e.Text == "8" || e.Text == "9")
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
        }


        private void Lignes_TextInput1(object sender, TextCompositionEventArgs e)
        {
            MessageBox.Show("passé");
            if (e.Text == "1" || e.Text == "2" || e.Text == "3" || e.Text == "4" || e.Text == "5" || e.Text == "6" || e.Text == "7" || e.Text == "8" || e.Text == "9")
            {

                e.Handled = true;
            }
            else { e.Handled = false; }
        }

        private void BtnVal_click(object sender, RoutedEventArgs e)
        {
            grille2.ColumnDefinitions.Clear();
            grille2.RowDefinitions.Clear();
            grille2.Children.Clear();
            int col = int.Parse(Colonnes.Text);
            int lig = int.Parse(lignes.Text);
            //if (col > 12 || col < 12)
            //{
              //  txtBot.Text = "erreur entrez des valeur exact";
            //}
            //else if (lig > 12 || lig < 12)
            //{

//                txtBot.Text = "erreur entrez des valeur exact";
  //          }
    //        else
     //       {
                ColumnDefinition[] colonne = new ColumnDefinition[col];
                RowDefinition[] row = new RowDefinition[lig];
                for (int i = 0; i < col; i++)
                {
                    colonne[i] = new ColumnDefinition();
                    grille2.ColumnDefinitions.Add(colonne[i]);

                    row[i] = new RowDefinition();
                    grille2.RowDefinitions.Add(row[i]);
                }

                for (int i = 0; i < lig; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (i == 0)
                        {
                            Button btn1 = new Button();
                            btn1.Height = this.Height;
                            btn1.Width = this.Width;
                            btn1.Background = Brushes.Khaki;
                            btn1.Content = "X";

                            Grid.SetColumn(btn1, j);
                            Grid.SetRow(btn1, i);
                            grille2.Children.Add(btn1);
                        }
                        else if (j == 0)
                        {
                            Button btn1 = new Button();
                            btn1.Height = this.Height;
                            btn1.Width = this.Width;
                            btn1.Background = Brushes.Khaki;
                            btn1.Content = "X";

                            Grid.SetColumn(btn1, j);
                            Grid.SetRow(btn1, i);
                            grille2.Children.Add(btn1);
                        }
                        else if (i == 11)
                        {
                            Button btn1 = new Button();
                            btn1.Height = this.Height;
                            btn1.Width = this.Width;
                            btn1.Background = Brushes.Khaki;
                            btn1.Content = "X";

                            Grid.SetColumn(btn1, j);
                            Grid.SetRow(btn1, i);
                            grille2.Children.Add(btn1);
                        }
                        else if (j == 11)
                        {
                            Button btn1 = new Button();
                            btn1.Height = this.Height;
                            btn1.Width = this.Width;
                            btn1.Background = Brushes.Khaki;
                            btn1.Content = "X";

                            Grid.SetColumn(btn1, j);
                            Grid.SetRow(btn1, i);
                            grille2.Children.Add(btn1);
                        }

                    }
                }
           // }
        }
        private void reset(object senders, RoutedEventArgs e)
        {
            grille2.ColumnDefinitions.Clear();
            grille2.RowDefinitions.Clear();
            grille2.Children.Clear();
        }
    }
}


