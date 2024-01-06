using System.Data.OleDb;

namespace Taxe_PROFESSIONNELLE
{
    public partial class Login_1 : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/Taxe-Professionnelle.accdb;Persist Security Info=False;";

        public Login_1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text;
            string password = PasswordTextBox.Text;

            using OleDbConnection connection = new(connectionString);

            string query = "SELECT UserID, Username FROM Users WHERE Username = @username AND Password = @password";
            using OleDbCommand command = new(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    FormData.UserID = reader.GetInt32(reader.GetOrdinal("UserID"));
                    FormData.Username = reader.GetString(reader.GetOrdinal("Username"));

                    this.Hide();
                    Menu_3 menu = new();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            UserTextBox.Clear();
            PasswordTextBox.Clear();
            UserTextBox.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dec_Registration_2 dec_Registration = new();
            dec_Registration.ShowDialog();
            this.Close();
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            
        }
    }
}