using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    class Student
    {
        //property called ID
        public int ID { get; set; }
        //property called Name
        public string Name { get; set; }
        //property called GPA
        public float GPA { get; set; }
        public Student(int iD, string name, float GPA)
        {
            this.ID = iD;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
