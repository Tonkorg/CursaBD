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
    public partial class UserEdit : Form
    {
        long userId;
        public UserEdit()
        {
            InitializeComponent();
        }
        public UserEdit(long id)
        {
            InitializeComponent();
            using (TestBdContext db = new TestBdContext())
            {
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    if (u.UserId == id)
                    {
                        edit_name_textBox.Text = u.Name;
                        edit_lastName_textBox.Text = u.LastName;
                        edit_phoneNumber_textBox.Text = u.PhoneNumber.ToString();
                    }
                }
            }


        }

        private void registr_clear_button_Click(object sender, EventArgs e)
        {
            edit_old_password_textBox.Clear();
            edit_new_password_textBox.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void edit_name_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_name_textBox.Clear();
        }

        private void edit_clear_info_button_Click(object sender, EventArgs e)
        {
            edit_name_textBox.Clear();
            edit_lastName_textBox.Clear();
            edit_phoneNumber_textBox.Clear();

        }

        private void edit_phoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_phoneNumber_textBox.Clear();
        }

        private void edit_lastName_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_lastName_textBox.Clear();
        }

        private void edit_edit_button_info_Click(object sender, EventArgs e)
        {
            using (TestBdContext db = new TestBdContext())
            {
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    if (u.UserId == userId)
                    {
                        
                        if (CorrectEditUser())
                        {
                            u.Name = edit_name_textBox.Text;
                            u.LastName = edit_lastName_textBox.Text;
                            u.PhoneNumber = long.Parse(edit_phoneNumber_textBox.Text);
                            db.Users.Update(u);
                            db.SaveChanges();
                            Main enter = new Main(u.UserId);
                            enter.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Некорректные данные");
                        }
                    }
                }
            }
          
        }


        public bool CorrectEditUser()
        {
            if (edit_name_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введено имя");
                edit_name_textBox.Clear();
                return false;
            }
            if (edit_lastName_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введена фамилия");
                edit_lastName_textBox.Clear();
                return false;

            }
            if (edit_phoneNumber_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введен номер телефона");
                edit_phoneNumber_textBox.Clear();
                return false;

            }
            else { return true; }
        }

        public bool CorrectEditPassword()
        {
            if (edit_new_password_textBox.Text == " " || edit_old_password_textBox.Text == " ")
            {
                return false;
            }
            return true;
        }

        private void registr_regist_button_Click(object sender, EventArgs e)
        {
            using (TestBdContext db = new TestBdContext())
            {
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    if (u.UserId == userId)
                    {
                        if (!edit_new_password_textBox.Text.Equals(u.Password))
                        {
                            MessageBox.Show("Неверно указан старый пароль");
                            break;
                        }
                        if (CorrectEditPassword())
                        {
                            u.Password = edit_new_password_textBox.Text;
                            //db.Users.Update(u);
                            db.SaveChanges();
                            Main enter = new Main(u.UserId);
                            enter.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Некорректные данные");
                        }
                    }
                }
            }
        }
    }
}

