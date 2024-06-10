using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {   
            public List<Cliente> Cliente { get; set; }
            public List<Tema> Tema { get; set; }
            public int valorDeEntrada { get; set; }          
            

        public Aluguel(Cliente clienteSelecionado, int valordeentrada, Tema temaselecionado)
        {
             Cliente = new List<Cliente>();
             Tema = new List<Tema>();
             valorDeEntrada = valordeentrada;
               
        }

        public override List<string> Validar()
        {
               List<string> erros = new List<string>();

               if (valorDeEntrada <= 0)
                erros.Add("O campo \"valor De entrada\" é obrigatório");

            return erros;
        }

            public override void AtualizarRegistro(EntidadeBase novoRegistro)
            {
                Aluguel novoaluguel = (Aluguel)novoRegistro;

               Cliente = novoaluguel.Cliente;
               Tema = novoaluguel.Tema;
               valorDeEntrada = novoaluguel.valorDeEntrada;
               
            }

            public override string ToString()
            {
                return $"Cliente {Cliente} - Tema: {Tema} - Valor de entrada: {valorDeEntrada}";
            }
        }
    
}
