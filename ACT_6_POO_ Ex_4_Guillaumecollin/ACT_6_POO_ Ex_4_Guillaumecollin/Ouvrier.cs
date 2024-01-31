using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_POO__Ex_4_Guillaumecollin
{
    internal class Ouvrier : Employé
    {
        DateTime _bginDay;

        public Ouvrier(DateTime bginDay, int matricule, string nom, string prenom, DateTime birthday) : base (matricule, nom, prenom, birthday)
        {
            _bginDay = bginDay;
        }

        public DateTime BginDay
        {
            get { return _bginDay; }
        }

        public override string Affiche()
        {
            return "matricule : " + _matricule + "\n nom : " + _nom + "\n prenom : " + _prenom + "\n date de naissance : " + _birthday + "\n date d'entrée dans l'entreprise" + _bginDay;
        }
        //public string calcSa()
        //{

       // }
    }
}
