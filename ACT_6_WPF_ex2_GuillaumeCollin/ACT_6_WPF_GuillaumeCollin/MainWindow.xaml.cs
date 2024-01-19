using System;
using System.Collections;
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
            
            int k=0;
            int l;
            int m;
            int j;
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
            for (int i = 0; i < 10; i++)
            {
                if (i%2==0)
                {
                    j = 0;
                    do
                    {
                        TextBlock textBlock = new TextBlock();
                        l = j + k + 1;
                        textBlock.Text = l.ToString();
                        textBlock.Height = 65;
                        textBlock.Width = 65;
                        textBlock.TextAlignment = TextAlignment.Center;
                        textBlock.FontWeight = FontWeights.Heavy;
                        textBlock.VerticalAlignment = VerticalAlignment.Center;
                        textBlock.Foreground = Brushes.Red;
                        textBlock.FontSize = 25;

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
                    } while (j != 10);
                    k = m + k + 1;
                }
                else
                {
                    j = 9;
                    do
                    {
                        TextBlock textBlock = new TextBlock();
                        l = 10+k-j;
                        textBlock.Text = l.ToString();
                        textBlock.Height = 65;
                        textBlock.Width = 65;
                        textBlock.TextAlignment = TextAlignment.Center;
                        textBlock.FontWeight = FontWeights.Heavy;
                        textBlock.VerticalAlignment = VerticalAlignment.Center;
                        textBlock.Foreground = Brushes.Red;
                        textBlock.FontSize = 25;

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
                        j = j - 1;
                    } while (j != -1);
                    
                    k = k+10;
                }
            }
        }
    }
}
