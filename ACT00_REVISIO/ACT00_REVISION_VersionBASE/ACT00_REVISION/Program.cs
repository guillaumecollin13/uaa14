using System;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;
            
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;
            int compteur;
            string methode;
            string info;
            MethodesDuProjet yo = new MethodesDuProjet();
            // instanciation de la structure
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                compteur = 1;
                //lecture des 3 côtés 
                c1 = lireDouble(compteur);
                compteur = compteur + 1;
                c2 = lireDouble(compteur);
                compteur = compteur + 1;
                c3 = lireDouble(compteur);

                yo.OrdonneCotes(ref c1, ref c2, ref c3);
                // série de test (voir consignes)
                if (yo.Triangle(c1,c2,c3))
                {
                    methode="triangle";
                    yo.Affiche(ok,methode, out info);
                    Console.WriteLine(info);
                    
                    if (yo.Equi(c1, c2, c3))
                    {
                        methode = "equilateral";
                        yo.Affiche(ok, methode, out infos);
                        Console.WriteLine(infos);
                    }
                    else
                    {

                        if (yo.TriangleRectangle())
                        {
                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            // ...
                            // ...
                        }
                        else
                        {
                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            // ...
                            // ...
                        }
                        // vérification du cas isocèle et affichage dans le cas positif
                        //...
                        //...
                        //... A vous de voir en combien de lignes...
                    }
                }
                else // si ce n'est pas un triangle
                {
                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    // ...
                    // ...
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }
    }
}
