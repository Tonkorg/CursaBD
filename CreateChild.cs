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
    public partial class CreateChild : Form
    {
        long parentsId;
        public CreateChild()
        {
            InitializeComponent();
        }

        public CreateChild(long id)
        {
            parentsId = id;
            InitializeComponent();
        }
        private void CreateChild_Load(object sender, EventArgs e)
        {

        }

        private void registr_back_button_Click(object sender, EventArgs e)
        {
            Base main = new Base(parentsId);
            main.Show();
            this.Close();
        }

        private void registr_clear_button_Click(object sender, EventArgs e)
        {
            child_Age_textBox.Clear();
            child_lastName_textBox.Clear();
            child_name_textBox.Clear();
            child_sens_textBox.Clear();
        }

        private void registr_regist_button_Click(object sender, EventArgs e)
        {
            using (TestBdContext bd = new TestBdContext())
            {
                if (CorrectInput())
                {
                    Child child = new Child
                    {
                        Name = child_name_textBox.Text,
                        Lastname = child_lastName_textBox.Text,
                        Age = int.Parse(child_Age_textBox.Text),
                        Sens = child_sens_textBox.Text,
                        ParensId = parentsId,
                        Sex = comboBox1.Text
                    };
                    bd.Children.Add(child);
                    bd.SaveChanges();

                    Base main = new Base(parentsId);
                    main.Show();
                    this.Close();
                }
            }
        }

        public bool CorrectInput()
        {
            if (child_name_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введено имя");
                child_name_textBox.Clear();
                return false;
            }
            if (child_lastName_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введена фамилия");
                child_lastName_textBox.Clear();
                return false;

            }
            if (child_Age_textBox.Text == " ")
            {
                MessageBox.Show("Неккоректно введен возраст");
                child_Age_textBox.Clear();
                return false;

            }
            if (int.Parse(child_Age_textBox.Text) >= 18)
            {
                MessageBox.Show("Некорректный возраст ребенка");
                return false;
            }
            else { return true; }
        }
    }
}


