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
            bool okiso;
            string modyfycolor;
            MethodesDuProjet yo = new MethodesDuProjet();
            mystruct mystru = new mystruct();
            // instanciation de la structure
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            Console.WriteLine("voulez vous changez les couleur de police et de fond(oui)");
            modyfycolor = Console.ReadLine();
            if (modyfycolor =="oui" ) 
            {
                mystru.disPref();
            }
            
 
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
                if (ok=yo.Triangle(c1,c2,c3))
                {
                    methode="triangle";
                    yo.Affiche(ok,methode, out info);
                    Console.WriteLine(info);
                    
                    if (ok = yo.Equi(c1, c2, c3))
                    {
                        methode = "equilateral";
                        yo.Affiche(ok, methode, out info);
                        Console.WriteLine(info);
                    }
                    else
                    {

                        if (ok = yo.TriangleRectangle(c1, c2, c3))
                        {
                            methode = "rectangle";
                            yo.Affiche(ok, methode, out info);
                            Console.WriteLine(info);
                        }
                        else
                        {
                            ok = false;
                            methode = "rectangle";
                            yo.Affiche(ok, methode, out info);
                            Console.WriteLine(info);

                        }
                        
                        if (okiso = yo.Isocele(c1, c2, c3))
                        {
                            methode = "isocele";
                            yo.Affiche(okiso, methode, out info);
                            Console.WriteLine(info);
                        }
                    }
                }
                else // si ce n'est pas un triangle
                {
                    methode = "triangle";
                    yo.Affiche(ok, methode, out info);
                    Console.WriteLine(info);
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            mystruct mystruc = new mystruct();
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            //cote = double.Parse(Console.ReadLine());
            cote = mystruc.tryparse(); 
            return cote;
        }
    }
}
