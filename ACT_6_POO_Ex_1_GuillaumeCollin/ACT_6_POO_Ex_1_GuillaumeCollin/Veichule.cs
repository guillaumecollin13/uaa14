using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_6_POO_Ex_1_GuillaumeCollin 
{ 
     public  class veichule
    {
        protected string _modele;
        protected string _marque;
        protected string _couleur;
        protected decimal _prix;

        public veichule (string modele, string marque, string couleur, decimal prix)
        {
            _modele = marque;
            _marque = modele;
            _couleur = couleur;
            _prix = prix;
        }

        public virtual string affiche()
        {
            string reponse = "c'est un/e "+_modele + _marque + _couleur +" pour "+ _prix + "€";
            return reponse;
        }
    }
}
