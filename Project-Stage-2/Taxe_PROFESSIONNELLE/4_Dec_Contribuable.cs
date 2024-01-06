using System.Data.OleDb;

namespace Taxe_PROFESSIONNELLE
{
    public partial class Dec_Contribuable_4 : Form
    {
        private readonly bool creationBtnState;
        private readonly bool ouvrirBtnState;
        readonly int userID = FormData.UserID;
        readonly string username = FormData.Username;
        private bool isUpdateMode = false;

        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/Taxe-Professionnelle.accdb;Persist Security Info=False;";
        private OleDbConnection connection;

        public Dec_Contribuable_4(bool creationBtnState, bool ouvrirBtnState)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

#pragma warning disable CS8622
            declarationInitiale.CheckedChanged += DeclarationInitiale_CheckedChanged;
#pragma warning restore CS8622
#pragma warning disable CS8622 
            declarationModificative.CheckedChanged += DeclarationModificative_CheckedChanged;
#pragma warning restore CS8622 

            InitializeDatabaseConnection();
            PopulateFormData();

            this.creationBtnState = creationBtnState;
            this.ouvrirBtnState = ouvrirBtnState;

        }

        private void InitializeDatabaseConnection()
        {
            connection = new OleDbConnection(connectionString);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            SaveFormData();
            this.Hide();
            Menu_3 menu = new();
            menu.ShowDialog();
            this.Close();
        }

