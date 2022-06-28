    using DataAccess;
using DataAccess.Concrete;
using Entities;

namespace MappingExample
{
    public partial class Form1 : Form
    {
        private StudentTeacherRepository repositories;

        public Form1()
        {
            InitializeComponent();
            repositories = new StudentTeacherRepository();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

            StaticClasses.LoadList.Load(listBox1,listBox2,listBox3);
        }


        private void btn_ogrenciEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void btn_ogretmenEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void btn_Esle_Click(object sender, EventArgs e)
        {
            int _studentId = ((Student)listBox2.SelectedItem).StudentId;
            int _teacherId = ((Teacher)listBox1.SelectedItem).TeacherId;

            repositories.doAssociateTables(_studentId,_teacherId);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            StaticClasses.LoadList.Load(listBox1, listBox2, listBox3);
        }

       
    }
}