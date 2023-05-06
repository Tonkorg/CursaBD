using Microsoft.EntityFrameworkCore;

namespace CursaBD

{
    public partial class registr_form : Form
    {

        public registr_form()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void registr_clear_button_Click(object sender, EventArgs e)
        {
            registr_name_textBox.Clear();
            registr_lastName_textBox.Clear();
            registr_login_textBox.Clear();
            registr_password_textBox.Clear();
            registr_password_confirm_textBox.Clear();
            registr_phoneNumber_textBox.Clear();
        }

        private void registr_back_button_Click(object sender, EventArgs e)
        {
            EnterForm enter = new EnterForm();
            this.Close();

        }

        private void registr_regist_button_Click(object sender, EventArgs e)
        {
            if (CorrectInput())
            {
                try
                {

                    using (TestBdContext db = new TestBdContext())
                    {

                        var users = db.Users.ToList();
                        {
                            foreach (User u in users)
                            {
                                if (u.Login == registr_login_textBox.Text)
                                {
                                    MessageBox.Show("Этот логин уже занят");
                                    break;
                                }

                            }
                            User newUser = new User
                            {
                                Name = registr_name_textBox.Text,
                                LastName = registr_lastName_textBox.Text,
                                PhoneNumber = long.Parse(registr_phoneNumber_textBox.Text),
                                Password = registr_password_textBox.Text,
                                Login = registr_login_textBox.Text
                            };

                            db.Users.Add(newUser);
                            db.SaveChanges();
                            EnterForm enter = new EnterForm(newUser.Login,newUser.Password);
                            enter.Show();
                            this.Close();
                        }
                         
                    }
                   
                }

                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    Console.WriteLine(ee.Message);
                }
            }
        }

        public bool CorrectInput()
        {
            if (registr_name_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введено имя");
                registr_name_textBox.Clear();
                return false;
            }
            if (registr_lastName_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введена фамилия");
                registr_lastName_textBox.Clear();
                return false;

            }
            if (registr_login_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введен логин");
                registr_login_textBox.Clear();
                return false;

            }
            if (registr_phoneNumber_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введен номер телефона");
                registr_phoneNumber_textBox.Clear();
                return false;

            }
            if (registr_password_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введен пароль");
                registr_password_textBox.Clear();
                return false;

            }
            if (registr_password_textBox.Text != registr_password_confirm_textBox.Text)
            {
                MessageBox.Show("пароли не совпадают!");
                registr_password_confirm_textBox.Clear();
                return false;
            }

            else { return true; }
        }
    }
}