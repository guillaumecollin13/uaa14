using ACT_6POO_ex2GuillaumeCollin;

Random alea = new Random();
Animaux[] mesAnimaux = new Animaux[5];
int nbAlea;
mesAnimaux[0] = new Chien("theo", new DateTime(2015, 5, 21), 20536545, 50, false);
mesAnimaux[1] = new Chat("anastacia", new DateTime(2024, 8, 15), 251648125, 90, false);
mesAnimaux[2] = new Lapin("PanPan", new DateTime(2018, 2, 25), 251251412, 70, true, 10);
mesAnimaux[3] = new Chat("Pompom", new DateTime(2006, 1, 1), 14585648, 80, false);
mesAnimaux[4] = new Chien("T-Rex", new DateTime(2024, 3, 15), 25146987, 80, true);


for (int i = 0; i < mesAnimaux.Length; i++)
{
    nbAlea=alea.Next(0,2);
	if (mesAnimaux[i] is Chien chien)
	{
        Console.WriteLine(chien.affiche());
        Console.WriteLine(chien.aboyer());
        switch (nbAlea)
        {
            case 0:
                Console.WriteLine(chien.eat());
                    break;
            case 1:
                Console.WriteLine(chien.sleep());
                break;
        }
    }
	
	else if (mesAnimaux[i] is Chat chat)
	{
		Console.WriteLine(chat.affiche());
        Console.WriteLine(chat.miauler());
        switch (nbAlea)
        {
            case 0:
                Console.WriteLine(chat.eat());
                break;
            case 1:
                Console.WriteLine(chat.sleep());
                break;
        }
    }
    else if (mesAnimaux[i] is Lapin lapin)
    {
        Console.WriteLine(lapin.affiche());
        Console.WriteLine(lapin.jump());
        switch (nbAlea)
        {
            case 0:
                Console.WriteLine(lapin.eat());
                break;
            case 1:
                Console.WriteLine(lapin.sleep());
                break;
        }
    }
    Console.WriteLine();
}