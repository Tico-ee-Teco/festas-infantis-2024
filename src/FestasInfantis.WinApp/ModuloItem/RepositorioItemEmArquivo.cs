using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class RepositorioItemEmArquivo : RepositorioBaseEmArquivo<Item>, IRepositorioItem
    {
        public RepositorioItemEmArquivo() : base("itens.json")
        {
        }
    }
}
