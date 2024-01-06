namespace Taxe_PROFESSIONNELLE
{
    partial class Dec_Materiel_6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dec_Materiel_6));
            back2Button = new Button();
            next4Button = new Button();
            identifiantFiscal = new TextBox();
            numTPLocaleDec = new TextBox();
            nomPrenom = new TextBox();
            prixAcquisition1 = new TextBox();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            refDesignationMat1 = new ComboBox();
            refEtatAcquision1 = new ComboBox();
            dateAcquision1 = new DateTimePicker();
            dateMiseEnService1 = new DateTimePicker();
            BtnModifier = new Button();
            refStatutPatrimonial2 = new ComboBox();
            IdMateriel = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            refStatutPatrimonial = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // back2Button
            // 
            back2Button.BackColor = Color.CornflowerBlue;
            back2Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            back2Button.ForeColor = Color.Lavender;
            back2Button.Location = new Point(21, 624);
            back2Button.Name = "back2Button";
            back2Button.Size = new Size(106, 46);
            back2Button.TabIndex = 6;
            back2Button.Text = "← Précédent";
            back2Button.UseVisualStyleBackColor = false;
            back2Button.Click += Back2Button_Click;
            // 
            // next4Button
            // 
            next4Button.BackColor = Color.CornflowerBlue;
            next4Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            next4Button.ForeColor = Color.Lavender;
            next4Button.Location = new Point(856, 624);
            next4Button.Name = "next4Button";
            next4Button.Size = new Size(106, 46);
            next4Button.TabIndex = 7;
            next4Button.Text = "Suivant →";
            next4Button.UseVisualStyleBackColor = false;
            next4Button.Click += Next4Button_Click;
            // 
            // identifiantFiscal
            // 
            identifiantFiscal.BackColor = SystemColors.InactiveCaption;
            identifiantFiscal.Location = new Point(230, 71);
            identifiantFiscal.Multiline = true;
            identifiantFiscal.Name = "identifiantFiscal";
            identifiantFiscal.Size = new Size(151, 19);
            identifiantFiscal.TabIndex = 16;
            // 
            // numTPLocaleDec
            // 
            numTPLocaleDec.BackColor = SystemColors.InactiveCaption;
            numTPLocaleDec.Location = new Point(675, 71);
            numTPLocaleDec.Multiline = true;
            numTPLocaleDec.Name = "numTPLocaleDec";
            numTPLocaleDec.Size = new Size(151, 19);
            numTPLocaleDec.TabIndex = 17;
            // 
            // nomPrenom
            // 
            nomPrenom.BackColor = SystemColors.InactiveCaption;
            nomPrenom.Location = new Point(273, 38);
            nomPrenom.Multiline = true;
            nomPrenom.Name = "nomPrenom";
            nomPrenom.Size = new Size(535, 19);
            nomPrenom.TabIndex = 18;
            // 
            // prixAcquisition1
            // 
            prixAcquisition1.BackColor = SystemColors.InactiveCaption;
            prixAcquisition1.Location = new Point(744, 245);
            prixAcquisition1.Multiline = true;
            prixAcquisition1.Name = "prixAcquisition1";
            prixAcquisition1.Size = new Size(172, 34);
            prixAcquisition1.TabIndex = 51;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdMateriel, Column1, refStatutPatrimonial, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(34, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(904, 281);
            dataGridView1.TabIndex = 52;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkCyan;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Lavender;
            btnAdd.Location = new Point(314, 285);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 46);
            btnAdd.TabIndex = 108;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkCyan;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Lavender;
            btnDelete.Location = new Point(566, 285);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 46);
            btnDelete.TabIndex = 109;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // refDesignationMat1
            // 
            refDesignationMat1.BackColor = SystemColors.InactiveCaption;
            refDesignationMat1.FormattingEnabled = true;
            refDesignationMat1.Items.AddRange(new object[] { "MAT_OUTIL_5", "TRANSPORT_6", "MOBILIER_7" });
            refDesignationMat1.Location = new Point(58, 251);
            refDesignationMat1.Name = "refDesignationMat1";
            refDesignationMat1.Size = new Size(115, 23);
            refDesignationMat1.TabIndex = 112;
            // 
            // refEtatAcquision1
            // 
            refEtatAcquision1.BackColor = SystemColors.InactiveCaption;
            refEtatAcquision1.FormattingEnabled = true;
            refEtatAcquision1.Items.AddRange(new object[] { "NEUF_1", "OCCASION_2" });
            refEtatAcquision1.Location = new Point(302, 251);
            refEtatAcquision1.Name = "refEtatAcquision1";
            refEtatAcquision1.Size = new Size(108, 23);
            refEtatAcquision1.TabIndex = 113;
            // 
            // dateAcquision1
            // 
            dateAcquision1.Format = DateTimePickerFormat.Short;
            dateAcquision1.Location = new Point(416, 251);
            dateAcquision1.Name = "dateAcquision1";
            dateAcquision1.Size = new Size(157, 23);
            dateAcquision1.TabIndex = 114;
            // 
            // dateMiseEnService1
            // 
            dateMiseEnService1.Format = DateTimePickerFormat.Short;
            dateMiseEnService1.Location = new Point(582, 251);
            dateMiseEnService1.Name = "dateMiseEnService1";
            dateMiseEnService1.Size = new Size(157, 23);
            dateMiseEnService1.TabIndex = 115;
            // 
            // BtnModifier
            // 
            BtnModifier.BackColor = Color.DarkCyan;
            BtnModifier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnModifier.ForeColor = Color.Lavender;
            BtnModifier.Location = new Point(440, 285);
            BtnModifier.Name = "BtnModifier";
            BtnModifier.Size = new Size(95, 46);
            BtnModifier.TabIndex = 116;
            BtnModifier.Text = "Modifier";
            BtnModifier.UseVisualStyleBackColor = false;
            BtnModifier.Visible = false;
            BtnModifier.Click += BtnModifier_Click;
            // 
            // refStatutPatrimonial2
            // 
            refStatutPatrimonial2.BackColor = SystemColors.InactiveCaption;
            refStatutPatrimonial2.FormattingEnabled = true;
            refStatutPatrimonial2.Items.AddRange(new object[] { "PROPRIETE_1", "LOCATION_2", "LEASING_3" });
            refStatutPatrimonial2.Location = new Point(176, 251);
            refStatutPatrimonial2.Name = "refStatutPatrimonial2";
            refStatutPatrimonial2.Size = new Size(119, 23);
            refStatutPatrimonial2.TabIndex = 117;
            // 
            // IdMateriel
            // 
            IdMateriel.HeaderText = "ID Materiel";
            IdMateriel.Name = "IdMateriel";
            IdMateriel.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Designation et reference";
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // refStatutPatrimonial
            // 
            refStatutPatrimonial.HeaderText = "Statut Patrimonial";
            refStatutPatrimonial.Name = "refStatutPatrimonial";
            refStatutPatrimonial.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Neuf (N) Occasion (O)";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Date d'acquisition";
            Column3.Name = "Column3";
            Column3.Width = 166;
            // 
            // Column4
            // 
            Column4.HeaderText = "Date de mise en service ou d'installation";
            Column4.Name = "Column4";
            Column4.Width = 164;
            // 
            // Column5
            // 
            Column5.HeaderText = "Prix de revient ou montant annuel du bail";
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Dec_Materiel_6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(974, 682);
            Controls.Add(refStatutPatrimonial2);
            Controls.Add(BtnModifier);
            Controls.Add(dateMiseEnService1);
            Controls.Add(dateAcquision1);
            Controls.Add(refEtatAcquision1);
            Controls.Add(refDesignationMat1);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(prixAcquisition1);
            Controls.Add(nomPrenom);
            Controls.Add(numTPLocaleDec);
            Controls.Add(identifiantFiscal);
            Controls.Add(next4Button);
            Controls.Add(back2Button);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dec_Materiel_6";
            Text = "DECLARATION DES ÉLÉMENTS";
            Load += Dec_Materiel_6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back2Button;
        private Button next4Button;
        private TextBox identifiantFiscal;
        private TextBox numTPLocaleDec;
        private TextBox nomPrenom;
        private TextBox prixAcquisition1;
        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private ComboBox refDesignationMat1;
        private ComboBox refEtatAcquision1;
        private DateTimePicker dateAcquision1;
        private DateTimePicker dateMiseEnService1;
        private Button BtnModifier;
        private ComboBox refStatutPatrimonial2;
        private DataGridViewTextBoxColumn IdMateriel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn refStatutPatrimonial;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}