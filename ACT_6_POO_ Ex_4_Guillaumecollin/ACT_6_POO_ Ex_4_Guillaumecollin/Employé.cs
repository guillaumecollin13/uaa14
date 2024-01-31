using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_POO__Ex_4_Guillaumecollin
{
    internal abstract class Employé
    {
        public int _matricule;
        public string _nom;
        public string _prenom;
        public DateTime _birthday;

        public Employé(int matricule, string nom, string prenom, DateTime birthday) 
        {
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _birthday = birthday;
        }


        public int Matricule
        {
            get { return _matricule; }
        }
        public string Nom
        {
            get { return _nom; }
        }
        public string Prenom
        {
            get { return _prenom; }
        }
        public DateTime Birthday
        {
            get { return _birthday; }
        }

        public virtual string Affiche()
        {
            return "matricule : " + _matricule + "\n nom : " + _nom + "\n prenom : " + _prenom + "\n date de naissance : " + _birthday;
        }

    }
}
