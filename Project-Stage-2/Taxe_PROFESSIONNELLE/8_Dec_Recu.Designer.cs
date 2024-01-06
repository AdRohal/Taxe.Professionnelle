namespace Taxe_PROFESSIONNELLE
{
    partial class Dec_Recu_8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dec_Recu_8));
            back4Button = new Button();
            next6Button = new Button();
            Annee = new TextBox();
            nomPrenom = new TextBox();
            identifiantFiscal = new TextBox();
            ICE = new TextBox();
            numTPLocaleDec = new TextBox();
            SuspendLayout();
            // 
            // back4Button
            // 
            back4Button.BackColor = Color.CornflowerBlue;
            back4Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            back4Button.ForeColor = Color.Lavender;
            back4Button.Location = new Point(32, 806);
            back4Button.Name = "back4Button";
            back4Button.Size = new Size(106, 46);
            back4Button.TabIndex = 8;
            back4Button.Text = "← Précédent";
            back4Button.UseVisualStyleBackColor = false;
            back4Button.Click += Back4Button_Click;
            // 
            // next6Button
            // 
            next6Button.BackColor = Color.CornflowerBlue;
            next6Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            next6Button.ForeColor = Color.Lavender;
            next6Button.Location = new Point(548, 806);
            next6Button.Name = "next6Button";
            next6Button.Size = new Size(106, 46);
            next6Button.TabIndex = 9;
            next6Button.Text = "Suivant →";
            next6Button.UseVisualStyleBackColor = false;
            next6Button.Click += next6Button_Click;
            // 
            // Annee
            // 
            Annee.BackColor = SystemColors.InactiveCaption;
            Annee.Location = new Point(334, 379);
            Annee.Multiline = true;
            Annee.Name = "Annee";
            Annee.Size = new Size(89, 19);
            Annee.TabIndex = 16;
            // 
            // nomPrenom
            // 
            nomPrenom.BackColor = SystemColors.InactiveCaption;
            nomPrenom.Location = new Point(279, 451);
            nomPrenom.Multiline = true;
            nomPrenom.Name = "nomPrenom";
            nomPrenom.Size = new Size(362, 19);
            nomPrenom.TabIndex = 17;
            // 
            // identifiantFiscal
            // 
            identifiantFiscal.BackColor = SystemColors.InactiveCaption;
            identifiantFiscal.Location = new Point(330, 484);
            identifiantFiscal.Multiline = true;
            identifiantFiscal.Name = "identifiantFiscal";
            identifiantFiscal.Size = new Size(151, 19);
            identifiantFiscal.TabIndex = 18;
            // 
            // ICE
            // 
            ICE.BackColor = SystemColors.InactiveCaption;
            ICE.Location = new Point(321, 514);
            ICE.Multiline = true;
            ICE.Name = "ICE";
            ICE.Size = new Size(294, 19);
            ICE.TabIndex = 19;
            // 
            // numTPLocaleDec
            // 
            numTPLocaleDec.BackColor = SystemColors.InactiveCaption;
            numTPLocaleDec.Location = new Point(334, 562);
            numTPLocaleDec.Multiline = true;
            numTPLocaleDec.Name = "numTPLocaleDec";
            numTPLocaleDec.Size = new Size(147, 19);
            numTPLocaleDec.TabIndex = 20;
            // 
            // Dec_Recu_8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_07_17_201246;
            ClientSize = new Size(685, 864);
            Controls.Add(numTPLocaleDec);
            Controls.Add(ICE);
            Controls.Add(identifiantFiscal);
            Controls.Add(nomPrenom);
            Controls.Add(Annee);
            Controls.Add(next6Button);
            Controls.Add(back4Button);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dec_Recu_8";
            Text = "DECLARATION DES ÉLÉMENTS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back4Button;
        private Button next6Button;
        private TextBox Annee;
        private TextBox nomPrenom;
        private TextBox identifiantFiscal;
        private TextBox ICE;
        private TextBox numTPLocaleDec;
    }
}