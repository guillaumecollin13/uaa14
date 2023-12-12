using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeUAA14Partie2_dec23_Guillaume_Collin
{
    internal class paintballGuns
    {
        private int _nbBullPlayer;
        private int _nbBullMagazine;
        private bool _magazineIsVoid;
        private bool _playerIsVoid;

        public paintballGuns()
        {
            _nbBullPlayer = 30;
            _nbBullMagazine = 16;
            _magazineIsVoid =false;
            _playerIsVoid=false;
        }
        public int _NbBullPlayer
        {
            get { return _nbBullPlayer; }
            set { _nbBullPlayer = value; }
        }

        public int _NbBullMagazine
        {
            get { return _nbBullMagazine; }
            set { _nbBullMagazine = value; }
        }

        public bool _MagazineIsVoid
        {
            get { return _magazineIsVoid; }
            set { _magazineIsVoid = value; }
        }

        public bool _NbBull_playerIsVoidMagazine
        {
            get { return _playerIsVoid; }
            set { _playerIsVoid = value; }
        }

        public void verifIsVoid()
        {
            if (_nbBullPlayer == 0)
            {
                _playerIsVoid = true;
            }
            else 
            {
                _playerIsVoid = false;
            }
            if (_nbBullMagazine == 0)
            {
                _magazineIsVoid = true;
            }
            else
            {
                _magazineIsVoid = false;
            }

        }
        public void relaunchPlayer()
        {
                _nbBullPlayer = _nbBullPlayer + 30;
        }
        public void relaunchMagazine()
        {
            if (!_playerIsVoid)
            {
                Console.WriteLine("rechargement en cours");
                if (_magazineIsVoid && _nbBullPlayer > 17)
                {
                    _nbBullMagazine = 16;
                    _nbBullPlayer = _nbBullPlayer - 16;

                }
                else if (_nbBullMagazine != 16)
                {
                    do
                    {
                        _nbBullMagazine++;
                        _nbBullPlayer--;
                    } while (_nbBullMagazine < 16 && _nbBullPlayer != 0);
                }
                Console.WriteLine("rechargement effectuer");
            }
            else
            {
                Console.WriteLine("vous n'avez plus de munition sur vous veuillez allez en rechercher");
            }
        }
        public void shoot()
        {
            if (!_magazineIsVoid) 
            {
                _nbBullMagazine--;

            }
            else
            {
                Console.WriteLine("plus de munitions vous devez recharger");
            }
        }
        public string concatenNbBUllets()
        {
            return "il reste " + _nbBullMagazine + " balle dans votre chargeur et " + _nbBullPlayer + " dans votre poche";
        }
    }
}
