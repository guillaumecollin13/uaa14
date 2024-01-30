using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ACT_6POO_ex2GuillaumeCollin
{
    internal class Lapin : Animaux
    {
        int _earHeight;
        public Lapin(string name, DateTime birthday, double numPuce, int height, bool concour, int earHeight) : base(name, birthday, numPuce, height, concour)
        {
            _earHeight = earHeight;
        }

        public string jump()
        {
            string saut;
            return saut=_name+"saute";
        }
        public override string affiche()
        {
            string concour;
            if (_concour)
            {
                concour = "fait des";
            }
            else
            {
                concour = "ne fait pas de ";
            }
            string message;
            message = "nom : " + _name + "\ndate de naissance :" + _birthday + "\nnumero de puce: " + _numPuce + "\n" + concour + "concours"+"\n"+"a des oreille de "+_earHeight+"cm";
            return message;
        }
    }
}
