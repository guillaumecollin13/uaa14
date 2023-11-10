// See https://aka.ms/new-console-template for more information
using ACT_3_ELEPHANTS_GUILLAUMECOLLIN;

elephant elephant1= new elephant("Zazou",69);
elephant elephant2 = new elephant("Titi", 13);
int choix;
string verifrecom;
string message = "salut"+elephant2._Nom;
do
{

    Console.WriteLine("tapez :  1 pour voir les onformation du premiere elephant\n" +
                      "         2 pour voir les information du second elephant\n" +
                      "         3 pour permuttez les information des deux elephant et les afficher\n" +
                      "         4 pour voir le premier elepant envoyer un message au second\n" +
                      "         5 pour reviser les tableaux ");
    choix = int.Parse(Console.ReadLine());
    switch (choix)
    {
        case 1:
            Console.WriteLine(elephant1.afficheQuiJeSuis());
            break;
        case 2:
            Console.WriteLine(elephant2.afficheQuiJeSuis());
            break;
        case 3:
            elephant elephantechange = elephant1;
            elephant1 = elephant2;
            elephant2 = elephantechange;
            Console.WriteLine(elephant1.afficheQuiJeSuis());
            Console.WriteLine(elephant2.afficheQuiJeSuis());
            break;
        case 4: elephant1.EnvoieMessage(message, elephant2);
            break;
        case 5:
            break;
        default:
            break;
    }
    
    Console.WriteLine("voulez vous recommencer si oui tapez y?");

    verifrecom=(Console.ReadLine());
} while (verifrecom=="y");
