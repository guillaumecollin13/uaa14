using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACT_6_POO_Ex_1_GuillaumeCollin
{
    internal class Voiture : veichule
    {
        private string _motorisation;
        private bool _gps;
        public Voiture(string motorisation, bool gps, string marque, string modele, string couleur, decimal prix) : base(marque, modele, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }
        public override string affiche()
        {

            string Gps;
            if (_gps)
            {
                 Gps = "avec";
            }
            else
            {
                 Gps = "sans";
            }
            return "c'est un/e " + _modele + " " + _marque + " " + _couleur + " " + _motorisation + " " + Gps + " GPS" + " pour " + _prix+"€";
        }
    }
}
