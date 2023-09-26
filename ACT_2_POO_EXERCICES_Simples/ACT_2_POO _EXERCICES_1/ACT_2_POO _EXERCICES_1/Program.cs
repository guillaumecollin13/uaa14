// See https://aka.ms/new-console-template for more information
using ACT_2_POO__EXERCICES_1;
double Rayon;
double Aire;
double Perimetre;
string affichage;
Console.WriteLine("entrez le rayon de votre cercle");
Rayon=double.Parse(Console.ReadLine());
Cercle cercle=new Cercle(Rayon);

Aire=cercle.caclculerPerimetre();
Perimetre=cercle.caclculerPerimetre();
affichage=cercle.afficheCaracteristique(Aire, Perimetre);
Console.WriteLine(affichage);

