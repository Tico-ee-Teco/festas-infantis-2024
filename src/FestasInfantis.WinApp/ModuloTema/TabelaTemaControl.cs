
namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Tema> temas)
        {
            listTema.Items.Clear();

            foreach (Tema t in temas)
            {
                ListViewItem item = new ListViewItem(t.Id.ToString())
                {
                    Tag = t,
                };

                item.SubItems.Add(t.Nome);

                listTema.Items.Add(item);
            }

            //ConfigurarColunas();
        }

        //private static void ConfigurarColunas()
        //{
        //    ColumnHeader[] colunas = new ColumnHeader[]
        //    {
        //        new ColumnHeader() {Text = "Id" },
        //        new ColumnHeader() {Text = "Nome"},
        //        new ColumnHeader() {Text = "Valor"},
        //    };

        //    listTema.Columns.AddRange(colunas);
        //}

    }
}
