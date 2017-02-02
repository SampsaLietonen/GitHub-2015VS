using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier pioneer = new Amplifier();
            int input;

            do
            {
                Console.WriteLine("Give a volume between 0-100: ");
                input = int.Parse(Console.ReadLine());
                pioneer.Volume = input;
                Console.WriteLine("Volume: " + pioneer.Volume);

            }
            while (input != -1 );
        }
    }
}
