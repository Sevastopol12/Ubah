using Ubah;
using Fe;

namespace BFE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm1 mainform = new MainForm1();
            mainform.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string userID = this.userID.Text;
                string password = this.password.Text;
                FormUser.user = (Rider)DataImporter.login(userID: userID, password: password);

                if (FormUser.user == null) { throw new Exception(); }

                MainForm1 mainform = new MainForm1();
                this.Hide();
                mainform.ShowDialog();
                this.Close();
            }

            catch (Exception ex)
            {
                this.error.ForeColor = Color.Red;
                this.error.Text = "Wrong ID or password";
            }

        }

        private async void Login_Load(object sender, EventArgs e)
        {
            //// Show a loading message
            //lblStatus.Text = "Loading data, please wait...";

            await DataImporter.Import();

            //// Hide the loading message or update the UI after import completes
            //lblStatus.Text = "Data loaded successfully!";
        }
    }
}
