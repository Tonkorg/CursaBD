using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursaBD
{
    public partial class EnterForm : Form
    {
        public long enterId;
        public EnterForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://vk.com/artekkurgan");
        }

        private void enter_registr_button_Click(object sender, EventArgs e)
        {
            registr_form registr_Form = new registr_form();
            registr_Form.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CorrectEnter())
            {
                Main main = new Main(enterId);
                main.Show();
                this.Visible= false;
            }
            else
            {
                MessageBox.Show("Неверно введен логин и пароль, проверьте правильность введенных данных");
            }
        }

        public bool CorrectEnter()
        {
            using (TestBdContext db = new TestBdContext())
            {
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    if (u.Login.Equals(enter_login_textBox.Text) && u.Password.Equals(enter_password_textBox.Text))
                    {
                        enterId = u.UserId;
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
