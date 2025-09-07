

using InventoryDB.dbClasses;

namespace InventoryDB
{
    public partial class FirstLaunch : Form
    {
        public FirstLaunch()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Check that both passwords are non-null and match

            if (string.IsNullOrWhiteSpace(inputUser.Text))
            {
                //DEBUG:
                Console.WriteLine("Username can't be null!");
            }
            else if (!string.Equals(inputPass.Text, inputConfirmPass.Text))
            {
                //DEBUG:
                Console.WriteLine("Passwords must match!");
            }
            else if (string.IsNullOrWhiteSpace(inputPass.Text))
            {
                //DEBUG:
                Console.WriteLine("Password can't be null!");
            }
            else
            {
                // Make a User class, assign the User/Pass from the buttons
                userClass newUser = new userClass();
                newUser.Username = inputUser.Text;

                // TODO: Add salt and hash to password before assigning property
                newUser.Password = inputPass.Text;

                // Insert to DB
                if (userClass.Insert(newUser))
                {
                    Console.WriteLine($"{newUser.Username}, {newUser.Password} successfully inserted!");

                    // bring user to login screen if successful
                    Login loginScreen = new Login();
                    loginScreen.Show();
                }
                else
                {
                    Console.WriteLine("Didn't work!");
                }

            }



            //this.Close();
        }
    }
}