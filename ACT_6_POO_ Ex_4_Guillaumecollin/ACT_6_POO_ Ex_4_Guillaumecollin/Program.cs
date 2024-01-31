namespace ACT_6_POO__Ex_4_Guillaumecollin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ouvrier ouvrier = new Ouvrier(new DateTime (2015, 12, 13),220053, "collin","guillaume", new DateTime(2000,1,12) );

            Console.WriteLine(ouvrier.Affiche());

            Directeur directeur = new Directeur(25000,10,221001,"pendragon","arthur",new DateTime(1985, 3, 14));

            Console.WriteLine(directeur.Affiche());
            //Console.WriteLine(ouvrier.calcSal());

            Cadre cadre = new Cadre(1,222001,"volovitz","howard",new DateTime(1981, 12,9));

            Console.WriteLine(directeur.Affiche());
            //Console.WriteLine(ouvrier.calcSal());
        }
    }
}