using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        private Tema tema;
        public Tema Tema
        {
            get
            {
                return tema;
            }
            set
            {
                txtId.Text = value.Id.ToString();
                txtNomeTema.Text = value.Nome;

                chklistItens.Enabled = value.Itens != null;
                chklistItens.SelectedItem = value.Itens;

               
            }
        }
        public TelaTemaForm()
        {
            InitializeComponent();            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeTema.Text;

            Item item = (Item)chklistItens.SelectedItem;


            tema = new Tema(nome, item);

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
        public List<Item> Itens
        {
            get
            {
                return chklistItens.Items.Cast<Item>().ToList();
            }
        }

        public void CarregarItens(List<Item> itensDisponiveis)
        {
            chklistItens.Items.Clear();

            foreach (Item item in itensDisponiveis)
            {
                chklistItens.Items.Add(item);

            }
        }
    }
}
