namespace FestasInfantis.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            ClienteMenuItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            TemaMenuItem = new ToolStripMenuItem();
            ItensMenuItem = new ToolStripMenuItem();
            aluguelToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            statusLabelPrincipal = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltro = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnAdicionarItens = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnVisualizarAlugueis = new ToolStripButton();
            btnConcluirAluguel = new ToolStripButton();
            btnConfigurarDescontos = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            pnlRegistros = new Panel();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ClienteMenuItem, contatosMenuItem, TemaMenuItem, ItensMenuItem, aluguelToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(86, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.Click += cadastrosToolStripMenuItem_Click;
            // 
            // ClienteMenuItem
            // 
            ClienteMenuItem.Name = "ClienteMenuItem";
            ClienteMenuItem.Size = new Size(137, 24);
            ClienteMenuItem.Text = "Clientes";
            ClienteMenuItem.Click += ClienteMenuItem_Click;
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(137, 24);
            contatosMenuItem.Text = "Contatos";
            // 
            // TemaMenuItem
            // 
            TemaMenuItem.Name = "TemaMenuItem";
            TemaMenuItem.Size = new Size(137, 24);
            TemaMenuItem.Text = "Temas";
            TemaMenuItem.Click += TemaMenuItem_Click;
            // 
            // ItensMenuItem
            // 
            ItensMenuItem.Name = "ItensMenuItem";
            ItensMenuItem.Size = new Size(137, 24);
            ItensMenuItem.Text = "Itens";
            ItensMenuItem.Click += ItensMenuItem_Click;
            // 
            // aluguelToolStripMenuItem
            // 
            aluguelToolStripMenuItem.Name = "aluguelToolStripMenuItem";
            aluguelToolStripMenuItem.Size = new Size(137, 24);
            aluguelToolStripMenuItem.Text = "Aluguel";
            aluguelToolStripMenuItem.Click += ClienteMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelPrincipal });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 25);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelPrincipal
            // 
            statusLabelPrincipal.Name = "statusLabelPrincipal";
            statusLabelPrincipal.Size = new Size(185, 20);
            statusLabelPrincipal.Text = "Visualizando 0 registro(s)...";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnFiltro, toolStripSeparator3, btnAdicionarItens, toolStripSeparator2, btnVisualizarAlugueis, btnConcluirAluguel, btnConfigurarDescontos, toolStripSeparator4, lblTipoCadastro, toolStripButton1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 41);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = Properties.Resources.btnAdicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(5);
            btnAdicionar.Size = new Size(38, 38);
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = Properties.Resources.btnEditar;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(5);
            btnEditar.Size = new Size(38, 38);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = Properties.Resources.btnExcluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(5);
            btnExcluir.Size = new Size(38, 38);
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 41);
            // 
            // btnFiltro
            // 
            btnFiltro.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltro.Enabled = false;
            btnFiltro.Image = Properties.Resources.btnFiltrar;
            btnFiltro.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltro.ImageTransparentColor = Color.Magenta;
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Padding = new Padding(5);
            btnFiltro.Size = new Size(38, 38);
            btnFiltro.Click += btnDesconto_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 41);
            // 
            // btnAdicionarItens
            // 
            btnAdicionarItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarItens.Enabled = false;
            btnAdicionarItens.Image = Properties.Resources.btnAdicionarItens;
            btnAdicionarItens.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionarItens.ImageTransparentColor = Color.Magenta;
            btnAdicionarItens.Name = "btnAdicionarItens";
            btnAdicionarItens.Padding = new Padding(5);
            btnAdicionarItens.Size = new Size(38, 38);
            btnAdicionarItens.Click += btnAdicionarItens_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 41);
            // 
            // btnVisualizarAlugueis
            // 
            btnVisualizarAlugueis.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizarAlugueis.Enabled = false;
            btnVisualizarAlugueis.Image = Properties.Resources.btnVisualizarAlugueis;
            btnVisualizarAlugueis.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizarAlugueis.ImageTransparentColor = Color.Magenta;
            btnVisualizarAlugueis.Name = "btnVisualizarAlugueis";
            btnVisualizarAlugueis.Padding = new Padding(5);
            btnVisualizarAlugueis.Size = new Size(38, 38);
            // 
            // btnConcluirAluguel
            // 
            btnConcluirAluguel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConcluirAluguel.Enabled = false;
            btnConcluirAluguel.Image = Properties.Resources.btnConcluirAluguel;
            btnConcluirAluguel.ImageScaling = ToolStripItemImageScaling.None;
            btnConcluirAluguel.ImageTransparentColor = Color.Magenta;
            btnConcluirAluguel.Name = "btnConcluirAluguel";
            btnConcluirAluguel.Padding = new Padding(5);
            btnConcluirAluguel.Size = new Size(38, 38);
            // 
            // btnConfigurarDescontos
            // 
            btnConfigurarDescontos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConfigurarDescontos.Enabled = false;
            btnConfigurarDescontos.Image = Properties.Resources.btnConfigurarDescontos;
            btnConfigurarDescontos.ImageScaling = ToolStripItemImageScaling.None;
            btnConfigurarDescontos.ImageTransparentColor = Color.Magenta;
            btnConfigurarDescontos.Name = "btnConfigurarDescontos";
            btnConfigurarDescontos.Padding = new Padding(5);
            btnConfigurarDescontos.Size = new Size(38, 38);
            btnConfigurarDescontos.Click += btnConfigurarDescontos_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 41);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(123, 38);
            lblTipoCadastro.Text = "Tipo de Cadastro";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.tico_e_teco;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 38);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // pnlRegistros
            // 
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 69);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(800, 356);
            pnlRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimizeBox = false;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festas Infantis";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem TemaMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabelPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel pnlRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripButton btnVisualizarAlugueis;
        private ToolStripMenuItem ItensMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnFiltro;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnAdicionarItens;
        private ToolStripButton btnConcluirAluguel;
        private ToolStripButton btnConfigurarDescontos;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem ClienteMenuItem;
        private ToolTip toolTip1;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem aluguelToolStripMenuItem;
    }
}
