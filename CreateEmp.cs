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

namespace CursaBD
{
    public partial class CreateEmp : Form
    {
        long CurId;
        public CreateEmp()
        {
            InitializeComponent();
        }
        public CreateEmp(long id)
        {
            CurId = id;
            InitializeComponent();
        }

        private void registr_back_button_Click(object sender, EventArgs e)
        {
            BaseAdmin main = new BaseAdmin(CurId);
            main.Show();
            this.Close();
        }


        private void create_emp_clear_button_Click(object sender, EventArgs e)
        {
            create_emp_age_textBox.Clear();
            create_emp_exp_textBox.Clear();
            create_emp_Lastname_textBox.Clear();
            create_emp_name_textBox.Clear();
            create_emp_spo_textBox.Clear();
        }

        private void Create_emp_button_Click(object sender, EventArgs e)
        {
            using (TestBdContext bd = new TestBdContext())
            {
                if (CorrectInput())
                {
                    Employee emp = new Employee
                    {
                        Name = create_emp_name_textBox.Text,
                        LastName = create_emp_Lastname_textBox.Text,
                        Age = int.Parse(create_emp_age_textBox.Text),
                        PhoneNumber = int.Parse(create_emp_phoneNumber_textBox.Text),
                        Exp = create_emp_exp_textBox.Text,
                        Group = create_emp_spo_textBox.Text
                    };
                    bd.Employees.Add(emp);
                    bd.SaveChanges();

                    BaseAdmin main = new BaseAdmin(CurId);
                    main.Show();
                    this.Close();
                }
            }
        }
        public bool CorrectInput()
        {
            if (create_emp_name_textBox.Text == " ")
            {
                MessageBox.Show("Некоректно введено имя");
                create_emp_name_textBox.Clear();
                return false;
            }
            if (create_emp_Lastname_textBox.Text == " ")
            {
                MessageBox.Show("Некоректно введена фамилия");
                create_emp_Lastname_textBox.Clear();
                return false;

            }
            if (create_emp_age_textBox.Text == " " || int.Parse(create_emp_age_textBox.Text) < 18)
            {
                MessageBox.Show("Некоректно введен возраст");
                create_emp_age_textBox.Clear();
                return false;

            }
            if (create_emp_phoneNumber_textBox.Text == " ")
            {
                MessageBox.Show("");
                return false;
            }
                if (create_emp_spo_textBox.Text == " ")
                {
                    MessageBox.Show("Некоректно указан отряд");
                    create_emp_spo_textBox.Clear();
                    return false;
                }
                else { return true; }
        }
    }

}

