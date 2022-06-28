using DataAccess;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingExample
{
    public partial class Form2 : Form
    {
        private TeacherRepository Repository;
        public Form2()
        {
            InitializeComponent();
            Repository = new TeacherRepository();
        }

        private void btn_OgretmenEkle_Click(object sender, EventArgs e)
        {
            int SaveSuccess = 0;
            SaveSuccess = Repository.CreateTeacher(textBox1.Text);
            if (SaveSuccess == 1)
            {
                MessageBox.Show("kayit başarili");
            }
            else
            {
                MessageBox.Show("kayit yapilamadi");
            }
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
