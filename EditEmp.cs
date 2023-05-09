using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace CursaBD
{
    public partial class EditEmp : Form
    {
        long curAdminId;
        long curId;
        public EditEmp()
        {
            InitializeComponent();
        }
        public EditEmp(string name, string LastName, string age, string phoneNumber, string group, string exp, long Id, long EmpId)
        {
            InitializeComponent();
            edit_emp_name_textBox.Text = name;
            edit_emp_Lastname_textBox.Text = LastName;
            edit_emp_age_textBox.Text = age;
            exp_label.Text = exp;
            edit_emp_phoneNumber_textBox.Text = phoneNumber;
            edit_emp_SPO_textBox.Text = group;

            curAdminId = Id;
            curId = EmpId;

        }
        private void registr_back_button_Click(object sender, EventArgs e)
        {
            BaseAdmin main = new BaseAdmin(curId);
            main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit_emp_name_textBox.Clear();
            edit_emp_Lastname_textBox.Clear();
            edit_emp_age_textBox.Clear();
            edit_emp_exp_textBox.Clear();
            edit_emp_phoneNumber_textBox.Clear();
            edit_emp_SPO_textBox.Clear();
        }

        private void edit_emp_name_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_emp_name_textBox.Clear();
        }

        private void edit_emp_Lastname_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_emp_Lastname_textBox.Clear();
        }

        private void edit_emp_age_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_emp_age_textBox.Clear();
        }

        private void edit_emp_phoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_emp_phoneNumber_textBox.Clear();
        }

        private void edit_emp_SPO_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_emp_SPO_textBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (TestBdContext db = new TestBdContext())
                {
                    var child = db.Employees.ToList();

                    foreach (Employee ch in child)
                    {
                        if (ch.EmployeeId == curId)
                        {
                            if (CorrectInput())
                            {
                                ch.Name = edit_emp_name_textBox.Text;
                                ch.LastName = edit_emp_Lastname_textBox.Text;
                                ch.Exp = edit_emp_exp_textBox.Text;
                                ch.Group = edit_emp_SPO_textBox.Text;
                                ch.Age = int.Parse(edit_emp_age_textBox.Text);
                                ch.PhoneNumber = int.Parse(edit_emp_phoneNumber_textBox.Text);
                                
                                db.Employees.Update(ch);
                                db.SaveChanges();
                                Base main = new Base(curAdminId);
                                main.Show();
                                this.Close();
                            }
                            else { MessageBox.Show("Неверно введены данные"); }
                        }

                    }
                }
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }
        public bool CorrectInput()
        {
            if (edit_emp_name_textBox.Text == " ")
            {
                MessageBox.Show("Некоректно введено имя");
                edit_emp_name_textBox.Clear();
                return false;
            }
            if (edit_emp_Lastname_textBox.Text == " ")
            {
                MessageBox.Show("Некоректно введена фамилия");
                edit_emp_Lastname_textBox.Clear();
                return false;

            }
            if (edit_emp_age_textBox.Text == " " || int.Parse(edit_emp_age_textBox.Text) < 18)
            {
                MessageBox.Show("Некоректно введен возраст");
                edit_emp_age_textBox.Clear();
                return false;

            }
            if (edit_emp_phoneNumber_textBox.Text == " ")
            {
                MessageBox.Show("");
                return false;
            }
            if (edit_emp_SPO_textBox.Text == " ")
            {
                MessageBox.Show("Некоректно указан отряд");
                edit_emp_SPO_textBox.Clear();
                return false;
            }
            else { return true; }
        }
    }
 }

