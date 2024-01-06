namespace Taxe_PROFESSIONNELLE
{
    partial class Dec_Retrait_7
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dec_Retrait_7));
            back3Button = new Button();
            next5Button = new Button();
            nomPrenom = new TextBox();
            identifiantFiscal = new TextBox();
            numTPLocaleDec = new TextBox();
            numTF = new TextBox();
            prixAcquisition01 = new TextBox();
            prixCession1 = new TextBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            designationRetrait = new ComboBox();
            dateRetrait1 = new DateTimePicker();
            dateAcquisition01 = new DateTimePicker();
            natureOperationRetrait = new ComboBox();
            BtnModifier = new Button();
            IdRetraits = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            numTSC = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // back3Button
            // 
            back3Button.BackColor = Color.CornflowerBlue;
            back3Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            back3Button.ForeColor = Color.Lavender;
            back3Button.Location = new Point(24, 624);
            back3Button.Name = "back3Button";
            back3Button.Size = new Size(106, 46);
            back3Button.TabIndex = 7;
            back3Button.Text = "← Précédent";
            back3Button.UseVisualStyleBackColor = false;
            back3Button.Click += Back3Button_Click;
            // 
            // next5Button
            // 
            next5Button.BackColor = Color.CornflowerBlue;
            next5Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            next5Button.ForeColor = Color.Lavender;
            next5Button.Location = new Point(853, 624);
            next5Button.Name = "next5Button";
            next5Button.Size = new Size(106, 46);
            next5Button.TabIndex = 8;
            next5Button.Text = "Suivant →";
            next5Button.UseVisualStyleBackColor = false;
            next5Button.Click += Next5Button_Click;
            // 
            // nomPrenom
            // 
            nomPrenom.BackColor = SystemColors.InactiveCaption;
            nomPrenom.Location = new Point(274, 52);
            nomPrenom.Multiline = true;
            nomPrenom.Name = "nomPrenom";
            nomPrenom.Size = new Size(532, 19);
            nomPrenom.TabIndex = 16;
            // 
            // identifiantFiscal
            // 
            identifiantFiscal.BackColor = SystemColors.InactiveCaption;
            identifiantFiscal.Location = new Point(233, 86);
            identifiantFiscal.Multiline = true;
            identifiantFiscal.Name = "identifiantFiscal";
            identifiantFiscal.Size = new Size(151, 19);
            identifiantFiscal.TabIndex = 17;
            // 
            // numTPLocaleDec
            // 
            numTPLocaleDec.BackColor = SystemColors.InactiveCaption;
            numTPLocaleDec.Location = new Point(673, 86);
            numTPLocaleDec.Multiline = true;
            numTPLocaleDec.Name = "numTPLocaleDec";
            numTPLocaleDec.Size = new Size(151, 19);
            numTPLocaleDec.TabIndex = 18;
            // 
            // numTF
            // 
            numTF.BackColor = SystemColors.InactiveCaption;
            numTF.Location = new Point(279, 289);
            numTF.Multiline = true;
            numTF.Name = "numTF";
            numTF.Size = new Size(112, 28);
            numTF.TabIndex = 29;
            // 
            // prixAcquisition01
            // 
            prixAcquisition01.BackColor = SystemColors.InactiveCaption;
            prixAcquisition01.Location = new Point(641, 289);
            prixAcquisition01.Multiline = true;
            prixAcquisition01.Name = "prixAcquisition01";
            prixAcquisition01.Size = new Size(150, 28);
            prixAcquisition01.TabIndex = 50;
            // 
            // prixCession1
            // 
            prixCession1.BackColor = SystemColors.InactiveCaption;
            prixCession1.Location = new Point(795, 289);
            prixCession1.Multiline = true;
            prixCession1.Name = "prixCession1";
            prixCession1.Size = new Size(141, 28);
            prixCession1.TabIndex = 58;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdRetraits, Column1, Column2, numTSC, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(23, 373);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(923, 245);
            dataGridView1.TabIndex = 59;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkCyan;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Lavender;
            btnAdd.Location = new Point(316, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 46);
            btnAdd.TabIndex = 109;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkCyan;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Lavender;
            btnDelete.Location = new Point(564, 322);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 46);
            btnDelete.TabIndex = 110;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // designationRetrait
            // 
            designationRetrait.BackColor = SystemColors.InactiveCaption;
            designationRetrait.FormattingEnabled = true;
            designationRetrait.Items.AddRange(new object[] { "TERRAIN_1", "CONSTRUCT_2", "AGENCEMENT_3", "AMENAGEMENT_4", "MAT_OUTIL_5", "TRANSPORT_6", "MOBILIER_7" });
            designationRetrait.Location = new Point(57, 291);
            designationRetrait.Name = "designationRetrait";
            designationRetrait.Size = new Size(109, 23);
            designationRetrait.TabIndex = 113;
            // 
            // dateRetrait1
            // 
            dateRetrait1.Format = DateTimePickerFormat.Short;
            dateRetrait1.Location = new Point(393, 291);
            dateRetrait1.Name = "dateRetrait1";
            dateRetrait1.Size = new Size(121, 23);
            dateRetrait1.TabIndex = 115;
            // 
            // dateAcquisition01
            // 
            dateAcquisition01.Format = DateTimePickerFormat.Short;
            dateAcquisition01.Location = new Point(517, 291);
            dateAcquisition01.Name = "dateAcquisition01";
            dateAcquisition01.Size = new Size(121, 23);
            dateAcquisition01.TabIndex = 116;
            // 
            // natureOperationRetrait
            // 
            natureOperationRetrait.BackColor = SystemColors.InactiveCaption;
            natureOperationRetrait.FormattingEnabled = true;
            natureOperationRetrait.Items.AddRange(new object[] { "RETRAIT_1", "CESSION_2", "RESIL_BAIL_3" });
            natureOperationRetrait.Location = new Point(167, 291);
            natureOperationRetrait.Name = "natureOperationRetrait";
            natureOperationRetrait.Size = new Size(110, 23);
            natureOperationRetrait.TabIndex = 117;
            // 
            // BtnModifier
            // 
            BtnModifier.BackColor = Color.DarkCyan;
            BtnModifier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnModifier.ForeColor = Color.Lavender;
            BtnModifier.Location = new Point(440, 321);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(95, 46);
            BtnModifier.TabIndex = 118;
            BtnModifier.Text = "Modifier";
            BtnModifier.UseVisualStyleBackColor = false;
            BtnModifier.Visible = false;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // IdRetraits
            // 
            IdRetraits.HeaderText = "ID Retrait";
            IdRetraits.Name = "IdRetraits";
            IdRetraits.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nature et/ou designation et reference";
            Column1.Name = "Column1";
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nature de l'opération";
            Column2.Name = "Column2";
            Column2.Width = 120;
            // 
            // numTSC
            // 
            numTSC.HeaderText = "numTSC";
            numTSC.Name = "numTSC";
            numTSC.Width = 70;
            // 
            // Column3
            // 
            Column3.HeaderText = "N°du titre foncier / de la requisition";
            Column3.Name = "Column3";
            Column3.Width = 113;
            // 
            // Column4
            // 
            Column4.HeaderText = "Date d'acquisition, d'achevement ou de bail";
            Column4.Name = "Column4";
            Column4.Width = 115;
            // 
            // Column5
            // 
            Column5.HeaderText = "Date de retrait / de cession";
            Column5.Name = "Column5";
            Column5.Width = 115;
            // 
            // Column6
            // 
            Column6.HeaderText = "Prix de revient / montant annuel du bail";
            Column6.Name = "Column6";
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.HeaderText = "Prix de cession / valeur au moment du retrait";
            Column7.Name = "Column7";
            Column7.Width = 120;
            // 
            // Dec_Retrait_7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(972, 682);
            Controls.Add(BtnModifier);
            Controls.Add(natureOperationRetrait);
            Controls.Add(dateAcquisition01);
            Controls.Add(dateRetrait1);
            Controls.Add(designationRetrait);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(prixCession1);
            Controls.Add(prixAcquisition01);
            Controls.Add(numTF);
            Controls.Add(numTPLocaleDec);
            Controls.Add(identifiantFiscal);
            Controls.Add(nomPrenom);
            Controls.Add(next5Button);
            Controls.Add(back3Button);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dec_Retrait_7";
            Text = "DECLARATION DES ÉLÉMENTS";
            Load += Dec_Retrait_7_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back3Button;
        private Button next5Button;
        private TextBox nomPrenom;
        private TextBox identifiantFiscal;
        private TextBox numTPLocaleDec;
        private TextBox numTF;
        private TextBox prixAcquisition01;
        private TextBox prixCession1;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private ComboBox designationRetrait;
        private DateTimePicker dateRetrait1;
        private DateTimePicker dateAcquisition01;
        private ComboBox natureOperationRetrait;
        private Button BtnModifier;
        private DataGridViewTextBoxColumn IdRetraits;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn numTSC;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}