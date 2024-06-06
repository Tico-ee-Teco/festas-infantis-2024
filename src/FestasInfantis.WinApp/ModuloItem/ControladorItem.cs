using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        private TabelaItemControl tabelaItens;
        private List<Tema> temas;
        private IRepositorioItem repositorioItem;

        public override string TipoCadastro { get { return "Itens"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo item"; } }

        public override string ToolTipEditar { get { return "Editar um item existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um item existente"; } }

        public ControladorItem(IRepositorioItem repositorioItem)
        {
            this.repositorioItem = repositorioItem;
        }

        public override void Adicionar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;
            
            Item novoItem = telaItem.Item;

            //if (temas.Any(t => t.Itens.Any(i => i.Descricao == novoItem.Descricao)))
            //{
            //    MessageBox.Show(
            //        "Este item ja está sendo usado em outro tema.",
            //        "Aviso",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning
            //        );
            //    return;
            //}

            repositorioItem.Cadastrar(novoItem);

            CarregarItens();

            TelaPrincipalForm
               .Instancia
               .AtualizarRodape($"O registro \"{novoItem.Descricao}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            int idSelecionado = tabelaItens.ObterRegistroSelecionado();

            Item itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaItem.Item = itemSelecionado;

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Item itemEditado = telaItem.Item;

            repositorioItem.Editar(itemSelecionado.Id, itemEditado);

            CarregarItens();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{itemEditado.Descricao}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            TelaItemForm telaItem = new TelaItemForm();

            int idSelecionado = tabelaItens.ObterRegistroSelecionado();

            Item itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
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
                 $"Você deseja realmente excluir o registro \"{itemSelecionado.Descricao}\"?",
                 "Confirmar Exclusão",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
             );

            if (resultado != DialogResult.Yes)
                return;

            repositorioItem.Excluir(itemSelecionado.Id);

            CarregarItens();

            TelaPrincipalForm
              .Instancia
              .AtualizarRodape($"O registro \"{itemSelecionado.Descricao}\" foi excluído com sucesso!");
        }

        private void CarregarItens()
        {
            List<Item> itens = repositorioItem.SelecionarTodos();
            tabelaItens.AtualizarRegistros(itens);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItens == null)
                tabelaItens = new TabelaItemControl();

            CarregarItens();

            return tabelaItens;
        }
    }
}
