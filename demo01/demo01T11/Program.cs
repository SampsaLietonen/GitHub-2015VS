using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01T11
{
    class Program
    {
        static void Main(string[] args)
        {
            //tulostaa tähtiä käyttäjän syöttämän luvun mukaan

            int luku;
            string tahti = "*";
            Console.Write("Anna luku: ");
            luku = int.Parse(Console.ReadLine());

            for (int i = 0; i <= luku; i++) //luuppi annetun luvun läpikäyntiin
            {

                for (int s = 1; s <= i; s++) //looppi tähtien tulostukselle
                {
                    Console.Write(tahti);
                }
                Console.WriteLine();
            }
        }
    }
}
