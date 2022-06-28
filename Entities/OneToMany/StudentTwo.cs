using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.OneToMany
{
    public class StudentTwo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /* EF Relation */
        public Course Course { get; set; }
    }
}
