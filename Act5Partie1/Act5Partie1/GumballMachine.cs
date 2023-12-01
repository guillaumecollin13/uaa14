using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GumballMachine
{
    private int _gumballs;
    private int _price;
    public GumballMachine(int gumballs, int price)
    {
        _gumballs = gumballs;
        _price = price;
    }

    public int _Price
    {
        get { return _price; }
    }

    public int _Gumballs
    {
        get { return _gumballs; }
    }


    public string DispenseOneGumball( int coinsInserted)
    {
        if (coinsInserted >= _price)
        {
            _gumballs -= 1;
            return "Voici votre gomme !";
        }
        else
        {
            return "Pas assez de pièces !";
        }
    }
}

