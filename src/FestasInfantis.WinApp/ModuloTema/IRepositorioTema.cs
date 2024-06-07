﻿using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public interface IRepositorioTema
    {
        void Cadastrar(Tema novoTema);
        bool Editar(int id, Tema temaEditado);
        bool Excluir(int id);
        Tema SelecionarPorId(int idSelecionado);
        List<Tema> SelecionarTodos();
        List<Item> ItensMarcados();
        List<Item> ItensLivres();
    }
}
