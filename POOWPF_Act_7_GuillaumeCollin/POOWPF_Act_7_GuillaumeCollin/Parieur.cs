using System;
using System.Collections.Generic;
using System.Globalization;
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
        TextBlock _textBlockEtatPari;
        public Parieur(string nom, int cash) 
        {
            _nom = nom;
            _cash = cash;
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Pari MonPari
        {
            get { return _monPari; }
            set { _monPari = value; }
        }
        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }
        public TextBlock TextBlockEtatPari
        {
            get { return _textBlockEtatPari; }
            set { _textBlockEtatPari = value; }
        }

        public void Parie(int valeurPari, int numchien)
        {
            _monPari.NumChien = numchien;
            _monPari.Montant = valeurPari;
        }
        public void ResetPari()
        {
            _monPari.NumChien = 0;
            _monPari.Montant = 0;
        }
        public string MajInfos() 
        {
            String info;
            return info = _nom + " possède " + _cash + " écus";
            
        }


    }
}
