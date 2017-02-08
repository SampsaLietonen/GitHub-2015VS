using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5demo04
{
    class Radio
    {
        //properties
        public bool On { get; set; }
        private static int MaxVolume = 9;
        private static int MinVolume = 0;
        private int volume;
        public int Volume
        {
            get { return volume; }
            set {
                if (value >= MinVolume && value <= MaxVolume) volume = value;

                else if (value < MinVolume) volume = MinVolume;
                    //Console.WriteLine("Turn volumebutton to the other dircetion!");

                else if (value > MaxVolume) volume = MaxVolume;
                    //Console.WriteLine("Volume 9 is the maximum!");

            }
                
        }

        private static double minF = 2000.0;
        private static double maxF = 2600.0;
        private double frequency;
        public double Frequency {
            get { return frequency; }
            set {
                if (value >= minF && value <= maxF) frequency = value;

                else if (value < minF) frequency = minF;
                    //Console.WriteLine("Too low frequency!");

                else if (value > maxF) frequency = maxF;
                    //Console.WriteLine("Too high frequency");
            }
        }

        //default constructor
        public Radio()
        {
        }

        //parametric constructor
        public Radio(bool on, int volume, double frequency)
        {
            On = on;
            Volume = volume;
            Frequency = frequency;
        }

        //return Radio data as a one string, override Object class ToString()- method
        public override string ToString()
        {
            return "Radio is on: " + On + " " + "Volume: " + Volume + " " + "Frequency: " + Frequency + " ";
        }
    }
}
