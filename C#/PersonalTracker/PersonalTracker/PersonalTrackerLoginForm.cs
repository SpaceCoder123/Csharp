namespace PersonalTracker
{
    public partial class PersonalTrackerLoginForm : Form
    {
        public PersonalTrackerLoginForm()
        {
            InitializeComponent();
        }

        private void EnterUsernamePassword_Click(object sender, EventArgs e)
        {
            if ((UserNameInput.Text.Length <= 3) || (UserNameInput.Text.Length >= 8))
            {
                MessageBox.Show("Dear User, Please keep the user name length within 3 and 8 ");
                UserNameInput.Text = "";
            }
        }


        private void UserNameInput_TextChanged(object sender, EventArgs e)
        {
            if (UserNameInput.Text != "") {
                try
                {
                    Convert.ToInt32(UserNameInput.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid");
                    UserNameInput.Text = "";
                }
            }
        }
    }
}