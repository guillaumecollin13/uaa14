using ACT_2_POO_EXERCICES_3;
sandwichmaker sandwichmaker = new sandwichmaker();
string sandwich;
string reco;

do
{
    Console.WriteLine("voici votre sandwich");
    sandwich = sandwichmaker.composesandwich();
    Console.WriteLine(sandwich + "\nvoulez-vous refaire un sandwich? si oui appuyez sur enter si non entrez sur s" );
   reco=Console.ReadLine();
} while (reco!="s");