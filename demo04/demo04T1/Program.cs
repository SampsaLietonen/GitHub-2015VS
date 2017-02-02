using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo04T1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonApplication
            //create a one Student Object
            Student student = new Student();
            student.FirstName = "Teppo";
            student.LastName = "Terävä";
            student.Address = "Piippukatu 3";
            student.Age = 24;
            student.PhoneNumber = "0501234123";
            student.StudentID = "H1234";
            Console.WriteLine(student.ToString());

            //create a one Teacher Object with parametric constructor
            Teacher teacher = new Teacher("Kirsi", "Kernell", "D556");
            teacher.Age = 35;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "0504444333";
            Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StundentMethod();

            //Olio ei ole aliluokan sisällä, joten ei voi käyttää
            //student.PersonMethod();
        }
    }
}
