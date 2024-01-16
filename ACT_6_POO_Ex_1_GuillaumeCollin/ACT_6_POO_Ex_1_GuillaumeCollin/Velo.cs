using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_POO_Ex_1_GuillaumeCollin
{
    internal class Velo : veichule
    {
        private string _type;
        private bool _electrique;

        public Velo(string type, bool electrique, string marque, string modele, string couleur, decimal prix) : base(marque, modele, couleur, prix)
        {
            _type = type;
            _electrique = electrique;
        }
        public override string affiche()
        {

            string electrique;
            if (_electrique)
            {
                electrique= "electrique";
            }
            else
            {
                electrique = "non electrique";
            }
            return "c'est un "+_type +" "+ _modele + " " + _marque + " " + _couleur + " " + electrique+ " pour " + _prix + "€";
        }
    }
}
