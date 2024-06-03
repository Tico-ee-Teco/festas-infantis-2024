using eAgenda.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private TabelaTemaControl listTema;

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
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
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
