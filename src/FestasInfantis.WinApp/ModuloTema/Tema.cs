using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Aluguel { get; set; }
        public List<Item> Itens { get; set; }
        public Tema(string nome)
        {
            Nome = nome;

            Itens = new List<Item>();

        }

        public void AdicionarItem(Item item)
        {
            if (!Itens.Exists(i => i.Descricao == item.Descricao))
            {
                Itens.Add(item);
                Valor += item.Valor;
            }
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema novoTema = (Tema)novoRegistro;

            Nome = novoTema.Nome;
            
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }
    }
}
