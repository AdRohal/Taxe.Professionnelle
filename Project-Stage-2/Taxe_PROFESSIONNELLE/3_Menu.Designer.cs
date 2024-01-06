namespace Taxe_PROFESSIONNELLE
{
    partial class Menu_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_3));
            creationBtn = new Button();
            ouvrirBtn = new Button();
            backBtn = new Button();
            label1 = new Label();
            identifiantFiscal = new Label();
            TPE = new Label();
            Annee = new Label();
            identifiantFiscalComboBox = new ComboBox();
            TPEcomboBox = new ComboBox();
            AnneeComboBox = new ComboBox();
            btnEDI = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // creationBtn
            // 
            creationBtn.BackColor = Color.DodgerBlue;
            creationBtn.BackgroundImageLayout = ImageLayout.None;
            creationBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            creationBtn.ForeColor = SystemColors.ButtonHighlight;
            creationBtn.Location = new Point(231, 287);
            creationBtn.Name = "creationBtn";
            creationBtn.Size = new Size(150, 64);
            creationBtn.TabIndex = 0;
            creationBtn.Text = "Creation";
            creationBtn.UseVisualStyleBackColor = false;
            creationBtn.Click += CreationBtn_Click;
            // 
            // ouvrirBtn
            // 
            ouvrirBtn.BackColor = Color.DodgerBlue;
            ouvrirBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ouvrirBtn.ForeColor = SystemColors.ButtonHighlight;
            ouvrirBtn.Location = new Point(420, 287);
            ouvrirBtn.Name = "ouvrirBtn";
            ouvrirBtn.Size = new Size(150, 64);
            ouvrirBtn.TabIndex = 1;
            ouvrirBtn.Text = "Ouvrir";
            ouvrirBtn.UseVisualStyleBackColor = false;
            ouvrirBtn.Click += OuvrirBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.DodgerBlue;
            backBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = SystemColors.ButtonHighlight;
            backBtn.Location = new Point(42, 287);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(150, 64);
            backBtn.TabIndex = 2;
            backBtn.Text = "← Précédent";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += BackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 70);
            label1.TabIndex = 3;
            label1.Text = "MENU";
            // 
            // identifiantFiscal
            // 
            identifiantFiscal.AutoSize = true;
            identifiantFiscal.BackColor = SystemColors.ActiveCaption;
            identifiantFiscal.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            identifiantFiscal.ForeColor = SystemColors.ActiveCaptionText;
            identifiantFiscal.Location = new Point(250, 118);
            identifiantFiscal.Name = "identifiantFiscal";
            identifiantFiscal.Size = new Size(164, 25);
            identifiantFiscal.TabIndex = 4;
            identifiantFiscal.Text = "Identifiant Fiscal :";
            // 
            // TPE
            // 
            TPE.AutoSize = true;
            TPE.BackColor = SystemColors.ActiveCaption;
            TPE.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TPE.Location = new Point(230, 164);
            TPE.Name = "TPE";
            TPE.Size = new Size(184, 25);
            TPE.TabIndex = 5;
            TPE.Text = "N° TP Etablissment :";
            // 
            // Annee
            // 
            Annee.AutoSize = true;
            Annee.BackColor = SystemColors.ActiveCaption;
            Annee.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Annee.Location = new Point(337, 210);
            Annee.Name = "Annee";
            Annee.Size = new Size(77, 25);
            Annee.TabIndex = 6;
            Annee.Text = "Annee :";
            // 
            // identifiantFiscalComboBox
            // 
            identifiantFiscalComboBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            identifiantFiscalComboBox.FormattingEnabled = true;
            identifiantFiscalComboBox.Location = new Point(420, 114);
            identifiantFiscalComboBox.Name = "identifiantFiscalComboBox";
            identifiantFiscalComboBox.Size = new Size(150, 33);
            identifiantFiscalComboBox.TabIndex = 7;
            identifiantFiscalComboBox.SelectedIndexChanged += IdentifiantFiscalComboBox_SelectedIndexChanged;
            // 
            // TPEcomboBox
            // 
            TPEcomboBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TPEcomboBox.FormattingEnabled = true;
            TPEcomboBox.Location = new Point(420, 160);
            TPEcomboBox.Name = "TPEcomboBox";
            TPEcomboBox.Size = new Size(150, 33);
            TPEcomboBox.TabIndex = 8;
            // 
            // AnneeComboBox
            // 
            AnneeComboBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AnneeComboBox.FormattingEnabled = true;
            AnneeComboBox.Location = new Point(420, 206);
            AnneeComboBox.Name = "AnneeComboBox";
            AnneeComboBox.Size = new Size(150, 33);
            AnneeComboBox.TabIndex = 9;
            // 
            // btnEDI
            // 
            btnEDI.BackColor = Color.DodgerBlue;
            btnEDI.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEDI.ForeColor = SystemColors.ButtonHighlight;
            btnEDI.Location = new Point(609, 287);
            btnEDI.Name = "btnEDI";
            btnEDI.Size = new Size(150, 64);
            btnEDI.TabIndex = 10;
            btnEDI.Text = "EDI";
            btnEDI.UseVisualStyleBackColor = false;
            btnEDI.Click += btnEDI_Click;
            // 
            // panel1
            // 
            panel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(218, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 280);
            panel1.TabIndex = 11;
            // 
            // Menu_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.pngkey2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 374);
            Controls.Add(btnEDI);
            Controls.Add(AnneeComboBox);
            Controls.Add(TPEcomboBox);
            Controls.Add(identifiantFiscalComboBox);
            Controls.Add(Annee);
            Controls.Add(TPE);
            Controls.Add(identifiantFiscal);
            Controls.Add(label1);
            Controls.Add(backBtn);
            Controls.Add(ouvrirBtn);
            Controls.Add(creationBtn);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu_3";
            Text = "Menu";
            Load += Menu_3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button creationBtn;
        private Button ouvrirBtn;
        private Button backBtn;
        private Label label1;
        private Label identifiantFiscal;
        private Label TPE;
        private Label Annee;
        private ComboBox identifiantFiscalComboBox;
        private ComboBox TPEcomboBox;
        private ComboBox AnneeComboBox;
        private Button btnEDI;
        private Panel panel1;
    }
}