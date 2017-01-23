using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01T6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
            //Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän. 
            double matka = 0.0;
            double kulutus = 0.0; 
            double hinta = 0.0;

            Console.Write("Anna matka > ");
            matka = double.Parse(Console.ReadLine());

            //kaava, jolla kulutus lasketaan ja tulostetaan käyttäjälle
            kulutus = kulutus + (matka * (7.02 / 100.0));
            Console.WriteLine("Bensaa kuluu " + kulutus + "litraa ");

            //kaava, jolla hinta lasketaan ja tulostetaan käyttäjälle
            hinta = hinta + (1.595 * kulutus);
            Console.WriteLine("Hinta " + hinta + "euroa");


            Console.ReadLine();
        }
        
    }
}
