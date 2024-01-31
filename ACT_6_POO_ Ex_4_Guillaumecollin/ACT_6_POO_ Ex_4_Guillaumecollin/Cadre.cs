using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_POO__Ex_4_Guillaumecollin
{
    internal class Cadre : Employé
    {
        public int _id;
        public Cadre(int id, int matricule, string nom, string prenom, DateTime birthday) : base(matricule, nom, prenom, birthday)
        {
            _id = id;
        }

        public int Id
        {
            get { return _id; }
        }

        public override string Affiche()
        {
            return "indice :"+_id+"\n matricule : " + _matricule + "\n nom : " + _nom + "\n prenom : " + _prenom + "\n date de naissance : " + _birthday;
        }
        public string CalcSal()
        {
            string salaire="";
            switch (_id)
            {
                case 1: salaire = "13000 écus";
                    break;
                case 2:salaire = "15000 ecus";
                    break;
                case 3:salaire = "17000 ecus";
                    break;
                case 4:salaire = "20000 ecus";
                    break;
                default:
                    break;
            }
            return "le salaire est de " + salaire;
        }
    }
}
