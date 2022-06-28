using DataAccess;
using DataAccess.Concrete.TableSplitting;
using Entities.TableSpliting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingExample.TableSpliting
{
    public partial class Form1 : Form
    {
        private TableSplittingRepository rs;
        public Form1()
        {
            InitializeComponent();
            rs = new TableSplittingRepository();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in rs.GetOrders())
            {
                listBox1.Items.Add(item);
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Order ord = new Order()
            {
                Status = OrderStatus.Pending,
                DetailedOrder = new DetailedOrder()
                {
                    Adi = "siparis1",
                    Status = OrderStatus.Pending,
                    lokasyon = "istanbul",
                    Tarih = "02.02.02"
                }
            };

            rs.AddTableSplitting(ord);

            listBox1.Items.Clear();

            foreach (var item in rs.GetOrders())
            {
                listBox1.Items.Add(item);
            }
        }

   
    }
}
