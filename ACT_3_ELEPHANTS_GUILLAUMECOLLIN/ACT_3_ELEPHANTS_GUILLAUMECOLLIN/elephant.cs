using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_3_ELEPHANTS_GUILLAUMECOLLIN
{
    internal class elephant
    {
        string _nom;
        uint _taillesOreilles;
        public elephant(string nom, uint TailleOreilles) 
        {
            _nom = nom;
            _taillesOreilles = TailleOreilles;
        }

        public string _Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public uint _TaillesOreilles
        {
            get { return _taillesOreilles; }
            set { _taillesOreilles = value; }
        }

        public string afficheQuiJeSuis()
        {
            string lol ="nom : "+_nom +"\ntaille des oreille "+_taillesOreilles+".";
            return lol;
        }
        public void EcouteMessage(string message, elephant quiDit)
        {
            Console.WriteLine(_nom + " a entendu un message \n" + quiDit._nom + " a dit : " + message);
        }
        public void EnvoieMessage(string message, elephant quiRecoit)
        {
            quiRecoit.EcouteMessage(message, this);
        }

    }
}
