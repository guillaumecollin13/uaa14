using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_2_POO__EXERCICES_1
{
    internal class Cercle
    {
        private double _rayon;
        public  Cercle(double Rayon)
            {
            _rayon = Rayon;

        }
        public double rayon
		{
			get { return _rayon; }
			set { _rayon = value; }
		}
		public double caclculerAires()
		{
			double resultat;
            resultat = (_rayon*_rayon) * Math.PI;

			return resultat;
		}
        public double caclculerPerimetre()
        {
            double resultat;
            resultat = (2* _rayon) * Math.PI;

            return resultat;
        }
        public string afficheCaracteristique( double Aire, double Perimetre)
        {
         string chaine = "avec un rayon de " + _rayon + " on a un perimetre de " + Perimetre+ " et une aire de "+ Aire;
            return chaine;
        }
    }
}
