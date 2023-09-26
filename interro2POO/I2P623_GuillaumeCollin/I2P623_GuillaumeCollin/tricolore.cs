using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2P623_GuillaumeCollin
{
    internal class Tricolore
    {
        private string _idFeux;
        private int _coulFeu;
        private bool _etatFeux;

        public Tricolore(string IdFeux, int CoulFeu, bool EtatFeux)
        {
            _idFeux = IdFeux;
            _coulFeu = CoulFeu;
            _etatFeux = EtatFeux;
        
        }

        public string OnOffFeu()
        {
            if (_etatFeux)
            {
                return ("allumer");
            }
            else
            {
                return ("eteint");
            }
        }
        public string coulfeu()
        {
            switch (_coulFeu)
            {
                case 1: return "rouge";
                case 2: return "orange";
                case 3: return "vert";
                default: return ("");
            }
        }

        public string IdFeu
        {
            get { return _idFeux; }
        }
        public int CoulFeu
        {
            get { return _coulFeu; }
            set { _coulFeu= value; }
        }
        public bool EtatFeux
        { 
            get { return _etatFeux;} 
            set { _etatFeux= value; }
        }

        public string affinchinfoFeu()
        {
            string Coulfeu =coulfeu();

            
               return ("le feux " + _idFeux + " est " + Coulfeu );
        }
        public string clignoFeu()
        {
            string Etat= OnOffFeu();


            return ("le feux " + _idFeux + " est " + Etat);
        }

    }
    
}
