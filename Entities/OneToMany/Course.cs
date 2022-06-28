using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.OneToMany
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /* EF Relations */
        public IEnumerable<StudentTwo> StudentTwos { get; set; }
    }
}
