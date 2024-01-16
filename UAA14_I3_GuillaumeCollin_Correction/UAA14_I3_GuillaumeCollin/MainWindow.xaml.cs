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

namespace UAA14_I3_GuillaumeCollin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MethodesDuProjet methode = new MethodesDuProjet();
        public MainWindow()
        {
            InitializeComponent();
            txt1.PreviewTextInput += new TextCompositionEventHandler(verifdonnée);
            txt2.PreviewTextInput += new TextCompositionEventHandler(verifdonnée);
            noutcalc.Click += new RoutedEventHandler(calcule);
            noutres.Click += new RoutedEventHandler(reset);


        }
        private void verifdonnée(object senders, TextCompositionEventArgs e)
        {
            if (e.Text =="1" || e.Text=="0" )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void calcule(object senders, RoutedEventArgs e)
        {

            if (txt1.Text != "" && txt2.Text != "" && txt1.Text.Length < 8 && txt2.Text.Length < 8)
            {
                ushort[] TBN1;
                ushort[] TBN2;
                MethodesDuProjet mesoutils = new MethodesDuProjet();
                if (Convert.ToInt32(txt2.Text.ToString()) < Convert.ToInt32(txt1.Text.ToString()))
                {
                    TBN1 = new ushort[txt1.Text.Length];
                    TBN1 = mesoutils.RemplirTableau(txt1.Text);
                    TBN2 = new ushort[txt2.Text.Length];
                    TBN2 = mesoutils.RemplirTableau(txt2.Text);
                }
                else
                {

                    TBN1 = new ushort[txt2.Text.Length];
                    TBN1 = mesoutils.RemplirTableau(txt1.Text);
                    TBN2 = new ushort[txt1.Text.Length];
                    TBN2 = mesoutils.RemplirTableau(txt2.Text);
                }
                if (add.IsChecked == true)
                {
                    ushort[] tRes;
                    bool ok;
                    mesoutils.Additionne(TBN1 , TBN2,out tRes,out ok);
                    if (ok) 
                    {
                        texte.Text=mesoutils.Concatene(tRes);
                    }
                    else
                    {
                        texte.Text = "Dépassement de capacité !";
                    }
                }
               else if (sous.IsChecked == true)
                {
                    ushort[] tRes;
                    if (mesoutils.Soustrait(TBN1, TBN2, out tRes))
                    {
                        texte.Text = mesoutils.Concatene(tRes);
                    }
                    else
                    {
                        texte.Text = "Dépassement de capacité !";
                    }
                }

            }
            else
            {
                MessageBox.Show("Veuillez encoder deux nombres binaires d'au plus 7 bits.");
            }
        }
        private void reset(object sender, RoutedEventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            texte.Text = "";

        }
    }
}
