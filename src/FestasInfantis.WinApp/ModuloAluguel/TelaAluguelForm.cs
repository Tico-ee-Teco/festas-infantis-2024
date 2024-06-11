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
        public void CarregarContatos(List<Cliente> clientes, List<Tema> temas)
        {
            cmbCliente.Items.Clear();

            foreach (Cliente c in clientes)
                cmbCliente.Items.Add(c);

            cmbTema.Items.Clear();

            foreach (Tema c in temas)
                cmbTema.Items.Add(c);

        }

        public TelaAluguelForm()
        {
            InitializeComponent();
        }

        public Aluguel Aluguel
        {
            get
            {
                Cliente clienteSelecionado = (Cliente)cmbCliente.SelectedItem;
                Tema temaSelecionado = (Tema)cmbTema.SelectedItem;


                return Aluguel;

            }
            set
            {





            }

        }
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
}
