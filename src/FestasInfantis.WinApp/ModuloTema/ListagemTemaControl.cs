namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class ListagemTemaControl : UserControl
    {
        public ListagemTemaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            listTemas.Items.Clear();

            foreach (Tema tema in temas)
                listTemas.Items.Add(tema);
        }

        public Tema ObterRegsitroSelecionado()
        {
            if (listTemas.SelectedItem == null)
                return null;

            return (Tema)listTemas.SelectedItem;
        }


    }
}
