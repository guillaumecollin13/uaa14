using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstClass
{
    class chien
    {
        private string _nom;
        private string _race;
        private uint _age;
        private bool _vacccin;
        private bool _genre;
        private bool _strerelise;
        private bool _dresse;
        private bool _toilette;

         public  chien(string nom, string race,uint age,bool )
        {
            _nom = nom;
            _race = race;
            _age = age;
        }

        public string afficheCaracteristique ()
        {
            string chaine = "nom : " + _nom + " - Age: " + _age + " -race: " +_race;
            return chaine;
        }
    }
}
