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

                int contadorItensSelecionados = 0;

                for(int i = 0; i < chklistItens.Items.Count; i++)
                {
                    Item item = (Item)chklistItens.Items[i];

                    if (value.Itens.Contains(item))
                        chklistItens.SetItemChecked(contadorItensSelecionados, true);

                    contadorItensSelecionados++;
                }
               
            }
        }

        public List<Item> ItensMarcados
        {
            get
            { 
                return chklistItens
                    .Items
                    .Cast<Item>()                    
                    .ToList();
            }
        }

        public List<Item> ItensDesmarcados
        {
            get
            {
                return chklistItens
                    .Items
                    .Cast<Item>()
                    .Except(ItensMarcados)
                    .ToList();
            }
        }
        public TelaTemaForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeTema.Text;            

            tema = new Tema(nome);

            List<string> erros = tema.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }     

        public void CarregarItens(List<Item> itensDisponiveis)
        {
            //chklistItens.Items.Clear();

            foreach (Item item in itensDisponiveis)
            {
                chklistItens.Items.Add(item);

            }
        }

       
    }
}
