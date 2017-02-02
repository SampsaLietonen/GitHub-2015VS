using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo04T1
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {
        }

        public Teacher(string firstname, string lastname, string room)
            : base (firstname,lastname) //mennään yliluokkaan päin, kutsuu yliluokan konstruktoria
        {
            Room = room;
        }

        //method for teacher
        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to teacher!");
        }

        public override string ToString()
        {
            //Person- luokan ToString + Room
            //palauttaa firstname + lastanem .....+ room
            //base viittaa ylikuokkaan eli nyt Person- luokkaan
            return base.ToString() + " " +Room;
        }
    }

    
}
