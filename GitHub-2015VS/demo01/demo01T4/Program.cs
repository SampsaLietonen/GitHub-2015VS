using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01T4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. 
            Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".*/
            int ika;

            //ohjelma, joka tulostaa oppilaalle koulunumeron pistemäärän mukaan
            Console.Write("Anna ikäsi > ");
            ika = int.Parse(Console.ReadLine());
            if (ika < 18)
            {
                Console.WriteLine("alaikäinen"); //lisää käyttäjän syöttämän numeron tulosteeseen
            }

            else if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("aikuinen");
            }

            else
                Console.WriteLine("seniori");
        }
    }
}
