﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01T1
/*---Tehtävä03----*/
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;

            // ask three number
            Console.Write("Anna luku >");
            number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Yksi  "); //lisää käyttäjän syöttämän numeron tulosteeseen
            }
            if (number == 2)
            {
                Console.WriteLine("Kaksi  ");
            }
            if (number == 3)
            {
                Console.WriteLine("Kolme  ");
            }
            else
            {
                Console.WriteLine("joku muu luku");
            }

            //Odottaa käyttäjän toimintoa
            Console.ReadLine();
        }
    }
}