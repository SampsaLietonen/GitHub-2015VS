using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01T8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.

            int luku1, luku2, luku3;
            //kysytään käyttäjältä kolme lukua
            Console.Write("Anna luku: ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku: ");
            luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku: ");
            luku3 = int.Parse(Console.ReadLine());

            //suurimman luvun löytämiseen Math.Max
            Console.WriteLine("Suurin luku on "+Math.Max(Math.Max(luku1, luku2), luku3));

            Console.ReadLine();

        }
    }
}
