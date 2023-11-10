using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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


namespace ACT_3_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string message;
        double a, b, c;
        public MainWindow()
        {
            InitializeComponent();
            TxtA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtA.PreviewTextInput += new TextCompositionEventHandler(RecupA);
            TxtB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtB.PreviewTextInput += new TextCompositionEventHandler(RecupB);
            TxtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtC.PreviewTextInput += new TextCompositionEventHandler(RecupC);
            BtnCalculer.MouseEnter += new MouseEventHandler(SurvolBouton);
            BtnCalculer.Click += new RoutedEventHandler(calculetri);
            
        }
        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && !EstEntier(e.Text))
            {
                 e.Handled = true;
            }
            else if(e.Text == ",") 
            {
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }
            }
        }
        private bool EstEntier(string texteUser)
        {
            int a;
            return int.TryParse(texteUser, out a);
        }
        private void SurvolBouton(object sender, EventArgs e)
        {
            BtnV.Background = Brushes.Red;
            BtnV.Visibility = Visibility.Visible;
           
        }

        private void calculetri(object sender, RoutedEventArgs e)
        {
            mesOutils outils = new mesOutils();
            outils.effectTrin(a,b,c, out message);
            Window1 solution = new Window1();
            solution.txt1.Text = message;
            solution.Show();
        }
        private void RecupA(object sender, TextCompositionEventArgs e)
        {
            a =double.Parse(e.Text);
        }
        private void RecupB(object sender, TextCompositionEventArgs e)
        {
            b = double.Parse(e.Text);
        }
        private void RecupC(object sender, TextCompositionEventArgs e)
        {
            c = double.Parse(e.Text);
        }
    }
}
