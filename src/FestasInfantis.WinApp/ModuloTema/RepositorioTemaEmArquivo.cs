

using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class RepositorioTemaEmArquivo : RepositorioBaseEmArquivo<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmArquivo() : base("temas.json")
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
