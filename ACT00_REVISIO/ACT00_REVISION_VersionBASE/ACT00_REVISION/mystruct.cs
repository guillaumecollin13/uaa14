using System;
using System.Collections.Generic;
using System.Text;

namespace ACT00_REVISION
{
    internal class mystruct
    {
        public double tryparse()
        {
            double donAVerif;
            bool trypasse;
            do 
            {
                if (double.TryParse(Console.ReadLine(), out donAVerif))
                {
                    trypasse = true;
                }
                else
                {
                    trypasse = false;
                    Console.WriteLine("ERROR ENTREE INVALIDE VEUILLEZ ENTRER UNE VALEUR CORRECT");

                }
            } while (trypasse==false);

            return donAVerif;
        }
        public void disPref()
        {
            int choice;
            Console.WriteLine("voulez-vous changez la couleur de police(1) , la couleur de fond(2) ou rien(3)?");
            choice=int.Parse(Console.ReadLine());
           if (choice == 1)
            {
                changePolice();
            }else if (choice==2)
            {
                changeBackground();
            }
            else
            {

            }
        }
        private void changePolice()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor currentForeground = Console.ForegroundColor;
            ConsoleColor currentBackground = Console.BackgroundColor;
            int colorchoice;
            Console.WriteLine("All the foreground colors except {0}, the background color:",
                          currentBackground);
            foreach (var color in colors)
            {
                if (color == currentBackground) continue;

                Console.ForegroundColor = color;
                Console.WriteLine("   The foreground color is {0}.", color);
            }
            Console.WriteLine();
            // Restore the foreground color.
            Console.ForegroundColor = currentForeground;
            Console.WriteLine("quelle couleur choississez-vous?");
            Console.WriteLine("DarkBlue(1)\r\n" +
                              "DarkGreen(2)\r\n" +
                              "DarkCyan(3)\r\n" +
                              "DarkRed(4)\r\n" +
                              "DarkMagenta(5)\r\n" +
                              "DarkYellow(6)\r\n" +
                              "Gray(7)\r\n" +
                              "DarkGray(8)\r\n" +
                              "Blue(9)\r\n" +
                              "Green(10)\r\n" +
                              "Cyan(11)\r\n" +
                              "Red(12)\r\n" +
                              "Magenta(13)\r\n" +
                              "Yellow(14)\r\n" +
                              "White(15)");
            colorchoice = int.Parse(Console.ReadLine());
            switch (colorchoice)
            {
                case (1):
                    Console.ForegroundColor =ConsoleColor.DarkBlue; break;
                case (2):
                    Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                case (3):
                    Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                case (4):
                    Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case (5):
                    Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                case (6):
                    Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                case (7):
                    Console.ForegroundColor = ConsoleColor.Gray; break;
                case (8):
                    Console.ForegroundColor = ConsoleColor.DarkGray; break;
                case (9):
                    Console.ForegroundColor = ConsoleColor.Blue; break;
                case (10):
                    Console.ForegroundColor = ConsoleColor.Green; break;
                case (11):
                    Console.ForegroundColor = ConsoleColor.Cyan; break;
                case (12):
                    Console.ForegroundColor = ConsoleColor.Red; break;
                case (13):
                    Console.ForegroundColor = ConsoleColor.Magenta; break;
                case (14):
                    Console.ForegroundColor = ConsoleColor.Yellow; break;
                case (15):
                    Console.ForegroundColor = ConsoleColor.White; break;
                default:
                    break;
            }
        }
        private void changeBackground() 
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor currentForeground = Console.ForegroundColor;
            ConsoleColor currentBackground = Console.BackgroundColor;
            int colorchoice;
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
            Console.WriteLine("quelle couleur choississez-vous?");
            Console.WriteLine("DarkBlue(1)\r\n" +
                              "DarkGreen(2)\r\n" +
                              "DarkCyan(3)\r\n" +
                              "DarkRed(4)\r\n" +
                              "DarkMagenta(5)\r\n" +
                              "DarkYellow(6)\r\n" +
                              "Gray(7)\r\n" +
                              "DarkGray(8)\r\n" +
                              "Blue(9)\r\n" +
                              "Green(10)\r\n" +
                              "Cyan(11)\r\n" +
                              "Red(12)\r\n" +
                              "Magenta(13)\r\n" +
                              "Yellow(14)\r\n" +
                              "White(15)");
            colorchoice = int.Parse(Console.ReadLine());
            switch (colorchoice)
            {
                case (1):
                    Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                case (2):
                    Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                case (3):
                    Console.BackgroundColor = ConsoleColor.DarkCyan; break;
                case (4):
                    Console.BackgroundColor = ConsoleColor.DarkRed; break;
                case (5):
                    Console.BackgroundColor = ConsoleColor.DarkMagenta; break;
                case (6):
                    Console.BackgroundColor = ConsoleColor.DarkYellow; break;
                case (7):
                    Console.BackgroundColor = ConsoleColor.Gray; break;
                case (8):
                    Console.BackgroundColor = ConsoleColor.DarkGray; break;
                case (9):
                    Console.BackgroundColor = ConsoleColor.Blue; break;
                case (10):
                    Console.BackgroundColor = ConsoleColor.Green; break;
                case (11):
                    Console.BackgroundColor = ConsoleColor.Cyan; break;
                case (12):
                    Console.BackgroundColor = ConsoleColor.Red; break;
                case (13):
                    Console.BackgroundColor = ConsoleColor.Magenta; break;
                case (14):
                    Console.BackgroundColor = ConsoleColor.Yellow; break;
                case (15):
                    Console.BackgroundColor = ConsoleColor.White; break;
                default:
                    break;
            }

        }
    }
}
