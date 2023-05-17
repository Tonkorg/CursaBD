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
    public partial class Choice : Form
    {
        long CHILDID;
        string NAME;
        string LASTNAME;
        string AGE;
        string SES;
        long PARRENTSID;
        string Sex;
        int userTypeForAdmin = 1;
        public Choice()
        {
            InitializeComponent();
        }
        public Choice(string name, string LastName, string age, string sex, string sens, long id, long childId)
        {
            InitializeComponent();
            

            using (TestBdContext db = new TestBdContext())
            {
                var user = db.Children.ToList();
                foreach (Child ch in user)
                {
                    if (ch.ParensId == id)
                    {
                        comboBox1.Items.Add(ch.Name);
                    }
                }
                var us = db.Users.ToList();
                foreach (User u in us)
                {
                    if (u.UserType != 1)
                    {
                        userTypeForAdmin = 2;
                        foreach (Child ch in user)
                        {                 
                               comboBox1.Items.Add(ch.Name);
                        }

                    }
                }
            }
            CHILDID = childId;
            NAME = name;
            LASTNAME = LastName;
            AGE = age;
            SES = sens;
            PARRENTSID = id;
            Sex = sex;
        }
            

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userTypeForAdmin == 1)
            {
                EditChildren edit = new EditChildren(NAME, LASTNAME, AGE, Sex, SES, PARRENTSID, CHILDID);
                edit.Show();
                this.Close();
            }
            else
            {
                {
                    EditAdminChildren edit = new EditAdminChildren(NAME, LASTNAME, AGE, Sex, SES, PARRENTSID, CHILDID);
                    edit.Show();
                    this.Close();
                }
            }
        }
    }
}
