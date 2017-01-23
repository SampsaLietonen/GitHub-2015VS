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
            //double sekunnit;

            Console.Write("Give seconds > ");
            double sekunnit = double.Parse(Console.ReadLine());

            //timepsan FromsSeconds metodilla muuntaminen
            //tällä hetkellä staattinen luku
            var timeSpan = TimeSpan.FromSeconds(7200);
            int hh = timeSpan.Hours;
            int mm = timeSpan.Minutes;
            int ss = timeSpan.Seconds;
            Console.WriteLine("Hours: " + hh + " Minutes: " + mm + " Seconds: " + ss);
        }
    }
}
