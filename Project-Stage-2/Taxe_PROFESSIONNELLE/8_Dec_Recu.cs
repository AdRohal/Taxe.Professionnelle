namespace Taxe_PROFESSIONNELLE
{
    public partial class Dec_Recu_8 : Form
    {
        private readonly List<string[]> dataGridViewData = new List<string[]>();
#pragma warning disable CS0649
        private readonly bool creationBtnState;
#pragma warning restore CS0649 
#pragma warning disable CS0649
        private readonly bool ouvrirBtnState;
#pragma warning restore CS0649

        public Dec_Recu_8()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            PopulateFormData();
        }
        private void Back4Button_Click(object sender, EventArgs e)
        {
            SaveFormData();

            this.Hide();
            Dec_Retrait_7 form5 = new(creationBtnState, ouvrirBtnState);
            form5.ShowDialog();
            this.Close();
        }
        private void next6Button_Click(object sender, EventArgs e)
        {
            SaveFormData();

            this.Hide();
            Dec_Fin_9 form7 = new();
            form7.ShowDialog();
            this.Close();
        }
        private void PopulateFormData()
        {
            Annee.Text = FormData.Annee;
            nomPrenom.Text = FormData.nomPrenom;
            identifiantFiscal.Text = FormData.identifiantFiscal;
            ICE.Text = FormData.ice;
            numTPLocaleDec.Text = FormData.numTPLocaleDec;
        }
        private void SaveFormData()
        {
            FormData.Annee = Annee.Text;
            FormData.nomPrenom = nomPrenom.Text;
            FormData.identifiantFiscal = identifiantFiscal.Text;
            FormData.ice = ICE.Text;
            FormData.numTPLocaleDec = numTPLocaleDec.Text;
        }
    }
}
