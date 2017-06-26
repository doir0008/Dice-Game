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
    class Dice
    {
        private Random random; // Represents a pseudo-random number generator, which is a device that produces a sequence of numbers that meet certain statistical requirements for randomness.
        protected byte value;

        public Dice()
        {
            value = 1;
            
            random = new Random(int.Parse // Converts the string representation of a number to its integer equivalent.
                                (Guid.NewGuid() // GUID Represents a globally unique identifier.
                                .ToString() // ToString Returns a string that represents the current object.
                                .Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
        }

        public Dice(byte startValue)
        {
            value = startValue;
            random = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber)); 
        }

        public byte Roll()
        {
            value = Convert.ToByte(random.Next(1, 7)); // Converts a base data type to another base data type.
            return value;
        }

        public void Draw()
        {
            Console.WriteLine(value); // Represents the standard input, output, and error streams for console applications. This class cannot be inherited.
        }

        // Get method
        public byte GetValue() { return value; }



    }
}
