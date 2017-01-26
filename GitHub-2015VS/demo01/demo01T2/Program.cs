using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01T2
{
    class Program
    {
        static void Main(string[] args)
        {

            double num;

            //ohjelma, joka tulostaa oppilaalle koulunumeron pistemäärän mukaan
            Console.Write("Anna pistemäärä > ");
            num = int.Parse(Console.ReadLine());
            if (num <= 1)
            {
                Console.WriteLine("Koulunumero on 0"); //lisää käyttäjän syöttämän numeron tulosteeseen
            }

            else if (num >= 2 && num <= 3)
            {
                Console.WriteLine("Koulunumero on 1");
            }

            else if (num >= 4 && num <= 5)
            {
                Console.WriteLine("Koulunumero on 2");
            }

            else if (num >= 6 && num <= 7)
            {
                Console.WriteLine("Koulunumero on 3");
            }

            else if (num >= 8 && num <= 9)
            {
                Console.WriteLine("Koulunumero on 4");
            }

            else if (num >= 10 && num <= 12)
            {
                Console.WriteLine("Koulunumero on 5");
            }

            //Odottaa käyttäjän toimintoa
            Console.ReadLine();
        }
    }
}
