﻿using System;
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

namespace POOWPF_Act_7_GuillaumeCollin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Parieur Bill = new Parieur("Bill", 50);
            Parieur Luc = new Parieur("Luc", 50);
            Parieur Jacque = new Parieur("Jacque", 50);
            InitializeComponent();
            radiobutton1.Content = Bill.MajInfos();
            radiobutton2.Content = Luc.MajInfos();
            radiobutton3.Content = Jacque.MajInfos();

        }
    }
}
