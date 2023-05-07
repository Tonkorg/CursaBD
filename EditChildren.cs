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
    public partial class EditChildren : Form
    {
        long currentPArentsId;
        long currentId;
        public EditChildren()
        {
            InitializeComponent();
        }
        public EditChildren(string name, string LastName, string age, string sex, string sens, long id,long childId)
        {
            edit_child_age_textBox.Text = age;
            edit_child_name_textBox.Text = name;
            edit_child_name_textBox.Text = LastName;
            edit_child_sens_textBox.Text = sens;
            InitializeComponent();
            currentPArentsId = id;
            currentId = childId;
        }

        private void registr_back_button_Click(object sender, EventArgs e)
        {
            Base main = new Base(currentPArentsId);
            main.Show();
            this.Close();
        }

        private void edit_child_lastName_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_child_name_textBox.Clear();
        }

        private void edit_child_name_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_child_lastName_textBox.Clear();
        }

        private void edit_child_age_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_child_age_textBox.Clear();
        }

        private void edit_child_sens_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_child_sens_textBox.Clear();
        }

        private void registr_clear_button_Click(object sender, EventArgs e)
        {
            edit_child_age_textBox.Clear();
            edit_child_lastName_textBox.Clear();
            edit_child_name_textBox.Clear();
            edit_child_sens_textBox.Clear();
        }

        private void registr_regist_button_Click(object sender, EventArgs e)
        {
            using (TestBdContext db = new TestBdContext())
            {
                var child = db.Children.ToList();


                foreach(Child ch in child)
                {
                    if(ch.ChildrenId == currentId)
                    {
                       if(CorrectInput())
                        {
                            ch.Name = edit_child_name_textBox.Text;
                            ch.Lastname = edit_child_lastName_textBox.Text;
                            ch.Age = int.Parse(edit_child_age_textBox.Text);
                            ch.Sens = edit_child_sens_textBox.Text;

                            db.SaveChanges();
                            Base main = new Base(currentPArentsId);
                            main.Show();
                            this.Close();
                        }
                        else { MessageBox.Show("Неверно введены данные"); }
                    }
                }
            }
        }
        public bool CorrectInput()
        {
            if(edit_child_age_textBox.Text == " " || int.Parse(edit_child_age_textBox.Text)>=10 || int.Parse(edit_child_age_textBox.Text) <0)
            {
                MessageBox.Show("Неверно указан возраст");
                return false;
            }
            if(edit_child_lastName_textBox.Text == " ")
            {
                MessageBox.Show("Неверно указана фамилия");
                return false;
            }
            if( edit_child_name_textBox.Text == " ")
            {
                MessageBox.Show("Неверно казано имя");
                return false;
            }
            else { return true; }
        }
    }
}
