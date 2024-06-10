using FestasInfantis.WinApp.Compartilhado;


namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Endereco
    {
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }

        public Endereco(string cidade, string estado, string rua, string numero, string bairro)
        {
            Cidade = cidade;
            Estado = estado;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
        }
        public List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Cidade?.Trim()))
                erros.Add("O campo \"Cidade\" é obrigatório");
            if (string.IsNullOrEmpty(Estado?.Trim()))
                erros.Add("O campo \"Estado\" é obrigatório");
            if (string.IsNullOrEmpty(Rua?.Trim()))
                erros.Add("O campo \"Rua\" é obrigatório");
            if (string.IsNullOrEmpty(Numero?.Trim()))
                erros.Add("O campo \"Número\" é obrigatório");
            if (string.IsNullOrEmpty(Bairro?.Trim()))
                erros.Add("O campo \"Bairro\" é obrigatório");

            return erros;
        }

    }
    public class Festa : EntidadeBase
    {
        public DateTime Data { get; set; }
        public DateTime Horadeinicio { get; set; }
        public DateTime Horadetermino { get; set; }
        public Endereco Endereco { get; set; }

       
        public Festa() { 
        
        
        
        }
        public Festa(DateTime data, DateTime horadeinicio, DateTime horadetermino, Endereco endereco)
        {
            Data = data;
            Horadeinicio = horadeinicio;
            Horadetermino = horadetermino;
            Endereco = endereco;
        }
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (Endereco == null)
            {
                erros.Add("Prencha todas as informaçoes");
            }
            else
            {
                erros.AddRange(Endereco.Validar());
            }

            if (Horadeinicio == DateTime.MinValue)
                erros.Add("O campo \"Hora de Início\" é obrigatório");

            if (Horadetermino == DateTime.MinValue)
                erros.Add("O campo \"Hora de Término\" é obrigatório");

            if (Data == DateTime.MinValue)
                erros.Add("O campo \"Data\" é obrigatório");

            if (Horadeinicio != DateTime.MinValue && Horadetermino != DateTime.MinValue && Horadetermino <= Horadeinicio)
                erros.Add("A \"Hora de Término\" deve ser posterior à \"Hora de Início\"");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Festa novafesta = (Festa)novoRegistro;

            Endereco = novafesta.Endereco;
            Horadetermino = novafesta.Horadetermino;
            Horadeinicio = novafesta.Horadeinicio;
            Data = novafesta.Data;

        }

        public override string ToString()
        {
            return $"Data {Data} - Hora de inicio: {Horadeinicio} - Hora de termino: {Horadetermino} - Endereço {Endereco}";
        }
    }



}

