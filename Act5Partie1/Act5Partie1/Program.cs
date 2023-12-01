// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
GumballMachine gum = new GumballMachine(25,1) ;
int coinInserted;
string message;
Console.WriteLine("prix : " + gum._Price + " piece");
coinInserted= int.Parse(Console.ReadLine());
message=gum.DispenseOneGumball(coinInserted);
Console.WriteLine(message);