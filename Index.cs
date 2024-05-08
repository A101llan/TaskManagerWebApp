namespace TaskManagerWebApp
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void UserSignUpbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form (Index.cs)
            UserSignUp userSignUpForm = new UserSignUp();
            userSignUpForm.Closed += (s, args) => this.Close();
            userSignUpForm.Show();
        }

        private void UserSignInbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Close the current form (Index.cs)
            UserSignIn UserSignInForm = new UserSignIn();
            UserSignInForm.Closed += (s, args) => this.Close();
            UserSignInForm.Show(); // Show the UserSignInForm
        }
    }
}
