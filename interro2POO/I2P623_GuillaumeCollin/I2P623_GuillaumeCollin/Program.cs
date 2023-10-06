// See https://aka.ms/new-console-template for more information
using I2P623_GuillaumeCollin;

Tricolore tricolore1 = new Tricolore("0001",2,true);
Tricolore tricolore2 = new Tricolore("9999", 3, true);

Console.WriteLine("Etat des feux.");
Console.WriteLine("______________");
Console.WriteLine(" ");
Console.WriteLine(tricolore1.affinchinfoFeu());
Console.WriteLine(tricolore2.affinchinfoFeu());

Console.WriteLine("Changement d'etat.");
Console.WriteLine("______________");
Console.WriteLine(" ");
for (int i = 1; i <= 5; i++)
{
    int r = i;
    if (i > 3)
    {
        r= i - 3;
    }
    tricolore1.CoulFeu = r;
    Console.WriteLine(tricolore1.affinchinfoFeu());
}
Console.WriteLine(" ");
Console.WriteLine("faire passez le feux" + tricolore1.IdFeu + " au vert");
tricolore1.CoulFeu = 3;
Console.WriteLine(tricolore1.affinchinfoFeu());
Console.WriteLine(" ");

Console.WriteLine("clignotant");
Console.WriteLine("______________");
Console.WriteLine(" ");

for (int i = 0; i <=10; i++)
{
    Console.WriteLine(tricolore2.clignoFeu());
    tricolore2.EtatFeux = !tricolore2.EtatFeux;
}