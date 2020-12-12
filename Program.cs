using System;
using System.Drawing;
using System.Media;
using System.Threading;


namespace HappyNewYear
{
    class Program
    {

        static void Main()
        {
            Point[] points = { new Point {X = 4, Y = 9}, new Point { X = 7, Y = 8 }, new Point { X = 6, Y = 10 },
            new Point { X = 7, Y = 14 }, new Point { X = 4, Y = 15 }, new Point { X = 6, Y = 16 },
            new Point { X = 7, Y = 20 }, new Point { X = 4, Y = 21 }, new Point { X = 6, Y = 22 } };
            ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.Magenta };
            Random rand = new Random();

            // Врубает музыку.
            SoundPlayer jingleBells = new SoundPlayer(Properties.Resources.JingleBells);
            jingleBells.PlayLooping();
            Console.WriteLine("С новым годом!\n");
            StarLayer();
            TreeLayer(3);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("     000 ");
            Console.WriteLine("     000 ");
            Console.WriteLine("     000 ");
            int randPos;
            while (true)
            {
                for (byte i = 0; i < points.Length; i++)
                {
                    randPos = rand.Next(points.Length);
                    Console.SetCursorPosition(points[randPos].X, points[randPos].Y);
                    Console.ForegroundColor = colors[rand.Next(colors.Length)];
                    Console.Write("0");
                }
                Thread.Sleep(300);
            }
        }

        // Выводит слой ёлочки
        static void TreeLayer(byte amount)
        {
            for (byte i = 0; i < amount; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("      0  ");
                Console.WriteLine("     000 ");
                Console.WriteLine("    00000 ");
                Console.WriteLine("   0000000 ");
                Console.WriteLine("  000000000 ");
                Console.WriteLine(" 00000000000 ");
            }
        }

        // Выводит звезду-пизду
        static void StarLayer()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("      0  ");
            Console.WriteLine("    00000  ");
            Console.WriteLine("     000 ");
            Console.WriteLine("    0   0 ");
        }
    }
}
