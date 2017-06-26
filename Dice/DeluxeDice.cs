/*
Ryan Doiron
03/30/2016
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class DeluxeDice : Dice
    {
        protected uint[] diceStats = new uint[6];

        public DeluxeDice()
        {
            
        }
        public DeluxeDice(byte startValue) : base(startValue) // The base keyword is used to access members of the base class from within a derived class
        {
            if(startValue >= 1 && startValue <= 6)
            {
                this.value = startValue; // The this keyword refers to the current instance of the class and is also used as a modifier of the first parameter of an extension method.

            }
            else
            {
                return;
            }
            
        }
        public new void Draw() // Used to hide an inherited member from a base class member.
        {
            Console.WriteLine("*****");
            Console.WriteLine("* " + value + " *");
            Console.WriteLine("*****");
        }
        public new byte Roll()
        {
            base.Roll();
            GenerateStatistics(value);
            return value;
        }
        public uint[] GetDiceStats() { return diceStats; }

        protected void GenerateStatistics(byte value)
        {
            if (value==1)
            {
                diceStats[0]++;
            } else
            {
                diceStats[value - 1]++;
            }
            
            //switch (value)
            //{
            //    case 1:
            //        diceStats[0]++;
            //        break;
            //    case 2:
            //        diceStats[1]++;
            //        break;
            //    case 3:
            //        diceStats[2]++;
            //        break;
            //    case 4:
            //        diceStats[3]++;
            //        break;
            //    case 5:
            //        diceStats[4]++;
            //        break;
            //    case 6:
            //        diceStats[5]++;
            //        break;
            //    default:
            //        Console.WriteLine("DICE FACE VALUE ERROR\n");
            //        break;
            //}
        }
    }
}
