using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Main : Form
    {

        public long CurrentId;
        public Main()
        {
            InitializeComponent();
        }
        public Main(long id)
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            CurrentId = id;

            using (TestBdContext db = new TestBdContext())
            {
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    if (u.UserId == id)
                    {
                        Main_name.Text = u.Name;
                        main_LastName.Text = u.LastName;
                        main_number.Text = u.PhoneNumber.ToString();
                    }
                }

            }
            //loadDataGrid();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Main_edit_button_Click(object sender, EventArgs e)
        {
            UserEdit userEdit = new UserEdit(CurrentId);
            userEdit.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (TestBdContext db = new TestBdContext())
            {
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateChild x = new CreateChild(CurrentId);
            x.Show();
            this.Close();
        }

        private void loadDataGrid()
        {
            using(TestBdContext db = new TestBdContext())
            {
                var user = db.Children.ToList();

                foreach(Child ch in user)
                {
                    if(ch.ParensId == CurrentId)
                    {
                        CD.Rows.Add(ch);
                    }
                }    
            }
        }
    }
}
