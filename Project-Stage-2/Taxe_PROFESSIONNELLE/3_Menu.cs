using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using static System.Windows.Forms.LinkLabel;

namespace Taxe_PROFESSIONNELLE
{
    public partial class Menu_3 : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/Taxe-Professionnelle.accdb;Persist Security Info=False;";

        private bool creationBtnState = false;
        private bool ouvrirBtnState = false;
        public Menu_3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreationBtn_Click(object sender, EventArgs e)
        {
            creationBtnState = true;
            ouvrirBtnState = false;
            this.Hide();
            Dec_Contribuable_4 dec_Contribuable = new(creationBtnState, ouvrirBtnState);
            dec_Contribuable.ShowDialog();
            this.Close();
        }

        private void OuvrirBtn_Click(object sender, EventArgs e)
        {
            FormData.identifiantFiscal = identifiantFiscalComboBox.Text;
            FormData.numTPLocaleDec = TPEcomboBox.Text;
            FormData.Annee = AnneeComboBox.Text;
            creationBtnState = false;
            ouvrirBtnState = true;
            this.Hide();
            Dec_Contribuable_4 dec_Contribuable = new(creationBtnState, ouvrirBtnState);
            dec_Contribuable.ShowDialog();
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_1 login = new();
            login.ShowDialog();
            this.Close();
        }

