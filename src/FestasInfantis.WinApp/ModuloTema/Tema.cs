

using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Aluguel { get; set; }
        List<Item> itens;
        public Tema(string nome, decimal valor, bool aluguel)
        {
            Nome = nome;
            Valor = valor;
            Aluguel = aluguel;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
