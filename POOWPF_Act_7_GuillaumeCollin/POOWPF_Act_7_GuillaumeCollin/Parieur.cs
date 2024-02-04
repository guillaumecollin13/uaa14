using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace POOWPF_Act_7_GuillaumeCollin
{
    class Parieur
    {
        string _nom;
        Pari _monPari;
        int _cash;
        TextBlock textBlockEtatPari;
        public Parieur(string nom, int cash) 
        {
            _nom = nom;
            _cash = cash;
        }


    }
}
