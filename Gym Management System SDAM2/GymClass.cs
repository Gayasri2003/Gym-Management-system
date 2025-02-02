using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System_SDAM2
{
     public class GymClass
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string Instructor { get; set; }
        public string Schedule { get; set; }
       

        public GymClass(int classId, string className, string instructor, string schedule)
        {
            ClassId = classId;
            ClassName = className;
            Instructor = instructor;
            Schedule = schedule;
           
        }
        public override string ToString()
        {
            return $"{ClassName} - {Schedule}";
        }
    }

}
