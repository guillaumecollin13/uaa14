// See https://aka.ms/new-console-template for more information
using ACT_2_POO_EXERCICES_2;

double Reel;
double Imagi;

Console.WriteLine("Bienvenue dans ce programme sur les complexe! \n que vaut la partie réelle du complexe de depart?");
Reel=double.Parse(Console.ReadLine());
Console.WriteLine("que vaut la partie imaginaire de ce nombre?");
Imagi=double.Parse(Console.ReadLine());

complexes complexe1=new complexes(Reel,Imagi);

Console.WriteLine("Le premier complexe:( " + complexe1.Reel+":" + complexe1.imagi + ") a pour module" + complexe1.calculModule() +
                  "\nEntrez un second nombre complexe:\n \nQue vaut la partie réelle du second nombre complexe");
Reel = double.Parse(Console.ReadLine());
Console.WriteLine("que vaut la partie imaginaire du second nombre complexe ?");
Imagi = double.Parse(Console.ReadLine());
complexes complexe2 = new complexes(Reel, Imagi);
complexe1.ajoute(complexe2);
Console.WriteLine("Le premier complexe devient:(" + complexe1.Reel+":" + complexe1.imagi + ") apres ajout du deuxiéme");

