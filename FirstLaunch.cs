

namespace InventoryDB
{
    public partial class FirstLaunch : Form
    {
        public FirstLaunch()
        {
            InitializeComponent();
        }

        private void FirstLaunch_Load(object sender, EventArgs e)
        {

        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Check that both passwords are non-null and match

            if (!(string.IsNullOrWhiteSpace(inputPass.Text) | string.IsNullOrWhiteSpace(inputConfirmPass.Text)) &
                string.Equals(inputPass.Text, inputConfirmPass.Text))
            {

            }
            else
            {
                //DEBUG:
                Console.WriteLine("One password is null or they don't match!");
            }

                Login loginScreen = new Login();
            loginScreen.Show();
            //this.Close();
        }
    }
}
