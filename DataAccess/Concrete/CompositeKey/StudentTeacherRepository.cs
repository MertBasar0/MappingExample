using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class StudentTeacherRepository
    {
        private TestContext testContext;
        public StudentTeacherRepository()
        {
            testContext = new TestContext();
        }


        public void doAssociateTables(int studenId, int teacherId)
        {
            testContext.StudentTeachers.Add(new StudentTeacher() { StudentId = studenId, TeacherId = teacherId });
            testContext.SaveChanges();
        }
    }
}
