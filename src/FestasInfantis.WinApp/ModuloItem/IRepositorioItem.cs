
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloItem
{
    public interface IRepositorioItem
    {
        void Cadastrar(Item novoItem);
        bool Editar(int id, Item itemEditado);
        bool Excluir(int id);
        Item SelecionarPorId(int idSelecionado);
        List<Item> SelecionarTodos();
        List<Item> SelecionarItensDisponiveis();
        List<Item> SelecionarItensDisponiveis(Tema temaSelecionado);
    }
}
