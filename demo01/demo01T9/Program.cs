using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01T9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. 
            //Ohjelman tulee tulostaa syötettyjen lukujen summa.

            int luku = 0;
            int summa = 0;
            int i = 0;

            //kysytään käyttäjältä luku
            //tehdään niin kauan kuin luku ei ole nolla.
            do
            {
                Console.Write("Anna luku: ");
                luku = int.Parse(Console.ReadLine());
                summa += luku;
                i++;
           
            }
            //käyttäjä syöttää luvun nolla-> plussataan luvut yhteen
            while (luku != 0);
            {
                Console.Write("Lukujen summa on " +"\n");
                Console.WriteLine(summa);
            }

        }
    }
}
