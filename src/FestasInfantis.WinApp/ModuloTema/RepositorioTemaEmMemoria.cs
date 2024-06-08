using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class RepositorioTemaEmMemoria : RepositorioBaseEmMemoria<Tema>, IRepositorioTema
    {
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
