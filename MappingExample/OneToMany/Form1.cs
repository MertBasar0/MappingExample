using DataAccess;
using DataAccess.Concrete.ConditionalMapping;
using Entities.OneToMany;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingExample.OneToMany
{
    public partial class Form1 : Form
    {
        private OneToManyRepository one;
        public Form1()
        {
            InitializeComponent();
            one = new OneToManyRepository();
        }

        private void btn_seed_Click(object sender, EventArgs e)
        {
            one.SeedMethod();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var ts = new TestContext())
            {
                foreach (var item in ts.StudentTwos.ToList())
                {
                    listBox1.Items.Add(item.Id + " " + item.Name);
                }
                foreach (var item in ts.Courses.ToList())
                {
                    listBox1.Items.Add(item.Id + " " + item.Name);
                }
            }
        }
    }
}
