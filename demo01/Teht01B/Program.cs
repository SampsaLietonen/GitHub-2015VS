using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01B
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask three number
            int number, number2, number3;
            Console.Write("Give a number >");
            number = int.Parse();
            Console.Write("Give a number >");
            number = int.Parse();
            Console.Write("Give a number >");
            number = int.Parse();
            Console.WriteLine("Summa: " + number + number2 + number3);
            Console.WriteLine("Keskiarvo: " + (number + number2 + number3) /3);

            else
                {
                    Console.WriteLine("Not a integer value!");
                }
            //Odottaa käyttäjän toimintoa
            Console.ReadLine();
        }
    }
}
