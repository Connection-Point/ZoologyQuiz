namespace Zoology_Quiz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Textbox_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Textbox_Username.Text = "";
            this.Hide();
            Main f2 = new Main();
            f2.ShowDialog();
            this.Close();
        }

        private void Button_Login_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}