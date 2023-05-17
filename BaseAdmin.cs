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
    public partial class BaseAdmin : Form
    {
        long CurrentId;
        public BaseAdmin()
        {
            InitializeComponent();
        }
        public BaseAdmin(long id)
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
        List<long> emp = new List<long>();
        List<long> child = new List<long>();
        private void Main_edit_button_Click(object sender, EventArgs e)
        {
            UserEdit userEdit = new UserEdit(CurrentId);
            userEdit.Show();
            this.Visible = false;
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
                var user = db.Employees.ToList();
                var chh = db.Children.ToList();

                foreach (Employee ch in user)
                {
                    CD.Rows.Add(ch.Name, ch.LastName, ch.Age, ch.PhoneNumber, ch.Group, ch.Exp);
                    emp.Add(ch.EmployeeId);
                }
                foreach (Child ch in chh)
                {
                    dataGridView2.Rows.Add(ch.Name, ch.Lastname, ch.Age, ch.Sex, ch.Sens, ch.Otr);
                    child.Add(ch.ChildrenId);
                }

                var otr = db.Otrs.ToList();
                foreach (Otr ot in otr)
                {
                    dataGridView1.Rows.Add(ot.Number, ot.AverageAge, ot.CountChild, ot.Voz);

                }

            }
        }

        private void create_child_button_Click(object sender, EventArgs e)
        {
            CreateEmp createEmp = new CreateEmp(CurrentId);
            createEmp.Show();
            this.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index;
            if (index == null)
            {
                index = 0;
            }

            EditAdminChildren edit = new EditAdminChildren(dataGridView2.Rows[index].Cells[0].Value.ToString(), dataGridView2.Rows[index].Cells[1].Value.ToString(), dataGridView2.Rows[index].Cells[2].Value.ToString(), dataGridView2.Rows[index].Cells[3].Value.ToString(), dataGridView2.Rows[index].Cells[4].Value.ToString(), CurrentId, emp[index]);
            edit.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateChild x = new CreateChild(CurrentId);
            x.Show();
            this.Visible = false;
        }

        private void Main_edit_child_button_Click(object sender, EventArgs e)
        {
            int index = CD.CurrentRow.Index;
            if (index == null)
            {
                index = 0;
            }

            Choice choice = new Choice(CD.Rows[index].Cells[0].Value.ToString(), CD.Rows[index].Cells[1].Value.ToString(), CD.Rows[index].Cells[2].Value.ToString(), CD.Rows[index].Cells[3].Value.ToString(), CD.Rows[index].Cells[4].Value.ToString(), CurrentId, child[index]);
            choice.Show();
            this.Close();

        }

        private void CD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = CD.CurrentRow.Index;
            if (index == null)
            {
                index = 0;
            }

            EditEmp edit = new EditEmp(CD.Rows[index].Cells[0].Value.ToString(), CD.Rows[index].Cells[1].Value.ToString(), CD.Rows[index].Cells[2].Value.ToString(), CD.Rows[index].Cells[3].Value.ToString(), CD.Rows[index].Cells[4].Value.ToString(), CD.Rows[index].Cells[5].Value.ToString(), CurrentId, emp[index]);
            edit.Show();
            this.Close();
        }

        private void edit_emp_button_Click(object sender, EventArgs e)
        {
            int index = CD.CurrentRow.Index;
            if (index == null)
            {
                index = 0;
            }

            ChoiceEmp choice = new ChoiceEmp(CD.Rows[index].Cells[0].Value.ToString(), CD.Rows[index].Cells[1].Value.ToString(), CD.Rows[index].Cells[2].Value.ToString(), CD.Rows[index].Cells[3].Value.ToString(), CD.Rows[index].Cells[4].Value.ToString(), CD.Rows[index].Cells[5].Value.ToString(), CurrentId, emp[index]);
            choice.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (TestBdContext db = new TestBdContext())
            {
                //var user = db.Employees.ToList();
                var chh = db.Children.ToList();
                var otr = db.Otrs.ToList();
                //foreach (Employee ch in user)
                //{

                //}
                foreach (Child ch in chh)
                {
                    ch.Otr = 0;
                }
                foreach (Otr ot in otr)
                {
                    ot.CountChild = 0;
                    ot.AverageAge = 0;
                    ot.Voz = " ";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChoiceOtr v = new ChoiceOtr();
            v.Show();
            this.Visible = false;
        }
    }
}
