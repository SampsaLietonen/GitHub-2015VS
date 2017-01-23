using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01T10
{
    class Program
    {
        static void Main()
        {
            //Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
            //Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.

            int[] taulu = { 1, 2, 33, 44, 55, 68, 77, 96, 100 }; //taulukon alustus
            int i;

            for (i = 0; i < taulu.Length; i++) //taulukon läpikäynti
            {
                //taulukon luku jaetaan kahdella ja itseisarvo on nolla (parillinen luku)
                if (taulu[i] % 2 == 0)
                {
                    Console.WriteLine("HEP");
                }
            }

        }
    }
}
