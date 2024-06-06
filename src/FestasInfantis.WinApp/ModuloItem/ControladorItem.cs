using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        private TabelaItemControl tabelaItem;
        private List<Tema> temas;
        private IRepositorioItem repositorioItem;
        public override string TipoCadastro { get { return "Itens"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo item"; } }

        public override string ToolTipEditar { get { return "Editar um item existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um item existente"; } }



        public override void Adicionar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;
            
            Item novoItem = telaItem.Item;

            if (temas.Any(t => t.Itens.Any(i => i.Descricao == novoItem.Descricao)))
            {
                MessageBox.Show(
                    "Este item ja está sendo usado em outro tema.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            repositorioItem.Cadastrar(novoItem);

            TelaPrincipalForm
               .Instancia
               .AtualizarRodape($"O registro \"{novoItem.Descricao}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
