using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class RepositorioItemEmArquivo : RepositorioBaseEmArquivo<Item>, IRepositorioItem
    {
        public RepositorioItemEmArquivo() : base("itens.json")
        {
        }

        public List<Item> ItensLivres()
        {
            throw new NotImplementedException();
        }

        public List<Item> ItensMarcados()
        {
            throw new NotImplementedException();
        }
    }
}
