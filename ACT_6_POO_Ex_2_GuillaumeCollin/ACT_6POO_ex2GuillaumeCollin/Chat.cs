using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6POO_ex2GuillaumeCollin
{
    internal class Chat : Animaux
    {
        public Chat(string name, DateTime birthday, double numPuce, int height, bool concour) : base(name, birthday, numPuce, height, concour)
        {

        }
        public string miauler()
        {
            string miaule;
            return miaule = _name+": *miaou*miaou";
        }
    }
}
