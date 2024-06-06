namespace FestasInfantis.WinApp.ModuloItem
{
    public partial class ListagemItemControl : UserControl
    {
        public ListagemItemControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Item> itens)
        {
            listItens.Columns.Clear();
            listItens.Rows.Clear();

            // Define as colunas com base nas propriedades do Item
            listItens.Columns.Add("Id", "Id");
            listItens.Columns.Add("Descricao", "Descrição");
            listItens.Columns.Add("Valor", "Valor");


            foreach (Item item in itens)
                listItens.Rows.Add(item.Id, item.Descricao, item.Valor);
        }

        public Item ObterRegsitroSelecionado()
        {
            if (listItens == null)
                return null;

            return (Item)listItens.SelectedRows[0].DataBoundItem;

        }
    }
}
