namespace Taxe_PROFESSIONNELLE
{
    partial class Dec_Registration_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dec_Registration_2));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            UserTextBox = new TextBox();
            panel2 = new Panel();
            PasswordTextBox = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            backButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.logo_en;
            pictureBox1.Location = new Point(65, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(43, 285);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Location = new Point(53, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 4);
            panel1.TabIndex = 9;
            // 
            // UserTextBox
            // 
            UserTextBox.BackColor = Color.LightSteelBlue;
            UserTextBox.BorderStyle = BorderStyle.None;
            UserTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserTextBox.Location = new Point(90, 242);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(274, 22);
            UserTextBox.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Location = new Point(53, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 4);
            panel2.TabIndex = 12;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.LightSteelBlue;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(90, 289);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(274, 22);
            PasswordTextBox.TabIndex = 13;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Lavender;
            button1.Location = new Point(43, 349);
            button1.Name = "button1";
            button1.Size = new Size(320, 63);
            button1.TabIndex = 14;
            button1.Text = "Registration";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(267, 327);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 15;
            label3.Text = "Champs Vides !";
            label3.Click += Label3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Bauhaus 93", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(369, 28);
            label1.TabIndex = 16;
            label1.Text = "S'il vous plaît enregistrernous!!";
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(0, 117, 214);
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = Color.Lavender;
            backButton.Location = new Point(111, 468);
            backButton.Name = "backButton";
            backButton.Size = new Size(184, 64);
            backButton.TabIndex = 17;
            backButton.Text = "← Précédent";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += BackButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(114, 417);
            label2.Name = "label2";
            label2.Size = new Size(177, 17);
            label2.TabIndex = 18;
            label2.Text = "vous avez déjà un compte ?";
            label2.Click += Label2_Click;
            // 
            // Dec_Registration_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(405, 578);
            Controls.Add(label2);
            Controls.Add(backButton);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(PasswordTextBox);
            Controls.Add(panel2);
            Controls.Add(UserTextBox);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dec_Registration_2";
            Text = "Dec_Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private TextBox UserTextBox;
        private Panel panel2;
        private TextBox PasswordTextBox;
        private Button button1;
        private Label label3;
        private Label label1;
        private Button backButton;
        private Label label2;
    }
}