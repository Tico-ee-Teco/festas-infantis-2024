using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {        
       
        public Festa Festa
        {
            get
            {
                
                DateTime data = txtData.Value.Date;
                DateTime horadeinicio = txtHorarioInicio.Value;
                DateTime horadetermino = txtHorarioTermino.Value;
                string cidade = txtCidade.Text.Trim();
                string estado = txtEstado.Text.Trim();
                string rua = txtRua.Text.Trim();
                string numero = txtNumero.Text.Trim();
                string bairro = txtBairro.Text.Trim();

                
                Endereco endereco = new Endereco(cidade, estado, rua, numero, bairro);              
                return new Festa(data, horadeinicio, horadetermino, endereco);
            }
            set
            {
                if (value != null)
                {
                   
                    txtData.Value = value.Data;
                    txtHorarioInicio.Value = value.Horadeinicio;
                    txtHorarioTermino.Value = value.Horadetermino;
                    txtCidade.Text = value.Endereco.Cidade;
                    txtEstado.Text = value.Endereco.Estado;
                    txtRua.Text = value.Endereco.Rua;
                    txtNumero.Text = value.Endereco.Numero;
                    txtBairro.Text = value.Endereco.Bairro;
                }
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            Cliente clienteSelecionado = ObterClienteSelecionado();
            Tema temaSelecionado = ObterTemaSelecionado();
            string valorDeEntradaTexto = ObterPorcentagemSelecionada();

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um cliente.");
                return;
            }

            if (temaSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um tema.");
                return;
            }

            if (string.IsNullOrEmpty(valorDeEntradaTexto))
            {
                MessageBox.Show("Por favor, selecione o valor de entrada.");
                return;
            }

            int valorDeEntrada = int.Parse(valorDeEntradaTexto.Replace("%", ""));
            Aluguel aluguel = new Aluguel(clienteSelecionado, valorDeEntrada, temaSelecionado);

            // Continue com o processamento do aluguel
            DialogResult = DialogResult.OK;

        }



        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            //Cliente cliente = ;
            //string telefone = txtTelefonebtn.Text;
            //string Cpf = txtCPFbtn.Text;

            //cliente = new Cliente(nome, telefone, Cpf);

            //List<string> erros = Cliente.Validar();

            //if (erros.Count > 0)
            //{
            //    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
            //    DialogResult = DialogResult.None;
            //}
        }



        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            //Cliente cliente = ;
            //string telefone = txtTelefonebtn.Text;
            //string Cpf = txtCPFbtn.Text;

            //cliente = new Cliente(nome, telefone, Cpf);

            //List<string> erros = Cliente.Validar();

            //if (erros.Count > 0)
            //{
            //    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
            //    DialogResult = DialogResult.None;
            //}
        }


        public TelaAluguelForm()
        {
            InitializeComponent();
        }
        public Cliente ObterClienteSelecionado()
        {
            return cmbCliente.SelectedItem as Cliente;
        }

        public Tema ObterTemaSelecionado()
        {
            return cmbTema.SelectedItem as Tema;
        }

        public string ObterPorcentagemSelecionada()
        {
            return cmbSinal.SelectedItem as string;
        }
        public void CarregarContatos(List<Cliente> clientes, List<Tema> temas)
        {
            cmbCliente.Items.Clear();
            cmbCliente.Items.AddRange(clientes.ToArray());

            cmbTema.Items.Clear();
            cmbTema.Items.AddRange(temas.ToArray());

            for (int i = 25; i <= 100; i += 25)
                cmbSinal.Items.Add($"{i}%");

        }

    }
}
