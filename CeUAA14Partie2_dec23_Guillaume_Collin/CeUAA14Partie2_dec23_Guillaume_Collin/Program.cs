using CeUAA14Partie2_dec23_Guillaume_Collin;

paintballGuns paintballGun = new paintballGuns();
Console.WriteLine("bienvenue dans ce jeux de paintballs");
char quit;
do
{
    paintballGun.verifIsVoid();
    Console.WriteLine(paintballGun.concatenNbBUllets());
    tryparse(out quit);

    switch (quit)
    {
        case ' ': paintballGun.shoot();
            break;
        case 'r':paintballGun.relaunchMagazine();
            break;
        case 't':
            paintballGun.relaunchPlayer();
            Console.WriteLine("munition recuperer");
            break;
    }
    if (quit != ' ' && quit != 'r' && quit != 't' && quit != 'q')
    {
        Console.WriteLine("aucune action a effecteur");
    }
} while (quit != 'q');


 void tryparse(out char quit)
{
    do
    {
       

        Console.WriteLine("espace pour tirer \n r pour recharcher \n t pour reprendre des munitions\n q pour quitter");
    } while (!char.TryParse(Console.ReadLine(), out quit));
}
