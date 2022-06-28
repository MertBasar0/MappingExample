using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class TeacherRepository
    {
        private TestContext testContext;

        public TeacherRepository()
        {
            testContext = new TestContext();
        }

        public int CreateTeacher(string Name)
        {
            int Secuation = 0;
            testContext.Teachers.Add(new Teacher() { TeacherName = Name });
            Secuation = testContext.SaveChanges();
            return Secuation;
        }
    }
}
