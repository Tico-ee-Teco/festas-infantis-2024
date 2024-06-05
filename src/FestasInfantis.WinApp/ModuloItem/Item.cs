using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal Quantidade { get; set; }
        public Tema Tema { get; set; }

        public Item(string descricao, decimal valor, decimal quantidade, Tema tema)
        {
            Descricao = descricao;
            Valor = valor;
            Quantidade = quantidade;

            Tema = tema;
        }

        public decimal ValorItem()
        {
            decimal valorTotal = Quantidade * Valor;

            return valorTotal;
        }
    }
}
