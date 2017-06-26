/*
Ryan Doiron
03/30/2016
*/
using System; // Provides a convenient syntax that ensures the correct use of IDisposable objects.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            DeluxeDice d1 = new DeluxeDice(1);
            for (int i = 0; i < 6000001; i++)
            {
                d1.Roll();
            }
            Console.WriteLine("\t\t\tRoll Statistics on 6 million rolls:");
            Console.WriteLine("Rolled 1\tRolled 2\tRolled 3\tRolled 4\tRolled 5\tRolled 6");
            Console.WriteLine("--------\t--------\t--------\t--------\t--------\t--------");
            foreach (var x in d1.GetDiceStats())
            {
                
                Console.Write(x + "\t\t");
            }

            Dice d2 = new Dice();
            DeluxeDice d3 = new DeluxeDice();
            d2.Roll();
            d3.Roll();
            Console.WriteLine("\n");
            d2.Draw();
            Console.WriteLine("\n");
            d3.Draw();
            
        }
    }
}
/*
This code is very similar to that of Java. I like how similar the syntax is to Java and I like that we can easily can console colors.
I can't think of anything that I dislike about C#. The dice classes are nice and simple and overall, I really like C#.
*/
