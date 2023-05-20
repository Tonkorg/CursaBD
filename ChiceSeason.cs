using Microsoft.EntityFrameworkCore;
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


    public partial class ChiceSeason : Form
    {
        public long CurrentId;
        public long childId;
        public ChiceSeason()
        {
            InitializeComponent();
        }

        public ChiceSeason(long id)
        {

            InitializeComponent();
            CurrentId = id;

            using (TestBdContext db = new TestBdContext())
            {
                var child = db.Children.ToList();

                foreach (var item in child)
                {
                    if (item.ParensId.Equals(CurrentId))
                    {
                        comboBox1.Items.Add(item.Name);

                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            using (TestBdContext db = new TestBdContext())
            {
                var rr = db.Requirements.ToList();
                var chil = db.Children.ToList();
                foreach (var item in chil)
                {
                    if (item.ParensId.Equals(CurrentId) && item.Name.Equals(comboBox1.Text))
                    {

                        Require req = new Require
                        {
                            ParrentsId = CurrentId,
                            ChildId = item.ChildrenId,
                            Season = int.Parse(comboBox2.Text)
                        };
                        foreach (Require reqq in rr)
                        {
                            if (req.ParrentsId != reqq.ParrentsId && req.ChildId != reqq.ChildId && req.Season != reqq.Season)
                            {
                                db.Requirements.Add(req);
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Заявка уже отправлена");
                            }
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Пупупу");
                    }


                }
                Base b = new Base(CurrentId);
                b.Show();
                this.Close();


            }
        }
    }
}
