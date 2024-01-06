using System.Data.OleDb;
using System.Numerics;

namespace Taxe_PROFESSIONNELLE
{
    public partial class Dec_Retrait_7 : Form
    {
#pragma warning disable CS0649
        private readonly bool creationBtnState;
#pragma warning restore CS0649 
#pragma warning disable CS0649
        private readonly bool ouvrirBtnState;
#pragma warning restore CS0649

        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/Taxe-Professionnelle.accdb;Persist Security Info=False;";
        private OleDbConnection connection;
        private List<string[]> dataGridViewData = new List<string[]>();
        private bool isUpdateMode = false;
        private int selectedRowIndex = -1;
        private int IdR = 0;

        public Dec_Retrait_7(bool creationBtnState, bool ouvrirBtnState)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeDatabaseConnection();
            PopulateFormData();

            this.creationBtnState = creationBtnState;
            this.ouvrirBtnState = ouvrirBtnState;
#pragma warning disable CS8622
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
#pragma warning restore CS8622
        }
        private void InitializeDatabaseConnection()
        {
            connection = new OleDbConnection(connectionString);
        }

        private void Back3Button_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT IdMateriel, IdEtablisment, IdPeriode,refDesignationMat, refStatutPatrimonial, refEtatAcquision, dateAcquision, dateMiseEnService, prixAcquisition FROM Materiel WHERE IdEtablisment = @IdEtablisment";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@IdEtablisment", FormData.IdEtablisment);
                        command.Parameters.AddWithValue("@IdPeriode", FormData.IdPeriode);
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
#pragma warning disable CS8601
                            string[] rowData = new string[]
                            {
                        reader["IdMateriel"].ToString(),
                        reader["refDesignationMat"].ToString(),
                        reader["refStatutPatrimonial"].ToString(),
                        reader["refEtatAcquision"].ToString(),
                        ((DateTime)reader["dateAcquision"]).ToString("yyyy/MM/dd"),
                        ((DateTime)reader["dateMiseEnService"]).ToString("yyyy/MM/dd"),
                        reader["prixAcquisition"].ToString(),
                            };
