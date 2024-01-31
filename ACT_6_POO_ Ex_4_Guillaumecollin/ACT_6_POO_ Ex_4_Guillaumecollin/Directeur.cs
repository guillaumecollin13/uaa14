using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_POO__Ex_4_Guillaumecollin
{
    internal class Directeur : Employé
    {
        public int _chiffAff;
        public int _pourcent;

        public Directeur(int chifAff, int pourcent, int matricule, string nom, string prenom, DateTime birthday) : base (matricule, nom, prenom, birthday)
        {
            _chiffAff = chifAff;
            _pourcent = pourcent;
        }

        public int ChiffAff
        {
            get { return _chiffAff; }
        }
        public int Pourcent
        {
            get { return _pourcent; }
            set { _pourcent = value; }
        }
        public override string Affiche()
        {
            return "matricule : " + _matricule + "\n nom : " + _nom + "\n prenom : " + _prenom + "\n date de naissance : " + _birthday + "\n chiffre d'affaire" + _chiffAff+"\n poucentage : " + _pourcent;
        }

        public string calcSal()
        {
            int salaire;

            salaire = (_chiffAff / 100)*_pourcent;

            return "le salaire est de " + salaire;
        }
    }
}

