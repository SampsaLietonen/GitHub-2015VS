using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3demo04
{
    class Boss: Staff
    {
        //properties
        public string Car { get; set; }
        public int Bonus { get; set; }

        //default constructor
        public Boss()
        {
        }

        //parametric constructor
        public Boss(string name, string profession, int salary, string car, int bonus)
            : base (name, profession,salary)
        {
            Car = car;
            Bonus = bonus;
        }

        //one method what boss can do
        public void BossMethod()
        {
            Console.WriteLine("This method belongs to Boss!");
        }

        public override string ToString()
        {
            //Staff- luokan ToString + Salary + Car + Bonus
            //palauttaa name:profession:salary:car:bonus
            //base viittaa ylikuokkaan eli nyt Staff- luokkaan
            return base.ToString() + "Car:" + Car + " " + "Bonus:" + Bonus;
        }
    }
}
