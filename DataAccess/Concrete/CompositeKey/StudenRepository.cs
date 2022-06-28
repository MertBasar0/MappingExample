using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class StudenRepository
    {
        private TestContext testContext;

        public StudenRepository()
        {
            testContext = new TestContext();
        }

        public void CreateStudent(string Name,out int secuation)
        {
            testContext.Students.Add(new Student() { StudentName = Name});
            secuation = testContext.SaveChanges();
        }
    }
}
