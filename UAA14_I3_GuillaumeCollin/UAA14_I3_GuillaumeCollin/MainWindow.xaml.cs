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
        bool test;
        public MainWindow()
        {
            InitializeComponent();
            txt1.PreviewTextInput+= new TextCompositionEventHandler(verifdonnée);
            txt2.PreviewTextInput += new TextCompositionEventHandler(verifdonnée);
            noutcalc.clik += new RoutedEventHandler(calculer);
        }
        private void verifdonnée(object senders, TextCompositionEventArgs e)
        {
            int truc = e.Text.Length;
            if(e.Text!= "1" && e.Text!="0")
            {
                e.Handled = true;

            }
            else if(truc<7){
                test = true;
                if (test)
                {
                    string message = "c'est bon";
                    Window1 solution = new Window1();
                solution.txt1.Text = message;
                solution.Show();
                }
                else
                {
                    string message = "c'est pas bon";
                    Window1 solution = new Window1();
                    solution.txt1.Text = message;
                    solution.Show();
                }
            }
        }

    }

}
