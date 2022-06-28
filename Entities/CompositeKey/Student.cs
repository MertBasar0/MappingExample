using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }


        public IList<StudentTeacher> StudentTeachers { get; set; }

        public override string ToString()
        {
            return StudentId + " " + StudentName;
        }
    }
}
