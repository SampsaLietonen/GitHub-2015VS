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
            static string Method1(int secs)
            {
                int hours = secs / 3600;
                int mins = (secs % 3600) / 60;
                secs = secs % 60;
                return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, mins, secs);
            }

        }
    }
}
