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

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {  
        private Cliente cliente;
        public Cliente Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                txtIDbtn.Text = value.Id.ToString();
                txtNomebtn.Text = value.Nome;
                txtTelefonebtn.Text = value.Telefone;
                txtCPFbtn.Text = value.CPF;
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
           
            string nome = txtNomebtn.Text;
            string telefone = txtTelefonebtn.Text;
            string Cpf = txtCPFbtn.Text;

            cliente = new Cliente(nome,telefone,Cpf);

            List<string> erros = Cliente.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }


        public TelaClienteForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TelaClientefiorm_Load(object sender, EventArgs e)
        {

        }
    }
}