#pragma warning restore CS8601

                            dataGridView1.Rows.Add(rowData);
                            dataGridViewData.Add(rowData);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString(), "Data Retrieval Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            SaveFormData();

            this.Hide();
            Dec_Materiel_6 form4 = new(creationBtnState, ouvrirBtnState);
            form4.ShowDialog();
            this.Close();
        }
        private void InsertDataFromDataGridView()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    foreach (string[] rowData in dataGridViewData)
                    {
                        using (OleDbCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "INSERT INTO Retraits (IdEtablisment, IdPeriode, designationRetrait, natureOperationRetrait, numTSC, numTF, prixAcquisition, prixCession, dateAcquisition, dateRetrait) " +
                                                  "VALUES (@IdEtablisment, @IdPeriode, ?, ?, ?, ?, ?, ?)";

                            command.Parameters.AddWithValue("@IdEtablisment", FormData.IdEtablisment);
                            command.Parameters.AddWithValue("@IdPeriode", FormData.IdPeriode);
                            command.Parameters.AddWithValue("designationRetrait", rowData[1]);
                            command.Parameters.AddWithValue("natureOperationRetrait", rowData[2]);
                            command.Parameters.AddWithValue("numTSC", rowData[3]);
                            command.Parameters.AddWithValue("numTF", int.Parse(rowData[4]));
                            if (DateTime.TryParse(rowData[5], out DateTime dateRetraitValue))
                            {
                                command.Parameters.AddWithValue("dateRetrait", dateRetraitValue);
                            }
                            else
                            {
                                MessageBox.Show("Invalid 'dateRetrait' value for row: " + string.Join(", ", rowData), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                            if (DateTime.TryParse(rowData[6], out DateTime dateAcquisitionValue))
                            {
                                command.Parameters.AddWithValue("dateAcquisition", dateAcquisitionValue);
                            }
                            else
                            {
                                MessageBox.Show("Invalid 'dateAcquisition' value for row: " + string.Join(", ", rowData), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                            if (double.TryParse(rowData[7], out double prixAcquisitionValue))
                            {
                                command.Parameters.AddWithValue("prixAcquisition", prixAcquisitionValue);
                            }
                            else
                            {
                                MessageBox.Show("Invalid 'prixAcquisition' value for row: " + string.Join(", ", rowData), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                            if (double.TryParse(rowData[8], out double prixCessionValue))
                            {
                                command.Parameters.AddWithValue("prixCession", prixCessionValue);
                            }
                            else
                            {
                                MessageBox.Show("Invalid 'prixCession' value for row: " + string.Join(", ", rowData), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Data inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString(), "Data Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Next5Button_Click(object sender, EventArgs e)
        {
            if (creationBtnState)
            {
                InsertDataFromDataGridView();
            }
            if (ouvrirBtnState)
            {
                if (isUpdateMode)
                {
                    UpdateDataInDatabase();
                }
            }
            dataGridView1.Rows.Clear();
            dataGridViewData.Clear();

            SaveFormData();

            this.Hide();
            Dec_Recu_8 form6 = new();
            form6.ShowDialog();
            this.Close();
        }

        private void UpdateDataInDatabase()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(@"UPDATE Retraits " +
                    "SET designationRetrait = '" + designationRetrait.Text + "', " +
                    "natureOperationRetrait = '" + natureOperationRetrait.Text + "', " +
                    "numTF = '" + numTF.Text + "', " +
                    "dateAcquisition = '" + DateTime.Parse(dateAcquisition01.Text) + "', " +
                    " dateRetrait = '" + DateTime.Parse(dateRetrait1.Text) + "', " +
                    "prixAcquisition = '" + prixAcquisition01.Text + "', " +
                    "prixCession = '" + prixCession1.Text + "' " +
                    "WHERE IdRetraits = " + IdR, connection);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Data Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        private void RetrieveDataFromDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT IdRetraits, IdEtablisment, IdPeriode, designationRetrait, natureOperationRetrait, numTSC, numTF, prixAcquisition, prixCession, dateAcquisition, dateRetrait FROM Retraits WHERE IdEtablisment = @IdEtablisment";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@IdEtablisment", FormData.IdEtablisment);
                        command.Parameters.AddWithValue("@IdPeriode", FormData.IdPeriode);
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
#pragma warning disable CS8601
                            string[] rowData = new string[]
                            {
                        reader["IdRetraits"].ToString(),
                        reader["designationRetrait"].ToString(),
                        reader["natureOperationRetrait"].ToString(),
                        reader["numTSC"].ToString(),
                        reader["numTF"].ToString(),
                        ((DateTime)reader["dateAcquisition"]).ToString("yyyy/MM/dd"),
                        ((DateTime)reader["dateRetrait"]).ToString("yyyy/MM/dd"),
                        reader["prixAcquisition"].ToString(),
                        reader["prixCession"].ToString(),
                            };
#pragma warning restore CS8601

                            dataGridView1.Rows.Add(rowData);
                            dataGridViewData.Add(rowData);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString(), "Data Retrieval Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void PopulateFormData()
        {
            nomPrenom.Text = FormData.nomPrenom;
            identifiantFiscal.Text = FormData.identifiantFiscal;
            numTPLocaleDec.Text = FormData.numTPLocaleDec;
            designationRetrait.Text = FormData.designationRetrait1;
            natureOperationRetrait.Text = FormData.natureOperationRetrait1;
            numTF.Text = FormData.numFoncier;
            dateAcquisition01.Text = FormData.dateAcquisition01;
            dateRetrait1.Text = FormData.dateRetrait1;
            prixAcquisition01.Text = FormData.prixAcquisition01;
            prixCession1.Text = FormData.prixCession1;
        }
        private void SaveFormData()
        {
            FormData.nomPrenom = nomPrenom.Text;
            FormData.identifiantFiscal = identifiantFiscal.Text;
            FormData.numTPLocaleDec = numTPLocaleDec.Text;
            FormData.designationRetrait1 = designationRetrait.Text;
            FormData.natureOperationRetrait1 = natureOperationRetrait.Text;
            FormData.numFoncier = numTF.Text;
            FormData.dateAcquisition01 = dateAcquisition01.Text;
            FormData.dateRetrait1 = dateRetrait1.Text;
            FormData.prixAcquisition01 = prixAcquisition01.Text;
            FormData.prixCession1 = prixCession1.Text;

            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            designationRetrait.Text = "";
            natureOperationRetrait.Text = "";
            numTF.Clear();
            prixAcquisition01.Clear();
            prixCession1.Clear();
            dateRetrait1.Value = DateTime.Now;
            dateAcquisition01.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] rowData = { "", designationRetrait.Text, natureOperationRetrait.Text, numTPLocaleDec.Text, numTF.Text, dateAcquisition01.Text, dateAcquisition01.Text, prixAcquisition01.Text, prixCession1.Text };

            // Add the rowData to the DataGridView starting from the second column
            dataGridView1.Rows.Add(rowData);

            // Set the IdRetraits column (first column) to be empty
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "";

            dataGridViewData.Add(rowData.Skip(1).ToArray()); // Store data without the empty first value

            if (selectedRowIndex >= 0)
            {
                // Set the updated data in the DataGridView (excluding the IdRetraits column)
                for (int i = 1; i < rowData.Length; i++)
                {
                    dataGridView1.Rows[selectedRowIndex].Cells[i].Value = rowData[i];
                }
                dataGridViewData[selectedRowIndex] = rowData.Skip(1).ToArray();
                selectedRowIndex = -1;
            }
            InsertDataIntoDatabase(rowData);
            ClearTextBoxes();
        }
        private void InsertDataIntoDatabase(string[] rowData)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = connection.CreateCommand())
                    {
                        // Define your INSERT SQL statement
                        command.CommandText = "INSERT INTO Retraits (IdEtablisment, IdPeriode, designationRetrait, natureOperationRetrait, numTSC, numTF, dateAcquisition, dateRetrait, prixAcquisition, prixCession) " +
                                              "VALUES (@IdEtablisment, @IdPeriode, @designationRetrait, @natureOperationRetrait, @numTF, @dateAcquisition, @dateRetrait, @prixAcquisition, @prixCession)";

                        // Set the parameter values
                        command.Parameters.AddWithValue("@IdEtablisment", FormData.IdEtablisment);
                        command.Parameters.AddWithValue("@IdPeriode", FormData.IdPeriode);
                        command.Parameters.AddWithValue("@designationRetrait", rowData[1]);
                        command.Parameters.AddWithValue("@natureOperationRetrait", rowData[2]);
                        command.Parameters.AddWithValue("numTSC", rowData[3]);
                        command.Parameters.AddWithValue("@numTF", int.Parse(rowData[4]));
                        command.Parameters.AddWithValue("@dateAcquisition", DateTime.Parse(rowData[5]));
                        command.Parameters.AddWithValue("@dateRetrait", DateTime.Parse(rowData[6]));
                        command.Parameters.AddWithValue("@prixAcquisition", double.Parse(rowData[7]));
                        command.Parameters.AddWithValue("@prixCession", double.Parse(rowData[8]));

                        // Execute the INSERT command
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString(), "Data Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDataInDatabase();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
        private void DeleteDataInDatabase()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(@"Delete From Retraits " +
                    "WHERE IdRetraits = " + IdR, connection);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Data Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Dec_Retrait_7_Load_1(object sender, EventArgs e)
        {
            if (ouvrirBtnState)
            {
                RetrieveDataFromDatabase();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BtnModifier.Visible = true;

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                IdR = Convert.ToInt32(selectedRow.Cells["IdRetraits"].Value.ToString());
                designationRetrait.Text = selectedRow.Cells["Column1"].Value.ToString();
                natureOperationRetrait.Text = selectedRow.Cells["Column2"].Value.ToString();
                numTF.Text = selectedRow.Cells["Column3"].Value.ToString();
                dateRetrait1.Text = selectedRow.Cells["Column4"].Value.ToString();
                dateAcquisition01.Text = selectedRow.Cells["Column5"].Value.ToString();
                prixAcquisition01.Text = selectedRow.Cells["Column6"].Value.ToString();
                prixCession1.Text = selectedRow.Cells["Column7"].Value.ToString();
                selectedRowIndex = selectedRow.Index;
            }
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to modify.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IdR >= 0)
            {
                string[] rowData = { dataGridViewData[selectedRowIndex][0], designationRetrait.Text, natureOperationRetrait.Text, numTF.Text, dateRetrait1.Text, dateAcquisition01.Text, prixAcquisition01.Text, prixCession1.Text };

                UpdateDataInDatabase();

                dataGridViewData[selectedRowIndex] = rowData;

                for (int i = 1; i < rowData.Length; i++)
                {
                    dataGridView1.Rows[selectedRowIndex].Cells[i].Value = rowData[i];
                }
                selectedRowIndex = -1;
            }
            else
            {
                MessageBox.Show("Please double-click on a row in the DataGridView to select it for modification.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
