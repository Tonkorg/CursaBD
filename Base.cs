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
    public partial class Base : Form
    {

        public long CurrentId;
        public Base()
        {
            InitializeComponent();
        }
        public Base(long id)
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
            loadDataGrid();
        }

        List<long> child = new List<long>();

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
            int index = CD.CurrentRow.Index;
            if (index == null)
            {
                index = 0;
            }

            EditChildren editChildren = new EditChildren(CD.Rows[index].Cells[0].Value.ToString(), CD.Rows[index].Cells[1].Value.ToString(), CD.Rows[index].Cells[2].Value.ToString(), CD.Rows[index].Cells[3].Value.ToString(), CD.Rows[index].Cells[4].Value.ToString(), CurrentId, child[index]);
            editChildren.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateChild x = new CreateChild(CurrentId);
            x.Show();
            this.Close();
        }

        private void loadDataGrid()
        {
            using (TestBdContext db = new TestBdContext())
            {
                var user = db.Children.ToList();

                //List<ChildrenListForDataGrid> ChildList = new List<ChildrenListForDataGrid>();
                foreach (Child ch in user)
                {
                    if (ch.ParensId == CurrentId)
                    {
                        //ChildList.Add(new ChildrenListForDataGrid { Name = ch.Name, Lastname = ch.Lastname, Age = ch.Age, Sens = ch.Sens, Sex = ch.Sex });
                        CD.Rows.Add(ch.Name, ch.Lastname, ch.Sex, ch.Age, ch.Sens);
                        child.Add(ch.ChildrenId);
                    }
                }

            }
        }
        private void Edit_child_Click(object sender, EventArgs e)
        {
            ShowDialog()
        }
    }
}
