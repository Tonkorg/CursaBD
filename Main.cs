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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public Main(long id)
        {   InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            
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
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
