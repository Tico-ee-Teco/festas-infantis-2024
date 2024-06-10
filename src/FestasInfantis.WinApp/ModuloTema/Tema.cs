using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();
        public decimal Valor
        {
            get
            {
                decimal total = 0;

                foreach (Item item in Itens)
                {
                    total += item.Valor;
                }

                return total;
            } 
        }
        public bool Aluguel { get; set; }        

        public Tema()
        {
            
        }
        public Tema(string nome) 
        {
            Nome = nome;           
        }

        public bool AdicionarItem(Item item)
        {
            if (Itens.Contains(item))
                return false;

            Itens.Add(item);

            item.AtribuirTema(this);

            return true;
        }   
        
        public bool RemoverItem(Item item)
        {
            if(!Itens.Contains(item))
                return false;

            Itens.Remove(item);

            item.RemoverTema();

            return true;
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
