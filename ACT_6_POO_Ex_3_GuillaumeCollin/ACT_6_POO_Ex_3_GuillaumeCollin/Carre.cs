using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_POO_Ex_3_GuillaumeCollin
{
    internal class Carre : Forme
    {
        int _cote;

        public Carre(int cote, string couleur) : base(couleur)
        {
            _cote = cote;
        }

        public int Cote
        {
            get { return _cote; }
            set { _cote = value; }
        }
        public override int calculeSurface()
        {
            int aire;
            return aire = _cote * _cote;
        }
        public override int calculePerimetre()
        {
            int perimetre;
            return perimetre = 4 *_cote;
        }
    }
}
