using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class RepositorioTemaEmArquivo : RepositorioBaseEmArquivo<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmArquivo(ContextoDados contexto) : base(contexto)
        {
            if(contexto.Temas.Any())
                contadorId = contexto.Temas.Max(t => t.Id) + 1;
        }

        public List<Item> ItensLivres()
        {
            throw new NotImplementedException();
        }

        public List<Item> ItensMarcados()
        {
            throw new NotImplementedException();
        }

        protected override List<Tema> ObterRegistros()
        {
            return contexto.Temas;
        }

        public override bool Excluir(int id)
        {
            Tema tema = SelecionarPorId(id);

            List<Item> itensRelacionados = 
                contexto.Items.FindAll(i => i.Tema.Id == tema.Id);

            foreach (Item i in itensRelacionados)
                i.Tema = null;

            return base.Excluir(id);
        }      

    }
}
