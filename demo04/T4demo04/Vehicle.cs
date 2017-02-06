using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4demo04
{
    class Vehicle
    {
        //properties
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        //default constructor
        public Vehicle()
        {
        }

        //parametric constructor
        public Vehicle(string name, string model, int modelyear, string color)
        {
            Name = name;
            Model = model;
            ModelYear = modelyear;
            Color = color;
        }

        //return Vehicle data as a one string, override Object class ToString()- method
        public override string ToString()
        {
            return "Name:" + Name + " " + "Model:" + Model + " " + "ModelYear:" + ModelYear + " " + "Color:" + Color + " ";
        }

    }
}
