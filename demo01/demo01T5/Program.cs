using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01T5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. 
            Aikamääre sekuntteina kysytään käyttäjältä.*/

            int koksek;

            int sek;
            int min;
            int h;
            Console.WriteLine("Anna aika sekunteina: ");
            koksek = int.Parse(Console.ReadLine());

            while (koksek != 0)
                sek = (koksek % 60);
                min = (koksek % 3600) / 60;
                h = koksek / 3600;
            Console.WriteLine("Anna sekunttiaika voidaan ilmaista muodossa: " +koksek);

        }
    }
}
