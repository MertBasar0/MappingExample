using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string TeacherName { get; set; }


        public IList<StudentTeacher> StudentTeachers { get; set; }


        public override string ToString()
        {
            return TeacherId + " " + TeacherName;
        }
    }
}
