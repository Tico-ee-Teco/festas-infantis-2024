using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public Item() { }      
        public Tema Tema { get; set; }

        public Item(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public bool AtribuirTema(Tema tema)
        {
             if(Tema != null)
                return false;

             Tema = tema;

            return true;

        }

        public bool RemoverTema()
        {
            if (Tema == null)
                return false;

            Tema = null;

            return true;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Descricao.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");
            if (Valor <= 0)
                erros.Add("O campo \"valor\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item item = (Item)novoRegistro;

            Descricao = item.Descricao;
            Valor = item.Valor;
        }

        public override string ToString()
        {
            return $"Item: {Descricao} - Valor: {Valor}";
        }
    }
}
