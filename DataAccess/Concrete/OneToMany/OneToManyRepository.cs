using Entities.OneToMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.ConditionalMapping
{
    public class OneToManyRepository
    {
        private TestContext testContext;

        public OneToManyRepository()
        {
            testContext = new TestContext();
        }


        public void SeedMethod()
        {
            var course = new Course()
            {
                Name = "DotNet C#",
                StudentTwos = new List<StudentTwo>()
                {
                    new StudentTwo(){Name = "ahmet"},
                    new StudentTwo(){Name = "mehmet"},
                    new StudentTwo(){Name = "sercan"},
                    new StudentTwo(){Name = "ayse"}
                }
            };
            testContext.Add(course);
            testContext.SaveChanges();
        }
    }
}
