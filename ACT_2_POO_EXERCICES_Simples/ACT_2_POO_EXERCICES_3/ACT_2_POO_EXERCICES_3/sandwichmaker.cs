using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_2_POO_EXERCICES_3
{
    internal class sandwichmaker
    {
        string[] _condiment;
        string[] _protéine;
        string[] _pain;
        string[] _crudites;
  
     public string composesandwich()
        {
            Random alea = new Random();
            int nb;
            _condiment = new string[5] {"mayonaise","ketchup","barbecue","brazil","andalouse"};
            _crudites = new string[5] {"salade","oignons","cornichon","carrote rappées","concombre" };
            _pain = new string[6] { "gris", "demi-gris", "blanc","de campagne","complet","semi-complet" };
            _protéine = new string[7] {"jambon","fromage","salami","jambon italien","boullette","poulet panné","poulet"};

            string sandwich = "pain ";
            nb=alea.Next(0, 5);
            sandwich = sandwich + _pain[nb]+",";
            nb = alea.Next(0, 6);
            sandwich = sandwich + _protéine[nb]+",";
            nb = alea.Next(0, 4);
            sandwich = sandwich + _crudites[nb] + ",";
            nb = alea.Next(0, 4);
            sandwich = sandwich + _condiment[nb] + ".";
            return sandwich;
        }


    }
}