        private void Menu_3_Load(object sender, EventArgs e)
        {
            string queryContribuable = "SELECT identifiantFiscal FROM Contribuable";
            using OleDbConnection connection = new(connectionString);
            try
            {
                connection.Open();

                using (OleDbCommand commandContribuable = new(queryContribuable, connection))
                {
                    OleDbDataReader readerContribuable = commandContribuable.ExecuteReader();
                    while (readerContribuable.Read())
                    {
                        identifiantFiscalComboBox.Items.Add(readerContribuable[0]);
                    }
                    readerContribuable.Close();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Data Retrieval Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IdentifiantFiscalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryEtablissment = "SELECT numTPE FROM Etablisment WHERE IF = " + identifiantFiscalComboBox.Text;
            string queryPeriode = "SELECT Annee FROM Periode WHERE IF = " + identifiantFiscalComboBox.Text;

            using OleDbConnection connection = new(connectionString);
            try
            {
                connection.Open();

                using (OleDbCommand commandEtablissment = new(queryEtablissment, connection))
                {
                    OleDbDataReader readerEtablissment = commandEtablissment.ExecuteReader();
                    TPEcomboBox.Items.Clear();
                    while (readerEtablissment.Read())
                    {
                        TPEcomboBox.Items.Add(readerEtablissment[0]);
                    }
                    readerEtablissment.Close();
                }
                using (OleDbCommand commandPeriode = new(queryPeriode, connection))
                {
                    OleDbDataReader readerPeriode = commandPeriode.ExecuteReader();
                    AnneeComboBox.Items.Clear();
                    while (readerPeriode.Read())
                    {
                        AnneeComboBox.Items.Add(readerPeriode[0]);
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

        private void btnEDI_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/Result/DeclarationTP_" + identifiantFiscalComboBox.Text + "_" + TPEcomboBox.Text + "_" + AnneeComboBox.Text + ".xml";


            int TPE = 0;
            int TSCE = 0;
            string AdresseE = "";
            int IdE = 0;
            int IdP = 0;
            DataTable dtT = new DataTable();
            DataTable dtM = new DataTable();
            DataTable dtR = new DataTable();
            string queryPeriode = "SELECT IdPeriode FROM Periode WHERE Annee = " + AnneeComboBox.Text;
            string queryEtablissment = "SELECT IdEtablisment, numTPE, numTSCE, AdressE FROM Etablisment WHERE IF = " + identifiantFiscalComboBox.Text;

            try
            {
                using OleDbConnection connection = new(connectionString);
                try
                {
                    connection.Open();

                    using (OleDbCommand commandEtablissment = new(queryEtablissment, connection))
                    {
                        OleDbDataReader readerEtablissment = commandEtablissment.ExecuteReader();
                        while (readerEtablissment.Read())
                        {
                            TPE = (int)readerEtablissment["numTPE"];
                            TSCE = (int)readerEtablissment["numTSCE"];
                            AdresseE = (string)readerEtablissment["AdressE"];
                            IdE = (int)readerEtablissment["IdEtablisment"];
                        }
                        readerEtablissment.Close();
                    }
                    using (OleDbCommand commandPeriode = new(queryPeriode, connection))
                    {
                        OleDbDataReader readerPeriode = commandPeriode.ExecuteReader();
                        while (readerPeriode.Read())
                        {
                            IdP = (int)readerPeriode["IdPeriode"];
                        }
                        readerPeriode.Close();
                    }
                    string queryT = "SELECT  refNatureAcquision, numTSC, numTF, consistance, superficie, refStatutPatrimonial, prixAcquision,  FORMAT(dateAcquisition, \"YYYY-MM-DD\") FROM Terrain WHERE IdEtablisment = " + IdE + " AND IdPeriode = " + IdP;
                    string queryM = "SELECT  refDesignationMat, refEtatAcquision, refStatutPatrimonial, FORMAT(dateAcquision, \"YYYY-MM-DD\"), FORMAT(dateMiseEnService, \"YYYY-MM-DD\"), prixAcquisition FROM Materiel WHERE IdEtablisment = " + IdE + " AND IdPeriode = " + IdP;
                    string queryR = "SELECT  designationRetrait, natureOperationRetrait, numTSC, numTF, prixAcquisition, prixCession, FORMAT(dateAcquisition, \"YYYY-MM-DD\"), FORMAT(dateRetrait, \"YYYY-MM-DD\") FROM Retraits WHERE IdEtablisment = " + IdE + " AND IdPeriode = " + IdP;
                    OleDbDataAdapter adapterT = new(queryT, connection);
                        adapterT.Fill(dtT);

                    OleDbDataAdapter adapterM = new(queryM, connection);
                        adapterM.Fill(dtM);

                    OleDbDataAdapter adapterR = new(queryR, connection);
                        adapterR.Fill(dtR);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                using (StreamWriter outputFile = new StreamWriter(path))
                {
                    //BEGENING
                    outputFile.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                    outputFile.WriteLine("<DecElementImposable xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:noNamespaceSchemaLocation=\"DecChomage.xsd\">");
                    outputFile.WriteLine("");
                    outputFile.WriteLine("\t<identifiantFiscal>" + identifiantFiscalComboBox.Text + " </identifiantFiscal>");
                    outputFile.WriteLine("\t<exerciceFiscalDu>" + AnneeComboBox.Text + "-01-01</exerciceFiscalDu>");
                    outputFile.WriteLine("\t<exerciceFiscalAu>" + AnneeComboBox.Text + "-12-31</exerciceFiscalAu>");
                    outputFile.WriteLine("\t<annee>" + AnneeComboBox.Text + "</annee>");
                    outputFile.WriteLine("\t<numTPLocaleDec>" + TPE + "</numTPLocaleDec>");
                    outputFile.WriteLine("\t<numTSCLocaleDec>" + TSCE + "</numTSCLocaleDec>");
                    outputFile.WriteLine("\t<adressLocaleDec>" + AdresseE + "</adressLocaleDec>");
                    //TERRAIN
                    outputFile.WriteLine("");
                    outputFile.WriteLine("\t<listAcquisitionOuLocationTerrain>");
                    foreach (DataRow row in dtT.Rows)
                    {
                        outputFile.WriteLine("\t\t<AcquisitionOuLocationTerrain>");
                        outputFile.WriteLine("\t\t\t<refNatureAcquision>");
                        outputFile.WriteLine("\t\t\t\t\t<code>" + row[0] + "</code>");
                        outputFile.WriteLine("\t\t\t</refNatureAcquision>");
                        if ((string)row[2] == string.Empty)
                        {
                            outputFile.WriteLine("\t\t\t<estImmatricule>" + row[0] + "</estImmatricule>");
                        }
                        outputFile.WriteLine("\t\t\t<numTSC>" + row[1] + "</numTSC>");
                        outputFile.WriteLine("\t\t\t<numTF>" + row[2] + "</numTF>");
                        outputFile.WriteLine("\t\t\t<consistance>" + row[3] + "</consistance>");
                        outputFile.WriteLine("\t\t\t<superficie>" + row[4] + "</superficie>");
                        outputFile.WriteLine("\t\t\t<refStatutPatrimonial>");
                        outputFile.WriteLine("\t\t\t\t\t<code>" + row[5] + "</code>");
                        outputFile.WriteLine("\t\t\t</refStatutPatrimonial>");
                        outputFile.WriteLine("\t\t\t<prixAcquision>" + row[6] + "</prixAcquision>");
                        outputFile.WriteLine("\t\t\t<dateAcquisition>" + row[7] + "</dateAcquisition>");
                        outputFile.WriteLine("\t\t</AcquisitionOuLocationTerrain>");
                    }
                    outputFile.WriteLine("\t</listAcquisitionOuLocationTerrain>");
                    //MATERIEL
                    outputFile.WriteLine("");
                    outputFile.WriteLine("\t<listAcquisitionOuLocationMateriel>");
                    foreach (DataRow row in  dtM.Rows)
                    {
                        outputFile.WriteLine("\t\t<AcquisitionOuLocationMateriel>");
                        outputFile.WriteLine("\t\t\t<refDesignationMat>");
                        outputFile.WriteLine("\t\t\t\t\t<code>" + row[0] + "</code>");
                        outputFile.WriteLine("\t\t\t</refDesignationMat>");
                        outputFile.WriteLine("\t\t\t<refEtatAcquision>");
                        outputFile.WriteLine("\t\t\t\t\t<code>" + row[1] + "</code>");
                        outputFile.WriteLine("\t\t\t</refEtatAcquision>");
                        outputFile.WriteLine("\t\t\t<refStatutPatrimonial>");
                        outputFile.WriteLine("\t\t\t\t\t<code>" + row[2] + "</code>");
                        outputFile.WriteLine("\t\t\t</refStatutPatrimonial>");
                        outputFile.WriteLine("\t\t\t<dateAcquisition>" + row[3] +"</dateAcquisition>");
                        outputFile.WriteLine("\t\t\t<dateMiseEnService>" + row[4] +"</dateMiseEnService>");
                        outputFile.WriteLine("\t\t\t<prixAcquisition>" + row[5] +"</prixAcquisition>");
                        outputFile.WriteLine("\t\t</AcquisitionOuLocationMateriel>");
                    }
                    outputFile.WriteLine("\t</listAcquisitionOuLocationMateriel>");
                    //RETRAIT
                    outputFile.WriteLine("");
                    outputFile.WriteLine("\t<listRetraits>");
                    foreach (DataRow row in dtR.Rows)
                    {
                        outputFile.WriteLine("\t\t<Retraits>");
                        outputFile.WriteLine("\t\t\t<designationRetrait>");
                        outputFile.WriteLine("\t\t\t\t\t<code>" + row[0] +"</code>");
                        outputFile.WriteLine("\t\t\t</designationRetrait>");
                        outputFile.WriteLine("\t\t\t<natureOperationRetrait>");
                        outputFile.WriteLine("\t\t\t\t\t<code>" + row[1] +"</code>");
                        outputFile.WriteLine("\t\t\t</natureOperationRetrait>");
                        outputFile.WriteLine("\t\t\t<numTSC>" + row[2] +"</numTSC>");
                        outputFile.WriteLine("\t\t\t<numTF>" + row[3] +"</numTF>");
                        outputFile.WriteLine("\t\t\t<prixAcquisition>" + row[4] +"</prixAcquisition>");
                        outputFile.WriteLine("\t\t\t<prixCession>" + row[5] +"</prixCession>");
                        outputFile.WriteLine("\t\t\t<dateAcquisition>" + row[6] +"</dateAcquisition>");
                        outputFile.WriteLine("\t\t\t<dateRetrait>" + row[7] +"</dateRetrait>");
                        outputFile.WriteLine("\t\t</Retraits>");
                    }
                    outputFile.WriteLine("\t</listRetraits>");
                    //END
                    outputFile.WriteLine("</DecElementImposable>");

                }
                string zipPath = Application.StartupPath + "/Result/DeclarationTP_" + identifiantFiscalComboBox.Text + "_" + TPEcomboBox.Text + "_" + AnneeComboBox.Text + ".zip";
                if (File.Exists(zipPath))
                {
                    File.Delete(zipPath);
                }
                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Update))
                {
                    archive.CreateEntryFromFile(path, "DeclarationTP_" + identifiantFiscalComboBox.Text + "_" + TPEcomboBox.Text + "_" + AnneeComboBox.Text + ".xml");
                }
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                MessageBox.Show(Application.StartupPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
