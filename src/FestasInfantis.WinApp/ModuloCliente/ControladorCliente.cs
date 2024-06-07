using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        private TabelaClienteControl tabelacliente;
        private List<Cliente> Clientes;
        private IRepositorioCliente repositorioCliente;

        public override string TipoCadastro { get { return "Cliente"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Cliente"; } }

        public override string ToolTipEditar { get { return "Editar um Cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um Cliente existente"; } }

        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override void Adicionar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente novocliente = telaCliente.Cliente;
          

            repositorioCliente.Cadastrar(novocliente);

            CarregarCliente();

            TelaPrincipalForm
               .Instancia
               .AtualizarRodape($"O registro de cliente \"{novocliente.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            int idSelecionado = tabelacliente.ObterRegistroSelecionado();

           Cliente ClienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (ClienteSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaCliente.Cliente = ClienteSelecionado;

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Cliente ClienteEditado = telaCliente.Cliente;

           repositorioCliente.Editar(ClienteSelecionado.Id, ClienteEditado);

            CarregarCliente();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{ClienteEditado.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            TelaClienteForm telaClienteForm = new TelaClienteForm();

            int idSelecionado = tabelacliente.ObterRegistroSelecionado();

            Cliente ClienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (ClienteSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resultado = MessageBox.Show(
                 $"Você deseja realmente excluir o registro \"{ClienteSelecionado.Nome}\"?",
                 "Confirmar Exclusão",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
             );

            if (resultado != DialogResult.Yes)
                return;

            repositorioCliente.Excluir(ClienteSelecionado.Id);

            CarregarCliente();

            TelaPrincipalForm
              .Instancia
              .AtualizarRodape($"O registro \"{ClienteSelecionado.Nome}\" foi excluído com sucesso!");
        }

        private void CarregarCliente()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            tabelacliente.AtualizarRegistros(clientes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelacliente == null)
                tabelacliente = new TabelaClienteControl();

            CarregarCliente();

            return tabelacliente;
        }
    }
}
