using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_POO_Ex_3_GuillaumeCollin
{
    internal abstract class Forme
    {
        public string _couleur;

        public Forme(string couleur)
        {
            _couleur = couleur;
        }


        public string Couleur
        {
            get { return _couleur; }
            set {_couleur = value; } 
        }

        public abstract int calculeSurface();
        public abstract int calculePerimetre();
    }
}
