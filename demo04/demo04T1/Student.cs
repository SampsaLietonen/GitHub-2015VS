using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo04T1
{
    class Student : Person
    {
        public string StudentID { get; set; }

        //default constructor
        public Student()
        {
        }

        //parametric constructor calls base class constructor with parameters
        public Student(string firstname, string lastname, string studentID)
            : base(firstname, lastname)
        {
            StudentID = studentID;
        }

        //one method what student can do
        public void StundentMethod()
        {
            Console.WriteLine("This method belongs to Student!");
        }

        //override base class ToString()- method
        public override string ToString()
        {
            //Person- luokan ToString + StudentID
            //palauttaa firstname + lastanem .....+ studentID
            //base viittaa ylikuokkaan eli nyt Person- luokkaan
            return base.ToString() + " " + StudentID;
        }
    }
}
