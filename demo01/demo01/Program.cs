using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
    /*---Tehtävä03----*/
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number, number2, number3;
            int sum = 0;
            double avg = 0;

            // ask three number
            Console.Write("Give a number >");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("You gave a number  " +number); //lisää käyttäjän syöttämän numeron tulosteeseen
            Console.Write("Give a number >");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("You gave a number  " +number2);
            Console.Write("Give a number >");
            number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("You gave a number  " +number3);
            
            sum =  number + number2 + number3;
      
            Console.WriteLine("Sum of numbers: " +sum);

            avg = (number + number2 + number3) / 3.0;
           
            Console.WriteLine("Average: " +avg);

            /*else
                {
                Console.WriteLine("Not a integer value!");
            }*/
            //Odottaa käyttäjän toimintoa
            Console.ReadLine();
        }
    }
}