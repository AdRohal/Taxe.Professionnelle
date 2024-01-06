namespace Taxe_PROFESSIONNELLE
{
    partial class Login_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_1));
            label1 = new Label();
            nextButton = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            UserTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Bauhaus 93", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(43, 25);
            label1.Name = "label1";
            label1.Size = new Size(329, 33);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue chez nous!!";
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.DodgerBlue;
            nextButton.CausesValidation = false;
            nextButton.Cursor = Cursors.Hand;
            nextButton.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            nextButton.ForeColor = Color.Lavender;
            nextButton.Location = new Point(43, 349);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(320, 63);
            nextButton.TabIndex = 2;
            nextButton.Text = "SE CONNECTER";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += NextButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 117, 214);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Lavender;
            button1.Location = new Point(90, 421);
            button1.Name = "button1";
            button1.Size = new Size(221, 63);
            button1.TabIndex = 3;
            button1.Text = "Registration";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Lavender;
            button2.Location = new Point(123, 503);
            button2.Name = "button2";
            button2.Size = new Size(152, 63);
            button2.TabIndex = 4;
            button2.Text = "Fermer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.logo_en;
            pictureBox1.Location = new Point(65, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(43, 285);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Location = new Point(53, 272);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 4);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Location = new Point(53, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 4);
            panel2.TabIndex = 9;
            // 
            // UserTextBox
            // 
            UserTextBox.BackColor = Color.LightSteelBlue;
            UserTextBox.BorderStyle = BorderStyle.None;
            UserTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserTextBox.Location = new Point(90, 242);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(273, 22);
            UserTextBox.TabIndex = 10;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.LightSteelBlue;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(90, 289);
            PasswordTextBox.MaxLength = 20;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(273, 22);
            PasswordTextBox.TabIndex = 11;
            PasswordTextBox.Tag = "";
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.Enter += PasswordTextBox_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(267, 325);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 12;
            label3.Text = "Champs Vides.";
            label3.Click += Label3_Click;
            // 
            // Login_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(405, 578);
            Controls.Add(label3);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(nextButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login_1";
            Text = "TAXE PROFESSIONNELLE";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button nextButton;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private TextBox UserTextBox;
        private TextBox PasswordTextBox;
        private Label label3;
    }
}