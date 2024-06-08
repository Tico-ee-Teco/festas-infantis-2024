using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class Cliente : EntidadeBase
    {       
        public string Nome{ get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
       

        public Cliente(string nome, string telefone, string cpf)
        {
            
            Nome = nome; 
            Telefone = telefone; 
            CPF = cpf;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"Nome\" é obrigatório");

            if (string.IsNullOrEmpty(Telefone.Trim()))
                erros.Add("O campo \"Telefone\" é obrigatório");

            if (string.IsNullOrEmpty(CPF.Trim()))
                erros.Add("O campo \"Cpf\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Cliente novocliente = (Cliente)novoRegistro;

            Nome = novocliente.Nome;
            Telefone = novocliente.Telefone;
            CPF = novocliente.CPF;
        }

        public override string ToString()
        {
            return $"Cliente: {Nome} - Telefone: {Telefone} - Cpf: {CPF}";
        }
    }
}
