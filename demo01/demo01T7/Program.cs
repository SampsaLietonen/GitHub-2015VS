using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01T7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
            int vuosi;
            Console.Write("Anna vuosi >");
            vuosi = int.Parse(Console.ReadLine());

            // jos vuosi jaetaan 400:lla ja itseisarvo on nolla ->  karkausvuosi
            if (vuosi % 400 == 0)
            {
                Console.Write("Vuosi on karkausvuosi" + "\n");
            }
            else
            {
                Console.Write("Vuosi ei ole karkausvuosi" +"\n");
            }
        }
    }
}
