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

         public chien(string nom, string race, uint age, bool vaccin , bool genre , bool strerelise, bool dresse, bool toilette)
        {
            _nom = nom;
            _race = race;
            _age = age;
            _vacccin = vaccin;
            _genre = genre;
            _strerelise=strerelise;
            _dresse=dresse;
            _toilette=toilette;

        }

        public uint Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool Vaccin
        {
            get { return _vacccin; }
            set { _vacccin = value; }
        }

        public bool Genre
        {
            
            get { return _genre; }
            set { _genre = value; }
        }
        public bool Sterelise
        {
            get { return _strerelise; }
            set { _strerelise = value; }
        }
        public bool Dresse
        {
            get { return _dresse; }
            set { _dresse = value; }
        }
        public bool Toilette
        {
            get { return _toilette; }
            set { _toilette = value; }
        }



        public string afficheCaracteristique ()
        {
            string Vacc;
            if (_vacccin){ Vacc = "vacciné";}else{Vacc = "non vacciné";}
            string gen;
            if (_genre){ gen = "male"; }else{gen = "femelle";}
            string ster;
            if (_strerelise){ ster = "sterelisé"; }else{ ster = "non sterelisé"; }
            string dress;
            if (_dresse) { dress = "dresse"; } else { dress = "non dresse"; }
            string toil;
            if (_toilette) { toil = "toiletté"; } else { toil = "non toiletté"; }

            string chaine = "nom : " + _nom + " - Age: " + _age + " -race: " +_race +" -vaccin: " + Vacc +" -sexe " +gen +"-sterilisation " 
                +ster +" -dressage " + dress + " -toilletage "+toil ;
            return chaine;
        }
    }
}
