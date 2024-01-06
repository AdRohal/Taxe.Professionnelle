using System;
using System.Data;
using System.Data.OleDb;

namespace Taxe_PROFESSIONNELLE
{
    public partial class Dec_Materiel_6 : Form
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
        private int IdM = 0;

        public Dec_Materiel_6(bool creationBtnState, bool ouvrirBtnState)
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
                            command.CommandText = "INSERT INTO Materiel (IdEtablisment, IdPeriode ,refDesignationMat, refStatutPatrimonial, refEtatAcquision, dateAcquision, dateMiseEnService, prixAcquisition) " +
                                                  "VALUES (@IdEtablisment, @IdPeriode, ?, ?, ?, ?, ?)";

                            command.Parameters.AddWithValue("@IdEtablisment", FormData.IdEtablisment);
                            command.Parameters.AddWithValue("@IdPeriode", FormData.IdPeriode);
                            command.Parameters.AddWithValue("refDesignationMat", rowData[1]);
                            command.Parameters.AddWithValue("refStatutPatrimonial", rowData[2]);
                            command.Parameters.AddWithValue("refEtatAcquision", rowData[3]);

                            if (DateTime.TryParse(rowData[4], out DateTime dateAcquisionValue))
                            {
                                command.Parameters.AddWithValue("dateAcquision", dateAcquisionValue);
                            }
                            else
                            {
                                MessageBox.Show("Invalid 'dateAcquision' value for row: " + string.Join(", ", rowData), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }

                            if (DateTime.TryParse(rowData[5], out DateTime dateMiseEnServiceValue))
                            {
                                command.Parameters.AddWithValue("dateMiseEnService", dateMiseEnServiceValue);
                            }
                            else
                            {
                                MessageBox.Show("Invalid 'dateMiseEnService' value for row: " + string.Join(", ", rowData), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }

                            if (double.TryParse(rowData[6], out double prixAcquisitionValue))
                            {
                                command.Parameters.AddWithValue("prixAcquisition", prixAcquisitionValue);
                            }
                            else
                            {
                                MessageBox.Show("Invalid 'prixAcquisition' value for row: " + string.Join(", ", rowData), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Next4Button_Click(object sender, EventArgs e)
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
            SaveFormData();
            this.Hide();
            Dec_Retrait_7 form5 = new(creationBtnState, ouvrirBtnState);
            form5.ShowDialog();
            this.Close();
        }

        private void UpdateDataInDatabase()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(@"UPDATE Materiel " +
                    "SET refDesignationMat = '" + refDesignationMat1.Text + "', " +
                    "refStatutPatrimonial = '" + refStatutPatrimonial2.Text + "', " +
                    "refEtatAcquision = '" + refEtatAcquision1.Text + "', " +
                    "dateAcquision = '" + dateAcquision1.Text + "', " +
                    "dateMiseEnService = '" + dateMiseEnService1.Text + "', " +
                    " prixAcquisition = '" + prixAcquisition1.Text + "' " +
                    "WHERE IdMateriel = " + IdM, connection);
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
                string query = "SELECT IdMateriel, IdEtablisment, IdPeriode, refDesignationMat, refStatutPatrimonial, refEtatAcquision, dateAcquision, dateMiseEnService, prixAcquisition FROM Materiel WHERE IdEtablisment = @IdEtablisment";
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
        }

        private void Back2Button_Click(object sender, EventArgs e)
        {
            if (creationBtnState)
            {
                InsertDataFromDataGridView();
            }
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT IdTerrain, refNatureAcquision, numTSC, numTF, consistance, superficie, refStatutPatrimonial, prixAcquision, dateAcquisition FROM Terrain";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
#pragma warning disable CS8601
                            string[] rowData = new string[]
                            {
                        reader["IdTerrain"].ToString(),
                        reader["refNatureAcquision"].ToString(),
                        reader["numTSC"].ToString(),
                        reader["numTF"].ToString(),
                        reader["consistance"].ToString(),
                        reader["superficie"].ToString(),
                        reader["refStatutPatrimonial"].ToString(),
                        reader["prixAcquision"].ToString(),
                        ((DateTime)reader["dateAcquisition"]).ToString("yyyy/MM/dd")
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
            Dec_Terrain_5 form3 = new(creationBtnState, ouvrirBtnState);
            form3.ShowDialog();
            this.Close();
        }

        private void PopulateFormData()
        {
            nomPrenom.Text = FormData.nomPrenom;
            identifiantFiscal.Text = FormData.identifiantFiscal;
            numTPLocaleDec.Text = FormData.numTPLocaleDec;
            refDesignationMat1.Text = FormData.refDesignationMat1;
            refEtatAcquision1.Text = FormData.refEtatAcquision1;
            dateAcquision1.Text = FormData.dateAcquision1;
            dateMiseEnService1.Text = FormData.dateMiseEnService1;
            prixAcquisition1.Text = FormData.prixAcquisition1;

        }
        private void SaveFormData()
        {
            FormData.nomPrenom = nomPrenom.Text;
            FormData.identifiantFiscal = identifiantFiscal.Text;
            FormData.numTPLocaleDec = numTPLocaleDec.Text;
            FormData.refDesignationMat1 = refDesignationMat1.Text;
            FormData.refEtatAcquision1 = refEtatAcquision1.Text;
            FormData.dateAcquision1 = dateAcquision1.Text;
            FormData.dateMiseEnService1 = dateMiseEnService1.Text;
            FormData.prixAcquisition1 = prixAcquisition1.Text;
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
                OleDbCommand command = new OleDbCommand(@"Delete From Materiel " +
                    "WHERE IdMateriel = " + IdM, connection);
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

        private void ClearTextBoxes()
        {
            refDesignationMat1.Text = "";
            refStatutPatrimonial2.Text = "";
            refEtatAcquision1.Text = "";
            dateAcquision1.Value = DateTime.Now;
            dateMiseEnService1.Value = DateTime.Now;
            prixAcquisition1.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string refDesignationMat01 = refDesignationMat1.Text;
            string refEtatAcquision01 = refEtatAcquision1.Text;
            string dateAcquision01 = dateAcquision1.Text;
            string dateMiseEnService01 = dateMiseEnService1.Text;
            string prixAcquisition01 = prixAcquisition1.Text;

            string[] rowData = { "", refDesignationMat01, refStatutPatrimonial2.Text, refEtatAcquision01, dateAcquision01, dateMiseEnService01, prixAcquisition01 };

            dataGridView1.Rows.Add(rowData);

            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "";

            dataGridViewData.Add(rowData.Skip(1).ToArray());

            if (selectedRowIndex >= 0)
            {
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
                        command.CommandText = "INSERT INTO Materiel (IdEtablisment, IdPeriode, refDesignationMat, refStatutPatrimonial, refEtatAcquision, dateAcquision, dateMiseEnService, prixAcquisition) " +
                                              "VALUES (@IdEtablisment, @IdPeriode, @refDesignationMat, @refStatutPatrimonial, @refEtatAcquision, @dateAcquision, @dateMiseEnService, @prixAcquisition)";

                        // Set the parameter values
                        command.Parameters.AddWithValue("@IdEtablisment", FormData.IdEtablisment);
                        command.Parameters.AddWithValue("@IdPeriode", FormData.IdPeriode);
                        command.Parameters.AddWithValue("@refDesignationMat", rowData[1]);
                        command.Parameters.AddWithValue("@refStatutPatrimonial", rowData[2]);
                        command.Parameters.AddWithValue("@refEtatAcquision", rowData[3]);
                        command.Parameters.AddWithValue("@dateAcquision", DateTime.Parse(rowData[4]));
                        command.Parameters.AddWithValue("@dateMiseEnService", DateTime.Parse(rowData[5]));
                        command.Parameters.AddWithValue("@prixAcquisition", double.Parse(rowData[6]));

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

        private void Dec_Materiel_6_Load(object sender, EventArgs e)
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
                IdM = Convert.ToInt32(selectedRow.Cells["IdMateriel"].Value.ToString());
                refDesignationMat1.Text = selectedRow.Cells["Column1"].Value.ToString();
                refStatutPatrimonial2.Text = selectedRow.Cells["refStatutPatrimonial"].Value.ToString();
                refEtatAcquision1.Text = selectedRow.Cells["Column2"].Value.ToString();
                dateAcquision1.Text = selectedRow.Cells["Column3"].Value.ToString();
                dateMiseEnService1.Text = selectedRow.Cells["Column4"].Value.ToString();
                prixAcquisition1.Text = selectedRow.Cells["Column5"].Value.ToString();
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

            if (IdM >= 0)
            {
                // If a row is selected, update the row data in the DataGridView and the data list
                string[] rowData = { dataGridViewData[selectedRowIndex][0], refDesignationMat1.Text, refStatutPatrimonial2.Text, refEtatAcquision1.Text, dateAcquision1.Text, dateMiseEnService1.Text, prixAcquisition1.Text };

                // Update the data in the database
                UpdateDataInDatabase();

                // Update the data list
                dataGridViewData[selectedRowIndex] = rowData;

                // Set the updated data in the DataGridView (excluding the IdTerrain column)
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
            ClearTextBoxes();
        }
    }
}