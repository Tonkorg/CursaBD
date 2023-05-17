using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursaBD
{
    public partial class EditOtr : Form
    {
        int umber;
        double aver;
        double count;
        int sum;
        public EditOtr()
        {
            InitializeComponent();
        }

        public EditOtr(int number)
        {
            InitializeComponent();
            label1.Text = number.ToString();
            umber = number;
            loadDataGrid();
            aver = sum / count;

            textBox1.Text = count.ToString();
            textBox2.Text = aver.ToString();


        }
        private void loadDataGrid()
        {
            using (TestBdContext db = new TestBdContext())
            {
                var otr = db.Children.ToList();
                foreach (Child o in otr)
                {
                    if (o.Otr == umber)
                    {
                        dataGridView2.Rows.Add(o.Name, o.Lastname, o.Age, o.Sex, o.Sens);
                        sum += (int)o.Age;
                        count++;
                    }
                }
            }
        }

        private void EditOtr_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
