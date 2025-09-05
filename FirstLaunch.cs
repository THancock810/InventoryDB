

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
            Login loginScreen = new Login();
            loginScreen.Show();
            //this.Close();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
