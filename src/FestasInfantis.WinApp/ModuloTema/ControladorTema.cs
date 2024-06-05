using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private TabelaTemaControl listTema;       

        private IRepositorioTema repositorioTema;     
        
        public override string TipoCadastro { get { return "Temas"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo tema"; } }

        public override string ToolTipEditar { get { return "Editar um tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um tema existente"; } }

        public ControladorTema(IRepositorioTema repositorioTema)
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

            int idSelecionado = listTema.ObterRegistroSelecionado();

            Tema temaSelecionado = repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaTema.Tema = temaSelecionado;

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Tema temaEditado = telaTema.Tema;

            repositorioTema.Editar(temaSelecionado.Id, temaEditado);

            CarregarTemas();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{temaEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            TelaTemaForm telaTema = new TelaTemaForm();

            int idSelecionado = listTema.ObterRegistroSelecionado();

            Tema temaSelecionado = repositorioTema.SelecionarPorId(idSelecionado);

            if (temaSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resultado = MessageBox.Show(
                 $"Você deseja realmente excluir o registro \"{temaSelecionado.Nome}\"?",
                 "Confirmar Exclusão",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
             );

            if (resultado != DialogResult.Yes)
                return;

            repositorioTema.Excluir(temaSelecionado.Id);

            CarregarTemas();

            TelaPrincipalForm
              .Instancia
              .AtualizarRodape($"O registro \"{temaSelecionado.Nome}\" foi excluído com sucesso!");
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

            CarregarTemas();

           return listTema;
        }
    }
}
