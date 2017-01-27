using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Washer
    {
        //properties
        public bool IsOn { get; set; }
        public bool Water { get; set; }
        public int Temperature { get; set; }
        private int program { get; set; }
        public int Program {
            get { return program; }
            set
            {
                if (value == 1)
                {
                        program = value;
                        Console.WriteLine("Cotton 90min");
                }
            
                else if (value == 2)
                {
                    program = value;
                    Console.WriteLine("Synthetic fibres 45min");
                }

                else if (value == 3)
                {
                    program = value;
                    Console.WriteLine("Whites 120min");
                }

                else if (value == 4)
                {
                    program = value;
                    Console.WriteLine("Colored 120min");
                }
                else value = 0;
                
            }
        }
        private static int MaxRotationalSpeed = 1600;
        private int rotationalspeed;
        public int RotationalSpeed
        {
            get { return rotationalspeed; }
            set
            {
                if (value <= MaxRotationalSpeed) rotationalspeed = value;
                else rotationalspeed = RotationalSpeed;
            }
        }

        public bool Start { get; set; }

        // default constructor
        public Washer()
        {
        }

        //parametric onstructor - all properties will be known when washer is created
        public Washer(bool ison, bool water, int temperature, int program, int rotationalspeed, bool start)
        {
            IsOn = ison;
            Water = water;
            Temperature = temperature;
            Program = program;
            RotationalSpeed = rotationalspeed;
            Start = start;
            
        }

        //methods
        //method to switch Power on
        public void Power (bool value)
        {
            value = true;
        }

        //method to chech Faucet is open
        public void Faucet(bool value)
        {
            value = true;
        }

        // method to choose a program
        /*
        public void Choose()
        {
            if (Program == 1)
            {
                Console.WriteLine("Cotton 90min");
            }

            else if (Program == 2)
            {
                Console.WriteLine("Synthetic fibres 45min");
            }

            else if (Program == 3)
            {
                Console.WriteLine("Whites 120min");
            }
           
            else if (Program == 4)
            {
                Console.WriteLine("Colored 120min");
            }

        }
        */

        // method to se a temperature
        public void SetTemp()
        {
            if (Temperature == 30)
            {
                Console.WriteLine("30");
            }

            else if (Temperature == 40)
            {
                Console.WriteLine("40");
            }

            else if (Temperature == 30)
            {
                Console.WriteLine("60");
            }

            else if (Temperature == 30)
            {
                Console.WriteLine("90");
            }

        }

        //method to display Washer properties
        public void PrintData()
        {
            Console.WriteLine("Washer data: ");
            Console.WriteLine("- State: " +IsOn);
            Console.WriteLine("- Program: " +Program);
            Console.WriteLine("- Water: " +Water);
            Console.WriteLine("- Temperature: " +Temperature);
            Console.WriteLine("- RotarionalSpeed: " +RotationalSpeed);
            Console.WriteLine("- Start program: " +Start);

        }

    }
}
