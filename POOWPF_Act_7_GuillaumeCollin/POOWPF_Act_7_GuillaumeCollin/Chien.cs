using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace POOWPF_Act_7_GuillaumeCollin
{
    class Chien
    {
        int _longeurPiste;
        int _numDog;
        Image _imgDog;
        bool _win;
        int[] _positionCourante;
        public Chien(int longueurPiste, int numdog, Image imgDog, bool win)
        {
            _longeurPiste = longueurPiste;
            _numDog = numdog;   
            _imgDog = imgDog;
            _positionCourante = new int[2];
            _win = win;
        }

        public int LongueurPiste 
        {
            get { return _longeurPiste;}
            set { _longeurPiste= value; }
        }
        public int NumDog
        {
            get { return _numDog;}
            set { _numDog = value; }
        }

        public Image ImgDog 
        { 
            get { return _imgDog; } 
            set { _imgDog= value; } 
        }
        public int[] PositionCourante
        {
           get { return _positionCourante; }
           set { _positionCourante= value; }
        }
        public bool Win
        {
            get { return _win; }
            set { _win = value; }
        }

       public void court()
       {

       }
    }
}