        private void Next2Button_Click(object sender, EventArgs e)
        {
            string nomprenom = nomPrenom.Text;
            string cnicarte = cniCarte.Text;
            string identifiantfiscal = identifiantFiscal.Text;
            string ice = ICE.Text;
            string Adress = adress.Text;
            string numtp = numTP.Text;
            string numtsc = numTSC.Text;
            string AdressE = adressLocaleDec.Text;
            string numtpE = numTPLocaleDec.Text;
            string numtscE = numTSCLocaleDec.Text;

            if (!int.TryParse(Annee.Text, out int annee) || annee < int.MinValue || annee > int.MaxValue)
            {
                MessageBox.Show("Invalid value for Annee. Please enter a valid integer value within the range.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }
            string exerciceFiscalDu = "01/01/" + annee.ToString();
            string exerciceFiscalAu = "12/31/" + annee.ToString();

            if (creationBtnState)
            {
                if (string.IsNullOrWhiteSpace(nomprenom) || string.IsNullOrWhiteSpace(cnicarte) || string.IsNullOrWhiteSpace(identifiantfiscal) || string.IsNullOrWhiteSpace(ice))
                {
                    MessageBox.Show("Please fill in all the mandatory fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using OleDbCommand command = connection.CreateCommand();
                try
                {
                    connection.Open();

                    // Insert "contribuable" table:
                    command.CommandText = "INSERT INTO Contribuable (identifiantFiscal, UserID, nomPrenom, [cniCarte], [ice], [Adress], [numTP], [numTSC]) " +
                                          "VALUES (@identifiantfiscal, @userID, @nomprenom,@cnicarte, @ice, @Adress, @numtp, @numtsc)";

                    command.Parameters.AddWithValue("@identifiantfiscal", OleDbType.Integer).Value = identifiantfiscal;
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@nomprenom", nomprenom);
                    command.Parameters.AddWithValue("@cnicarte", cnicarte);
                    command.Parameters.AddWithValue("@ice", OleDbType.Integer).Value = ice;
                    command.Parameters.AddWithValue("@Adress", Adress);
                    command.Parameters.AddWithValue("@numtp", OleDbType.Integer).Value = numtp;
                    command.Parameters.AddWithValue("@numtsc", OleDbType.Integer).Value = numtsc;
                    command.ExecuteNonQuery();
                    FormData.identifiantFiscal = identifiantfiscal;
                    // Insert "Periode" table:
                    command.CommandText = "INSERT INTO Periode (Annee, [IF],  [exerciceFiscalDu], [exerciceFiscalAu], [declarationInitiale]) VALUES (@annee, @IF,  @exerciceFiscalDu, @exerciceFiscalAu, @declarationInitiale)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@annee", OleDbType.Integer).Value = annee;
                    command.Parameters.AddWithValue("@IF", OleDbType.Integer).Value = identifiantfiscal;
                    command.Parameters.AddWithValue("@exerciceFiscalDu", OleDbType.Date).Value = DateTime.Parse(exerciceFiscalDu).Date;
                    command.Parameters.AddWithValue("@exerciceFiscalAu", OleDbType.Date).Value = DateTime.Parse(exerciceFiscalAu).Date;
                    command.Parameters.AddWithValue("@declarationInitiale", declarationInitiale.Checked);
                    command.ExecuteNonQuery();


                    // Insert "etablisment" Table:
                    command.CommandText = "INSERT INTO Etablisment ( IF, [AdressE], [numTPE], [numTSCE])" +
                                          "VALUES ( @IF, @AdressE, @numtpE, @numtscE)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@IF", OleDbType.Integer).Value = identifiantfiscal;
                    command.Parameters.AddWithValue("@AdressE", AdressE);
                    command.Parameters.AddWithValue("@numtpE", OleDbType.Integer).Value = numtpE;
                    command.Parameters.AddWithValue("@numtscE", OleDbType.Integer).Value = numtscE;
                    command.ExecuteNonQuery();

                    MessageBox.Show("Data inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString(), "Data Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            if (ouvrirBtnState)
            {
                if (isUpdateMode)
                {
                    UpdateDataInDatabase();
                }
            }

            SaveFormData();
            this.Hide();
            Dec_Terrain_5 form3 = new(creationBtnState, ouvrirBtnState);
            form3.ShowDialog();
            this.Close();
        }
        private void UpdateDataInDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = connection.CreateCommand())
                    {
                        // Update Contribuable table
                        command.CommandText = "UPDATE Contribuable SET nomPrenom = @nomPrenom, cniCarte = @cnicarte, ice = @ice, Adress = @Adress, numTP = @numtp, numTSC = @numtsc WHERE identifiantFiscal = @identifiantfiscal";
                        command.Parameters.AddWithValue("@nomPrenom", nomPrenom.Text);
                        command.Parameters.AddWithValue("@cnicarte", cniCarte.Text);
                        command.Parameters.AddWithValue("@ice", ICE.Text);
                        command.Parameters.AddWithValue("@Adress", adress.Text);
                        command.Parameters.AddWithValue("@numtp", numTP.Text);
                        command.Parameters.AddWithValue("@numtsc", numTSC.Text);
                        command.Parameters.AddWithValue("@identifiantfiscal", FormData.identifiantFiscal);
                        command.ExecuteNonQuery();

                        // Clear parameters before using them in the next command
                        command.Parameters.Clear();

                        // Update Etablisment table
                        command.CommandText = "UPDATE Etablisment SET [AdressE] = @AdressE, [numTPE] = @numtpE, [numTSCE] = @numtscE WHERE [IF] = @identifiantfiscal";
                        command.Parameters.AddWithValue("@AdressE", adressLocaleDec.Text);
                        command.Parameters.AddWithValue("@numtpE", numTPLocaleDec.Text);
                        command.Parameters.AddWithValue("@numtscE", numTSCLocaleDec.Text);
                        command.Parameters.AddWithValue("@identifiantfiscal", FormData.identifiantFiscal);
                        command.ExecuteNonQuery();

                        // Clear parameters before using them in the next command
                        command.Parameters.Clear();

                        // Update Periode table
                        command.CommandText = "UPDATE Periode SET Annee = @annee, DeclarationInitiale = @declarationInitiale WHERE IF = @identifiantfiscal";
                        command.Parameters.AddWithValue("@annee", Annee.Text);
                        command.Parameters.AddWithValue("@declarationInitiale", declarationInitiale.Checked);
                        command.Parameters.AddWithValue("@identifiantfiscal", FormData.identifiantFiscal);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString(), "Data Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RetrieveDataFromDatabase()
        {
            string queryContribuable = "SELECT nomPrenom, [cniCarte], [identifiantFiscal], [ice], [Adress], [numTP], [numTSC] FROM Contribuable WHERE identifiantFiscal = @identifiantFiscal";
            string queryEtablissment = "SELECT IdEtablisment ,[IF], [AdressE], [numTPE], [numTSCE] FROM Etablisment WHERE numTPE = @numTPE";
            string queryPeriode = "SELECT IdPeriode ,[IF], [Annee], [DeclarationInitiale] FROM Periode WHERE Annee = @Annee";

            using OleDbConnection connection = new(connectionString);
            try
            {
                connection.Open();

                using (OleDbCommand commandContribuable = new(queryContribuable, connection))
                {
                    commandContribuable.Parameters.AddWithValue("@identifiantFiscal", FormData.identifiantFiscal);
                    OleDbDataReader readerContribuable = commandContribuable.ExecuteReader();
                    if (readerContribuable.Read())
                    {
                        nomPrenom.Text = readerContribuable["nomPrenom"].ToString();
                        cniCarte.Text = readerContribuable["cniCarte"].ToString();
                        FormData.identifiantFiscal = identifiantFiscal.Text = readerContribuable["identifiantFiscal"].ToString();
                        ICE.Text = readerContribuable["ice"].ToString();
                        adress.Text = readerContribuable["Adress"].ToString();
                        numTP.Text = readerContribuable["numTP"].ToString();
                        numTSC.Text = readerContribuable["numTSC"].ToString();

                        isUpdateMode = true;
                    }
                    else
                    {
                        MessageBox.Show("No data found for the provided details in the 'contribuable' table.");
                    }
                    readerContribuable.Close();
                }

                using (OleDbCommand commandEtablissment = new(queryEtablissment, connection))
                {
                    commandEtablissment.Parameters.AddWithValue("@numTPE", FormData.numTPLocaleDec);
                    OleDbDataReader readerEtablissment = commandEtablissment.ExecuteReader();
                    if (readerEtablissment.Read())
                    {
                        FormData.IdEtablisment = readerEtablissment.GetInt32(readerEtablissment.GetOrdinal("IdEtablisment"));
                        adressLocaleDec.Text = readerEtablissment["AdressE"].ToString();
                        numTPLocaleDec.Text = readerEtablissment["numTPE"].ToString();
                        numTSCLocaleDec.Text = readerEtablissment["numTSCE"].ToString();
                        isUpdateMode = true;
                    }
                    else
                    {
                        MessageBox.Show("No data found for the provided details in the 'etablisment' table.");
                    }
                    readerEtablissment.Close();
                }

                using (OleDbCommand commandPeriode = new(queryPeriode, connection))
                {
                    commandPeriode.Parameters.AddWithValue("@Annee", FormData.Annee);
                    OleDbDataReader readerPeriode = commandPeriode.ExecuteReader();
                    if (readerPeriode.Read())
                    {
                        FormData.IdPeriode = readerPeriode.GetInt32(readerPeriode.GetOrdinal("IdPeriode"));
                        Annee.Text = readerPeriode["Annee"].ToString();
                        bool declarationInitialeValue = readerPeriode.GetBoolean(readerPeriode.GetOrdinal("DeclarationInitiale"));
                        declarationInitiale.Checked = declarationInitialeValue;
                        isUpdateMode = true;
                    }
                    else
                    {
                        MessageBox.Show("No data found for the provided details in the 'Periode' table.");
                    }
                    readerPeriode.Close();
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Data Retrieval Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFormData()
        {
            nomPrenom.Text = FormData.nomPrenom;
            cniCarte.Text = FormData.cniCarte;
            identifiantFiscal.Text = FormData.identifiantFiscal;
            ICE.Text = FormData.ice;
            adress.Text = FormData.adress;
            numTP.Text = FormData.numTP;
            numTSC.Text = FormData.numTSC;
            adressLocaleDec.Text = FormData.adressLocaleDec;
            numTPLocaleDec.Text = FormData.numTPLocaleDec;
            numTSCLocaleDec.Text = FormData.numTSCLocaleDec;
            declarationInitiale.Checked = FormData.declarationInitiale;
            declarationModificative.Checked = FormData.declarationModificative;
            Annee.Text = FormData.Annee;
        }

        private void SaveFormData()
        {
            FormData.nomPrenom = nomPrenom.Text;
            FormData.cniCarte = cniCarte.Text;
            FormData.identifiantFiscal = identifiantFiscal.Text;
            FormData.ice = ICE.Text;
            FormData.adress = adress.Text;
            FormData.numTP = numTP.Text;
            FormData.numTSC = numTSC.Text;
            FormData.adressLocaleDec = adressLocaleDec.Text;
            FormData.numTPLocaleDec = numTPLocaleDec.Text;
            FormData.numTSCLocaleDec = numTSCLocaleDec.Text;
            FormData.declarationInitiale = declarationInitiale.Checked;
            FormData.declarationModificative = declarationModificative.Checked;
            FormData.Annee = Annee.Text;
        }

        private void DeclarationInitiale_CheckedChanged(object sender, EventArgs e)
        {
            if (declarationInitiale.Checked)
            {
                declarationModificative.Checked = false;
            }
        }


        private void DeclarationModificative_CheckedChanged(object sender, EventArgs e)
        {
            if (declarationModificative.Checked)
            {
                declarationInitiale.Checked = false;
            }
        }

        private void Dec_Contribuable_4_Load(object sender, EventArgs e)
        {
            if (ouvrirBtnState)
            {
                RetrieveDataFromDatabase();
            }
        }
    }
}
