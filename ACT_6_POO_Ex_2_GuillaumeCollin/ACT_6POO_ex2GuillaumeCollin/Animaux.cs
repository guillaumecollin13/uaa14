using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6POO_ex2GuillaumeCollin
{
    internal class Animaux
    {
        public string _name;
        public DateTime _birthday;
       public double _numPuce;
        public int _height;
        public bool _concour;

        public Animaux(string name, DateTime birthday, double numPuce, int height, bool concour)
        {
            _name = name;
            _birthday = birthday;
            _numPuce = numPuce;
            _height = height;
            _concour = concour;
        }

        public string Name
        {
            get { return _name; }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
        }
        public double NumPuce
        {
            get { return _numPuce; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public bool Concour
        {
            get { return _concour; }
            set { _concour = value; }
        }
        public string eat()
        {
            string eat = _name + "est en train de manger";
            return eat;
        }
        public string sleep()
        {
            string sleep = _name + "est en train de dormir";
            return sleep;
        }
        virtual public string affiche()
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
            message = "nom : " + _name + "\ndate de naissance :" + _birthday + "\nnumero de puce: " +_numPuce+"\n"+concour+"concours";
            return message;
        }
    }
}
