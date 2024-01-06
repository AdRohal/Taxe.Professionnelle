namespace Taxe_PROFESSIONNELLE
{
    partial class Dec_Terrain_5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dec_Terrain_5));
            back1Button = new Button();
            next3Button = new Button();
            nomPrenom = new TextBox();
            identifiantFiscal = new TextBox();
            numTPLocaleDec = new TextBox();
            numTF = new TextBox();
            consistance1 = new TextBox();
            superficie1 = new TextBox();
            prixAcquision1 = new TextBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            refNatureAcquision1 = new ComboBox();
            dateAcquisition1 = new DateTimePicker();
            refStatutPatrimonial1 = new ComboBox();
            BtnModifier = new Button();
            IdTerrain = new DataGridViewTextBoxColumn();
            ColumnNature = new DataGridViewTextBoxColumn();
            numTSC = new DataGridViewTextBoxColumn();
            ColumnNdTitreFouR = new DataGridViewTextBoxColumn();
            ColumnConsistance = new DataGridViewTextBoxColumn();
            ColumnSuperficie = new DataGridViewTextBoxColumn();
            ColumnStatPatrimoDuBien = new DataGridViewTextBoxColumn();
            ColumnPrixDeRevOuMontaAduBail = new DataGridViewTextBoxColumn();
            ColumnDateDacquisition = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // back1Button
            // 
            back1Button.BackColor = Color.CornflowerBlue;
            back1Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            back1Button.ForeColor = Color.Lavender;
            back1Button.Location = new Point(12, 624);
            back1Button.Name = "back1Button";
            back1Button.Size = new Size(106, 46);
            back1Button.TabIndex = 5;
            back1Button.Text = "← Précédent";
            back1Button.UseVisualStyleBackColor = false;
            back1Button.Click += Back1Button_Click;
            // 
            // next3Button
            // 
            next3Button.BackColor = Color.CornflowerBlue;
            next3Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            next3Button.ForeColor = Color.Lavender;
            next3Button.Location = new Point(854, 624);
            next3Button.Name = "next3Button";
            next3Button.Size = new Size(106, 46);
            next3Button.TabIndex = 6;
            next3Button.Text = "Suivant →";
            next3Button.UseVisualStyleBackColor = false;
            next3Button.Click += Next3Button_Click;
            // 
            // nomPrenom
            // 
            nomPrenom.BackColor = SystemColors.InactiveCaption;
            nomPrenom.Location = new Point(276, 40);
            nomPrenom.Multiline = true;
            nomPrenom.Name = "nomPrenom";
            nomPrenom.Size = new Size(531, 19);
            nomPrenom.TabIndex = 14;
            // 
            // identifiantFiscal
            // 
            identifiantFiscal.BackColor = SystemColors.InactiveCaption;
            identifiantFiscal.Location = new Point(231, 73);
            identifiantFiscal.Multiline = true;
            identifiantFiscal.Name = "identifiantFiscal";
            identifiantFiscal.Size = new Size(151, 19);
            identifiantFiscal.TabIndex = 15;
            // 
            // numTPLocaleDec
            // 
            numTPLocaleDec.BackColor = SystemColors.InactiveCaption;
            numTPLocaleDec.Location = new Point(675, 71);
            numTPLocaleDec.Multiline = true;
            numTPLocaleDec.Name = "numTPLocaleDec";
            numTPLocaleDec.Size = new Size(146, 19);
            numTPLocaleDec.TabIndex = 16;
            // 
            // numTF
            // 
            numTF.BackColor = SystemColors.InactiveCaption;
            numTF.Location = new Point(125, 261);
            numTF.Multiline = true;
            numTF.Name = "numTF";
            numTF.Size = new Size(127, 36);
            numTF.TabIndex = 71;
            // 
            // consistance1
            // 
            consistance1.BackColor = SystemColors.InactiveCaption;
            consistance1.Location = new Point(257, 261);
            consistance1.Multiline = true;
            consistance1.Name = "consistance1";
            consistance1.Size = new Size(94, 36);
            consistance1.TabIndex = 78;
            // 
            // superficie1
            // 
            superficie1.BackColor = SystemColors.InactiveCaption;
            superficie1.Location = new Point(353, 261);
            superficie1.Multiline = true;
            superficie1.Name = "superficie1";
            superficie1.Size = new Size(100, 36);
            superficie1.TabIndex = 84;
            // 
            // prixAcquision1
            // 
            prixAcquision1.BackColor = SystemColors.InactiveCaption;
            prixAcquision1.Location = new Point(587, 261);
            prixAcquision1.Multiline = true;
            prixAcquision1.Name = "prixAcquision1";
            prixAcquision1.Size = new Size(196, 36);
            prixAcquision1.TabIndex = 98;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdTerrain, ColumnNature, numTSC, ColumnNdTitreFouR, ColumnConsistance, ColumnSuperficie, ColumnStatPatrimoDuBien, ColumnPrixDeRevOuMontaAduBail, ColumnDateDacquisition });
            dataGridView1.Location = new Point(19, 355);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(935, 263);
            dataGridView1.TabIndex = 106;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkCyan;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Lavender;
            btnAdd.Location = new Point(308, 303);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 46);
            btnAdd.TabIndex = 107;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkCyan;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Lavender;
            btnDelete.Location = new Point(572, 303);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 46);
            btnDelete.TabIndex = 108;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // refNatureAcquision1
            // 
            refNatureAcquision1.BackColor = SystemColors.InactiveCaption;
            refNatureAcquision1.FormattingEnabled = true;
            refNatureAcquision1.Items.AddRange(new object[] { "TERRAIN_1", "CONSTRUCT_2", "AGENCEMENT_3", "AMENAGEMENT_4" });
            refNatureAcquision1.Location = new Point(43, 268);
            refNatureAcquision1.Name = "refNatureAcquision1";
            refNatureAcquision1.Size = new Size(76, 23);
            refNatureAcquision1.TabIndex = 109;
            // 
            // dateAcquisition1
            // 
            dateAcquisition1.Format = DateTimePickerFormat.Short;
            dateAcquisition1.Location = new Point(787, 266);
            dateAcquisition1.Name = "dateAcquisition1";
            dateAcquisition1.Size = new Size(145, 23);
            dateAcquisition1.TabIndex = 110;
            // 
            // refStatutPatrimonial1
            // 
            refStatutPatrimonial1.BackColor = SystemColors.InactiveCaption;
            refStatutPatrimonial1.FormattingEnabled = true;
            refStatutPatrimonial1.Items.AddRange(new object[] { "PROPRIETE_1", "LOCATION_2", "LEASING_3" });
            refStatutPatrimonial1.Location = new Point(456, 268);
            refStatutPatrimonial1.Name = "refStatutPatrimonial1";
            refStatutPatrimonial1.Size = new Size(126, 23);
            refStatutPatrimonial1.TabIndex = 111;
            // 
            // BtnModifier
            // 
            BtnModifier.BackColor = Color.DarkCyan;
            BtnModifier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnModifier.ForeColor = Color.Lavender;
            BtnModifier.Location = new Point(440, 303);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(95, 46);
            BtnModifier.TabIndex = 112;
            BtnModifier.Text = "Modifier";
            BtnModifier.UseVisualStyleBackColor = false;
            BtnModifier.Visible = false;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // IdTerrain
            // 
            IdTerrain.FillWeight = 50F;
            IdTerrain.HeaderText = "ID Terrain";
            IdTerrain.Name = "IdTerrain";
            IdTerrain.Visible = false;
            IdTerrain.Width = 70;
            // 
            // ColumnNature
            // 
            ColumnNature.FillWeight = 80F;
            ColumnNature.HeaderText = "Nature";
            ColumnNature.Name = "ColumnNature";
            ColumnNature.Width = 80;
            // 
            // numTSC
            // 
            numTSC.HeaderText = "numTSC";
            numTSC.Name = "numTSC";
            numTSC.Width = 80;
            // 
            // ColumnNdTitreFouR
            // 
            ColumnNdTitreFouR.HeaderText = "N° du titre foncier ou de la requisition";
            ColumnNdTitreFouR.Name = "ColumnNdTitreFouR";
            ColumnNdTitreFouR.Width = 110;
            // 
            // ColumnConsistance
            // 
            ColumnConsistance.FillWeight = 97F;
            ColumnConsistance.HeaderText = "Consistance/ Description";
            ColumnConsistance.Name = "ColumnConsistance";
            ColumnConsistance.Width = 90;
            // 
            // ColumnSuperficie
            // 
            ColumnSuperficie.FillWeight = 90F;
            ColumnSuperficie.HeaderText = "Superficie en metres carres";
            ColumnSuperficie.Name = "ColumnSuperficie";
            // 
            // ColumnStatPatrimoDuBien
            // 
            ColumnStatPatrimoDuBien.FillWeight = 132F;
            ColumnStatPatrimoDuBien.HeaderText = "Statut patrimonial du bien";
            ColumnStatPatrimoDuBien.Name = "ColumnStatPatrimoDuBien";
            ColumnStatPatrimoDuBien.Width = 132;
            // 
            // ColumnPrixDeRevOuMontaAduBail
            // 
            ColumnPrixDeRevOuMontaAduBail.HeaderText = "Prix de revient ou montant annuel du bail";
            ColumnPrixDeRevOuMontaAduBail.Name = "ColumnPrixDeRevOuMontaAduBail";
            ColumnPrixDeRevOuMontaAduBail.Width = 150;
            // 
            // ColumnDateDacquisition
            // 
            ColumnDateDacquisition.FillWeight = 150F;
            ColumnDateDacquisition.HeaderText = "Date d'acquisition, d'achevement ou de location";
            ColumnDateDacquisition.Name = "ColumnDateDacquisition";
            ColumnDateDacquisition.Width = 170;
            // 
            // Dec_Terrain_5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(974, 682);
            Controls.Add(BtnModifier);
            Controls.Add(refStatutPatrimonial1);
            Controls.Add(dateAcquisition1);
            Controls.Add(refNatureAcquision1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(prixAcquision1);
            Controls.Add(superficie1);
            Controls.Add(consistance1);
            Controls.Add(numTF);
            Controls.Add(identifiantFiscal);
            Controls.Add(nomPrenom);
            Controls.Add(next3Button);
            Controls.Add(back1Button);
            Controls.Add(numTPLocaleDec);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dec_Terrain_5";
            Text = "DECLARATION DES ÉLÉMENTS";
            Load += Dec_Terrain_5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back1Button;
        private Button next3Button;
        private TextBox nomPrenom;
        private TextBox identifiantFiscal;
        private TextBox numTPLocaleDec;
        private TextBox numTF;
        private TextBox consistance1;
        private TextBox superficie1;
        private TextBox prixAcquision1;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private ComboBox refNatureAcquision1;
        private DateTimePicker dateAcquisition1;
        private ComboBox refStatutPatrimonial1;
        private Button BtnModifier;
        private DataGridViewTextBoxColumn IdTerrain;
        private DataGridViewTextBoxColumn ColumnNature;
        private DataGridViewTextBoxColumn numTSC;
        private DataGridViewTextBoxColumn ColumnNdTitreFouR;
        private DataGridViewTextBoxColumn ColumnConsistance;
        private DataGridViewTextBoxColumn ColumnSuperficie;
        private DataGridViewTextBoxColumn ColumnStatPatrimoDuBien;
        private DataGridViewTextBoxColumn ColumnPrixDeRevOuMontaAduBail;
        private DataGridViewTextBoxColumn ColumnDateDacquisition;
    }
}