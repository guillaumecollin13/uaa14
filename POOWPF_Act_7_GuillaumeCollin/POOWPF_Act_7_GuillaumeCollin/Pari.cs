using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace POOWPF_Act_7_GuillaumeCollin
{
    class Pari
    {
        int _montant;
        int _numChien;
        Parieur joueur;

            public Pari(int montant, int numChien)
        {
            _montant = montant;
            _numChien = numChien;

        }



        public int Montant
        {
            get { return _montant; }
            set { _montant = value; }
        }
        public int NumChien
        { 
            get { return _numChien;}
            set { _numChien = value; }
        }
        public Parieur Joueur
        { 
            get { return joueur; } 
            set { joueur = value; } 
        }
        public void GetDescription(TextBlock txtInfos)
        {
            //joueur.TextBlockEtatPari.Text = 
        }
        public void PrixFinal(int numGagnant)
        {

        }
    }
}
