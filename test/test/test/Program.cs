using System;

class Example
{
    public static void Main()
    {
        double _rayon = 5;
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor currentForeground = Console.ForegroundColor;
            ConsoleColor currentBackground = Console.BackgroundColor;
            Console.WriteLine("All the background colors except {0}, the foreground color:",
                  currentForeground);
            foreach (var color in colors)
            {
                if (color == currentForeground) continue;

                Console.BackgroundColor = color;
                Console.WriteLine("   The background color is {0}.", color);
            }

            // Restore the original console colors.
            Console.ResetColor();
            Console.WriteLine("\nOriginal colors restored...");


        double resultat;
        resultat = _rayon * _rayon;
        Console.WriteLine(resultat);

    }
}