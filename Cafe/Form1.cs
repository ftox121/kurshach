namespace Cafe
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboaard ds = new Dashboaard("Guest");
            ds.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Timerlan" && txtPassword.Text == "123")
            {
                Dashboaard ds = new Dashboaard("Admin");
                ds.Show();
                this.Hide();
            }
        }
    }
}