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
    public partial class ChoiceEmp : Form
    {
        long EMPID;
        string NAME;
        string LASTNAME;
        string AGE;
        string PN;
        long ADMINID;
        string GROUP;
        string EXP;
        public ChoiceEmp()
        {
            InitializeComponent();
        }
        public ChoiceEmp(string name, string LastName, string age, string phoneNumber, string group,string exp, long id, long empId)
        {
            InitializeComponent();


            using (TestBdContext db = new TestBdContext())
            {
                var user = db.Employees.ToList();
                foreach (Employee ch in user)
                {
                    if (ch.EmployeeId == empId)
                    {
                        comboBox1.Items.Add(ch.Name);
                    }
                }
            }
            EMPID = empId;
            NAME = name;
            LASTNAME = LastName;
            AGE = age;
            PN = phoneNumber;
            GROUP = group;
            ADMINID = id;
            EXP = exp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditEmp edit = new EditEmp(NAME, LASTNAME, AGE, PN, GROUP,EXP, ADMINID, EMPID);
            edit.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
