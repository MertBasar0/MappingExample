using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StudentTeacher
    {

        public int? StudentId { get; set; }
        public Student? Student { get; set; }

        public int? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }


        public override string ToString()
        {
            return Teacher.TeacherId.ToString() + " " + Student.StudentId.ToString();
        }
    }
}
