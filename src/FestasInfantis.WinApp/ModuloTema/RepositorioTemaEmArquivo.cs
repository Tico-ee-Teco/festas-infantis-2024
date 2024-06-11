﻿using FestasInfantis.WinApp.Compartilhado;
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
       
        protected override List<Tema> ObterRegistros()
        {
            return contexto.Temas;
        }

        public override bool Excluir(int id)
        {
            Tema tema = SelecionarPorId(id);

            // List<Item> itensRelacionados =
            //     contexto.Items.FindAll(i => i.Tema.Id == tema.Id);
            if (tema.Itens.Any())
            {
                foreach (Item i in tema.Itens)
                    i.RemoverTema();
            }

            return base.Excluir(id);
        }

        public void AdicionarItens(Tema novoTema, List<Item> itensMarcados)
        {
            foreach(Item item in itensMarcados)
                novoTema.AdicionarItem(item);

            contexto.Gravar();
        }

        public void AtualizarItens(Tema temaSelecionado, List<Item> itensMarcados, List<Item> itensDesmarcados)
        {
            foreach (Item i in itensDesmarcados)            
                temaSelecionado.RemoverItem(i);

            foreach(Item i in itensMarcados )
                temaSelecionado.AdicionarItem(i);

            contexto.Gravar();            
        }
    }
}
