using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2demo04
{
    class Amplifier
    {
        //properties
        private static int MaxVolume = 100;
        private static int MinVolume = 0;
        private int volume;
        public int Volume
        {
            get {return volume;}
            set {
                if (value >= MinVolume && value <= MaxVolume) volume = value;

                else if (value < MinVolume)
                {
                    Console.WriteLine("Too low volume - Amplifier is set to minimun " );
                    volume = MinVolume;
                }

                else if (value > MaxVolume)
                {
                    Console.WriteLine("Too high volume - Amplifier is set to maximum " );
                    volume = MaxVolume;
                }
            }
        } 
    }
}
