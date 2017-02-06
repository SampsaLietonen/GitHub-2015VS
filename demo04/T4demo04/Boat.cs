using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4demo04
{
    class Boat : Vehicle
    {
        //properties
        public string BoatType { get; set; }
        public int SeatCount { get; set; }

        //default constructor
        public Boat()
        {
        }

        //parametric constructor
        public Boat(string name, string model, int modelyear, string color, string boattype, int seatcount)
            : base(name, model, modelyear, color)
        {
            BoatType = boattype;
            SeatCount = seatcount;
        }

        public override string ToString()
        {
            return base.ToString() + "BoatType:" + BoatType + " " + "SeatCount:" + SeatCount;
        }
    }
}
