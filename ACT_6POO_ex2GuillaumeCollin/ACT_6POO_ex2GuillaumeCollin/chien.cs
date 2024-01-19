using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ACT_6POO_ex2GuillaumeCollin
{
    internal class chien :animaux
    {
        public chien(string name, DateTime birthday, double numPuce, int height, bool concour) : base ( name,  birthday,  numPuce,  height,  concour)
        {

        }
        public string aboyer()
        {
            aboie
        }
    }
}
