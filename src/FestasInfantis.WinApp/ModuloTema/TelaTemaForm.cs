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

            if(erros.Count > 0 ) 
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;   
            }
        }
    }
}
