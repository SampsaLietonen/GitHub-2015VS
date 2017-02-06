using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4demo04
{
    class Bike : Vehicle
    {
        //properies
        public bool GearWheel { get; set; }
        public string GearModel { get; set; }

        //default constructor
        public Bike()
        {
        }

        //paramteric constructor
        public Bike(string name, string model, int modelyear, string color, bool gearwheel, string gearmodel)
            : base(name, model, modelyear, color)
        {
            GearWheel = gearwheel;
            GearModel = gearmodel;
        }

        public override string ToString()
        {
            //Vehicle- luokan ToString + GearWheel + GearModel
            //palauttaa name:model:modelyear:color:gearwheel:gearmodel
            //base viittaa ylikuokkaan eli nyt Vehicle- luokkaan
            return base.ToString() + "GearWheel:" + GearWheel + " " + "GearModel:" + GearModel;
        }
    }
}
