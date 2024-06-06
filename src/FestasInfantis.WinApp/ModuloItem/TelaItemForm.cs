using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        private Item item;

        private Item Item
        {
            get
            {
                return item;
            }
            set
            {
                txtId.Text = value.Id.ToString();
                txtDescricaoItem.Text = value.Descricao;
                txtValor.Value = value.Valor;
            }

        }
        public TelaItemForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricaoItem.Text;
            decimal valorItem = txtValor.Value;

            item = new Item(descricao, valorItem);

            List<string> erros = item.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
