namespace Taxe_PROFESSIONNELLE
{
    public partial class Dec_Fin_9 : Form
    {
        public Dec_Fin_9()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void back5Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dec_Recu_8 form6 = new Dec_Recu_8();
            form6.ShowDialog();
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_3 menu = new();
            menu.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_3 menu = new();
            menu.ShowDialog();
            this.Close();
        }
    }
}
