// See https://aka.ms/new-console-template for more information
using firstClass;

string affiche;
Console.WriteLine("Hello, World!");

chien chien1 = new chien("plue","cockere",10, true,false,true,false,true);
chien chien2 = new chien("toby", "buldog", 5, false,true,false,true,false);
chien chien3 = new chien("seth", "berger allemend", 4, true,true,true,true,false);

Console.WriteLine(chien1.afficheCaracteristique());
Console.WriteLine(chien2.afficheCaracteristique());
Console.WriteLine(chien3.afficheCaracteristique());

Console.WriteLine(chien1.Age);
chien1.Age =uint.Parse(Console.ReadLine());
Console.WriteLine();
string gen;
if (chien1.Vaccin) { gen = "male"; } else { gen = "femelle"; }
chien1.Vaccin = bool.Parse(Console.ReadLine());
Console.WriteLine(chien1.Genre);
chien1.Genre = bool.Parse(Console.ReadLine());
Console.WriteLine(chien1.Sterelise);
chien1.Sterelise = bool.Parse(Console.ReadLine());
Console.WriteLine(chien1.Dresse);
chien1.Dresse = bool.Parse(Console.ReadLine());
Console.WriteLine(chien1.Toilette);
chien1.Toilette = bool.Parse(Console.ReadLine());
Console.WriteLine(chien1.afficheCaracteristique());

