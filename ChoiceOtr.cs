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
    public partial class ChoiceOtr : Form
    {
        int number;
        public ChoiceOtr()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (TestBdContext db = new TestBdContext())
            {
                var otr = db.Otrs.ToList();

                foreach (Otr o in otr)
                {
                    comboBox1.Items.Add(o.Number);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditOtr o = new EditOtr(number);
            o.Show();
            this.Close();
        }
    }
}
