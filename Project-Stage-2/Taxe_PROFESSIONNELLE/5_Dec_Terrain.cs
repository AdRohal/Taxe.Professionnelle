using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Taxe_PROFESSIONNELLE
{
    public partial class Dec_Terrain_5 : Form
    {
        private readonly bool creationBtnState;
        private readonly bool ouvrirBtnState;

        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/Taxe-Professionnelle.accdb;Persist Security Info=False;";
        private OleDbConnection connection;
        private List<string[]> dataGridViewData = new List<string[]>();
        private bool isUpdateMode = false;
        private int selectedRowIndex = -1;
        private int IdT = 0;


        public Dec_Terrain_5(bool creationBtnState, bool ouvrirBtnState)
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
        private void Back1Button_Click(object sender, EventArgs e)
        {
            SaveFormData();

            this.Hide();
            Dec_Contribuable_4 form2 = new(creationBtnState, ouvrirBtnState);
            form2.ShowDialog();
            this.Close();
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
                            command.CommandText = "INSERT INTO Terrain (IdEtablisment, IdPeriode, refNatureAcquision, numTSC, numTF,  consistance, superficie, refStatutPatrimonial, prixAcquision, dateAcquisition) " +
                                                  "VALUES (@IdEtablisment, @IdPeriode, ?, ?, ?, ?, ?, ?, ?)";

                            command.Parameters.AddWithValue("@IdEtablisment", FormData.IdEtablisment);
                            command.Parameters.AddWithValue("@IdPeriode", FormData.IdPeriode);
                            command.Parameters.AddWithValue("refNatureAcquision", rowData[1]);
                            command.Parameters.AddWithValue("numTSC", rowData[2]);
                            command.Parameters.AddWithValue("numTF", rowData[3]);
                            command.Parameters.AddWithValue("consistance", rowData[4]);

                            if (double.TryParse(rowData[5], out double superficieValue))
                            {
                                command.Parameters.AddWithValue("superficie", superficieValue);
                            }
                            else
                            {
                                MessageBox.Show("Invalid 'superficie' value for row: " + string.Join(", ", rowData), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }

                            command.Parameters.AddWithValue("refStatutPatrimonial", rowData[6]);

                            if (double.TryParse(rowData[7], out double prixAcquisitionValue))
                            {
                                command.Parameters.AddWithValue("prixAcquision", prixAcquisitionValue);
                            }
                            else
                            {
                                MessageBox.Show("Invalid 'prixAcquision' value for row: " + string.Join(", ", rowData), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }

                            if (DateTime.TryParse(rowData[8], out DateTime dateAcquisitionValue))
                            {
                                command.Parameters.AddWithValue("dateAcquisition", dateAcquisitionValue);
                            }
                            else
                            {
                                MessageBox.Show("Invalid 'dateAcquisition' value for row: " + string.Join(", ", rowData), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Next3Button_Click(object sender, EventArgs e)
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
            Dec_Materiel_6 form4 = new(creationBtnState, ouvrirBtnState);
            form4.ShowDialog();
            this.Close();
        }
        private void UpdateDataInDatabase()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(@"UPDATE Terrain " +
                    "SET refNatureAcquision = '" + refNatureAcquision1.Text + "', " +
                    "numTF = '" + numTF.Text + "', " +
                    "consistance = '" + consistance1.Text + "', " +
                    "superficie = '" + superficie1.Text + "', " +
                    " refStatutPatrimonial = '" + refStatutPatrimonial1.Text + "', " +
                    "prixAcquision = '" + prixAcquision1.Text + "', " +
                    "dateAcquisition = '" + DateTime.Parse(dateAcquisition1.Text) + "' " +
                    "WHERE IdTerrain = " + IdT, connection);
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
        private void DeleteDataInDatabase()
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = new OleDbCommand(@"Delete From Terrain " +
                    "WHERE IdTerrain = " + IdT, connection);
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

        private void RetrieveDataFromDatabase()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT IdTerrain, IdEtablisment, IdPeriode, refNatureAcquision, numTSC, numTF,  consistance, superficie, refStatutPatrimonial, prixAcquision, dateAcquisition FROM Terrain WHERE IdEtablisment = @IdEtablisment";
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
        }

        private void PopulateFormData()
        {
            nomPrenom.Text = FormData.nomPrenom;
            identifiantFiscal.Text = FormData.identifiantFiscal;
            numTPLocaleDec.Text = FormData.numTPLocaleDec;
            refNatureAcquision1.Text = FormData.refNatureAcquision1;
            numTF.Text = FormData.estImmatricule1;
            consistance1.Text = FormData.consistance1;
            superficie1.Text = FormData.superficie1;
            refStatutPatrimonial1.Text = FormData.refStatutPatrimonial1;
            prixAcquision1.Text = FormData.prixAcquision1;
            dateAcquisition1.Text = FormData.dateAcquisition1;
        }
        private void SaveFormData()
        {
            FormData.nomPrenom = nomPrenom.Text;
            FormData.identifiantFiscal = identifiantFiscal.Text;
            FormData.numTPLocaleDec = numTPLocaleDec.Text;
            FormData.refNatureAcquision1 = refNatureAcquision1.Text;
            FormData.estImmatricule1 = numTF.Text;
            FormData.consistance1 = consistance1.Text;
            FormData.superficie1 = superficie1.Text;
            FormData.refStatutPatrimonial1 = refStatutPatrimonial1.Text;
            FormData.prixAcquision1 = prixAcquision1.Text;
            FormData.dateAcquisition1 = dateAcquisition1.Text;

            ClearTextBoxes();
        }

        private void Dec_Terrain_5_Load(object sender, EventArgs e)
        {
            if (ouvrirBtnState)
            {
                RetrieveDataFromDatabase();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] rowData = { "", refNatureAcquision1.Text, numTPLocaleDec.Text, numTF.Text, consistance1.Text, superficie1.Text, refStatutPatrimonial1.Text, prixAcquision1.Text, dateAcquisition1.Text };

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
                        command.CommandText = "INSERT INTO Terrain (IdEtablisment, IdPeriode, refNatureAcquision, numTSC, numTF, consistance, superficie, refStatutPatrimonial, prixAcquision, dateAcquisition) " +
                                              "VALUES (@IdEtablisment, @IdPeriode, @refNatureAcquision, @numTSC, numTF, @consistance, @superficie, @refStatutPatrimonial, @prixAcquision, @dateAcquisition)";

                        // Set the parameter values
                        command.Parameters.AddWithValue("@IdEtablisment", FormData.IdEtablisment);
                        command.Parameters.AddWithValue("@IdPeriode", FormData.IdPeriode);
                        command.Parameters.AddWithValue("@refNatureAcquision", rowData[1]);
                        command.Parameters.AddWithValue("@numTSC", rowData[2]);
                        command.Parameters.AddWithValue("@numTF", rowData[3]);
                        command.Parameters.AddWithValue("@consistance", rowData[4]);
                        command.Parameters.AddWithValue("@superficie", rowData[5]);
                        command.Parameters.AddWithValue("@refStatutPatrimonial", rowData[6]);
                        command.Parameters.AddWithValue("@prixAcquision", double.Parse(rowData[7]));
                        command.Parameters.AddWithValue("@dateAcquisition", DateTime.Parse(rowData[8]));

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
        private void ClearTextBoxes()
        {
            refNatureAcquision1.Text = "";
            numTF.Clear();
            consistance1.Clear();
            superficie1.Clear();
            refStatutPatrimonial1.Text = "";
            prixAcquision1.Clear();
            dateAcquisition1.Value = DateTime.Now;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BtnModifier.Visible = true;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Populate the textboxes with data from the selected row
                IdT = Convert.ToInt32(selectedRow.Cells["IdTerrain"].Value.ToString());
                refNatureAcquision1.Text = selectedRow.Cells["ColumnNature"].Value.ToString();
                numTF.Text = selectedRow.Cells["ColumnNdTitreFouR"].Value.ToString();
                consistance1.Text = selectedRow.Cells["ColumnConsistance"].Value.ToString();
                superficie1.Text = selectedRow.Cells["ColumnSuperficie"].Value.ToString();
                refStatutPatrimonial1.Text = selectedRow.Cells["ColumnStatPatrimoDuBien"].Value.ToString();
                prixAcquision1.Text = selectedRow.Cells["ColumnPrixDeRevOuMontaAduBail"].Value.ToString();
                dateAcquisition1.Text = selectedRow.Cells["ColumnDateDacquisition"].Value.ToString();

                // Store the selected row index if needed
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

            if (IdT > 0)
            {
                //If a row is selected, update the row data in the DataGridView and the data list
                string[] rowData = { dataGridViewData[selectedRowIndex][0], refNatureAcquision1.Text, numTF.Text, consistance1.Text, superficie1.Text, refStatutPatrimonial1.Text, prixAcquision1.Text, dateAcquisition1.Text };

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
