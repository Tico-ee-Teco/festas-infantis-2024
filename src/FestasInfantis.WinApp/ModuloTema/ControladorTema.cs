using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private TabelaTemaControl listTema;
        private TabelaTemaControl tabelaTema;

        private RepositorioTema repositorioTema;        
        public override string TipoCadastro { get { return "Temas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo tema"; } }

        public override string ToolTipEditar { get { return "Editar um tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um tema existente"; } }

        public ControladorTema(RepositorioTema repositorioTema)
        {
            this.repositorioTema = repositorioTema;
        }

        public override void Adicionar()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema novoTema = telaTema.Tema;

            repositorioTema.Cadastrar(novoTema);

            CarregarTemas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{novoTema.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            //int idSelecionado = tabelaTema.ObterRegistroSelecionado();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();
            listTema.AtualizarRegistros(temas);
        }

        public override UserControl ObterListagem()
        {
           if (listTema == null)
                listTema = new TabelaTemaControl();

           return listTema;
        }
    }
}
