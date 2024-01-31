namespace ACT_6_POO_Ex_3_GuillaumeCollin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carre carre =new Carre(5,"vert");
            Rectangle rectangle = new Rectangle(5,4, "vert");

            Console.WriteLine("perimetre"+carre.calculePerimetre());
            Console.WriteLine("aire"+carre.calculeSurface());

            Console.WriteLine("perimetre" + rectangle.calculePerimetre());
            Console.WriteLine("aire" +  rectangle.calculeSurface());
        }
    }
}