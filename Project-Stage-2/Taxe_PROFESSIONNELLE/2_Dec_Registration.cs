using System.Data.OleDb;

namespace Taxe_PROFESSIONNELLE
{
    public partial class Dec_Registration_2 : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/Taxe-Professionnelle.accdb;Persist Security Info=False;";

        public Dec_Registration_2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text;
            string password = PasswordTextBox.Text;

            OleDbConnection oleDbConnection = new(connectionString);
            using (OleDbConnection connection = oleDbConnection)
            {

                string query = "INSERT INTO Users (Username, [Password]) VALUES (@username, @password)";
                using (OleDbCommand command = new(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registration successful! You can now log in with your new credentials.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.Hide();
            Login_1 login = new();
            login.ShowDialog();
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            UserTextBox.Clear();
            PasswordTextBox.Clear();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_1 login = new();
            login.ShowDialog();
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_1 login = new();
            login.ShowDialog();
            this.Close();
        }
    }
}
