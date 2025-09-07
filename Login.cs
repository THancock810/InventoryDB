using InventoryDB.dbClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // take user/pass from buttons
            userClass loginAttempt = new userClass();
            loginAttempt.Username = inputUser.Text;
            loginAttempt.Password = inputPass.Text;

            // get User info stored in DB and compare
            DataTable credentials = userClass.Select();

            if (!credentials.Rows[0][0].Equals(loginAttempt.Username))
            {
                Console.WriteLine("Username is incorrect!");
            }
            else if (!credentials.Rows[0][1].Equals(loginAttempt.Password))
            {
                Console.WriteLine("Password is incorrect!");
            }
            else
            {
                Main mainScreen = new Main();
                mainScreen.Show();
            }
        }
    }
}
