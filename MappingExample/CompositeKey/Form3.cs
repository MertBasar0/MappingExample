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
    public partial class Form3 : Form
    {
        private StudenRepository Repository;
        public Form3()
        {
            InitializeComponent();
            Repository = new StudenRepository();
        }



        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Repository.CreateStudent(textBox1.Text, out int SaveSuccess);
            if (SaveSuccess == 1)
            {
                MessageBox.Show("kayıt başarılı");
            }
            else
            {
                MessageBox.Show("kayıt yapılamadı");
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
