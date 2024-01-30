using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_POO_Ex_3_GuillaumeCollin
{
    internal class Rectangle : Forme
    {
        int _longeur;
        int _largeur;
        public Rectangle(int longeur, int largeur, string couleur) : base(couleur)
        {
            _longeur = longeur;
            _largeur = largeur; 
        }

        public int Longueur
        {
            get { return _longeur; }
            set { _longeur = value; }
        }
        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }
        public override int calculeSurface()
        {
            int aire;
            return aire = _longeur * Largeur;
        }
        public override int calculePerimetre()
        {
            int perimetre;
            return perimetre = (_longeur+_largeur)*2;
        }
    }
}
