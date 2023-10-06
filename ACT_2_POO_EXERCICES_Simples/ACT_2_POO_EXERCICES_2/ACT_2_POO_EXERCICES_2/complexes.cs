using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_2_POO_EXERCICES_2
{
    internal class complexes
    {
        double _reel;
        double _imagi;
        public complexes(double Reel, double Imagi)
        {
            _reel = Reel;
            _imagi = Imagi;
        }

        public  double Reel
        {
            get { return _reel; }
            set { _reel = value; }
        }
        public double imagi
        {
            get { return _imagi; }
            set { _imagi = value; }
        }

        public double calculModule()
        {
            double calcModule=_reel*_reel+imagi*_imagi;
            calcModule=Math.Sqrt(calcModule);
            return calcModule;
        }
        public void ajoute(complexes nbajouter)
        {
            _reel = _reel + nbajouter.Reel;
            _imagi = _imagi + nbajouter.imagi;
        }

    }
}
