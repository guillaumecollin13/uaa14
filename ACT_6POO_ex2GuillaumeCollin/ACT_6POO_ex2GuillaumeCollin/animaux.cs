using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6POO_ex2GuillaumeCollin
{
    internal class animaux
    {
        string _name;
        DateTime _birthday;
        double _numPuce;
        int _height;
        bool _concour;

        public animaux(string name, DateTime birthday, double numPuce, int height, bool concour)
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
        public string affiche()
        {
            string concour;
            if (_concour) 
            {
                concour = "fait des";
            }
            else
            {
                concour = "ne fait pas de";
            }
            string message;
            message = "nom : " + _name + "\bdate de naissance :" + _birthday + "\b numero de puce" +_numPuce+"\b"+concour+"concours";
            return message;
        }
    }
}
