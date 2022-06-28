using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingExample.StaticClasses
{
    public static class LoadList
    {
        public static void Load(ListBox lstOne,ListBox lstTwo,ListBox lstThree)
        {
            using (TestContext ts = new TestContext())
            {
                foreach (var item in ts.Teachers.ToList())
                {
                    lstOne.Items.Add(item);
                }
                foreach (var item in ts.Students.ToList())
                {
                    lstTwo.Items.Add(item);
                }
                foreach (var item in ts.StudentTeachers.ToList())
                {
                    lstThree.Items.Add(item);
                }
            }
        }
    }
}
