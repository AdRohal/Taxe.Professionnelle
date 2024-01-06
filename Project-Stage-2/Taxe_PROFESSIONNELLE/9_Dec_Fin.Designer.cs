namespace Taxe_PROFESSIONNELLE
{
    partial class Dec_Fin_9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dec_Fin_9));
            label1 = new Label();
            saveButton = new Button();
            back5Button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(360, 23);
            label1.TabIndex = 0;
            label1.Text = "Merci de remplir les informations";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.DodgerBlue;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = Color.Lavender;
            saveButton.Location = new Point(135, 77);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(125, 60);
            saveButton.TabIndex = 8;
            saveButton.Text = "Terminer ✓";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // back5Button
            // 
            back5Button.BackColor = Color.DodgerBlue;
            back5Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            back5Button.ForeColor = Color.Lavender;
            back5Button.Location = new Point(135, 210);
            back5Button.Name = "back5Button";
            back5Button.Size = new Size(125, 60);
            back5Button.TabIndex = 9;
            back5Button.Text = "← Précédent";
            back5Button.UseVisualStyleBackColor = false;
            back5Button.Click += back5Button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lavender;
            button1.Location = new Point(135, 143);
            button1.Name = "button1";
            button1.Size = new Size(125, 60);
            button1.TabIndex = 10;
            button1.Text = "Fichier EDI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Dec_Fin_9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(395, 290);
            Controls.Add(button1);
            Controls.Add(back5Button);
            Controls.Add(saveButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dec_Fin_9";
            Text = "La Fin!!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button saveButton;
        private Button back5Button;
        private Button button1;
    }
}