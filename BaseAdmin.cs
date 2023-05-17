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


                foreach (Employee ch in user)
                {
                    CD.Rows.Add(ch.Name, ch.LastName, ch.Age, ch.PhoneNumber, ch.Group, ch.Exp);
                    emp.Add(ch.EmployeeId);
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateChild x = new CreateChild(CurrentId);
            x.Show();
            this.Visible = false;
        }

        private void Main_edit_child_button_Click(object sender, EventArgs e)
        {
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
    }
}
