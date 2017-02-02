using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1demo04
{
    class Elevator
    {
        //properties
        private static int MaxFloor = 5;
        private static int MinFloor = 1;
        private int floor;
        public int Floor
        {
            get { return floor; }
            set {
                if (value >= MinFloor && value <= MaxFloor) floor = value;

                else if (value < MinFloor)
                    Console.WriteLine("Floor number is too small!");

                else if (value > MaxFloor)
                    Console.WriteLine("Floor number is too big!");

            }

           }
    }
}
