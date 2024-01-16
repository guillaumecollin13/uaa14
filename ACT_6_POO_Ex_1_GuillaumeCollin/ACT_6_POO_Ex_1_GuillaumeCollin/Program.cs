using ACT_6_POO_Ex_1_GuillaumeCollin;

Voiture voiture = new Voiture("diesel V8", true, "GT", "ford", "blue", 5000000);
veichule veic = new veichule("GT", "ford", "blue", 5000000);
Velo velo = new Velo("VTT", false, "btwin ", "rockrider 340", "bleu", 2000);
string reponse;
string reponse2;
reponse = voiture.affiche();
reponse2 = velo.affiche();
Console.WriteLine(reponse);
Console.WriteLine(reponse2);