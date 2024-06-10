namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaTemaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcTemaCadastro = new TabControl();
            tbDadosBasicos = new TabPage();
            txtNomeTema = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            tbSelecionarItens = new TabPage();
            chklistItens = new CheckedListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            tbcTemaCadastro.SuspendLayout();
            tbDadosBasicos.SuspendLayout();
            tbSelecionarItens.SuspendLayout();
            SuspendLayout();
            // 
            // tbcTemaCadastro
            // 
            tbcTemaCadastro.Controls.Add(tbDadosBasicos);
            tbcTemaCadastro.Controls.Add(tbSelecionarItens);
            tbcTemaCadastro.Location = new Point(12, 12);
            tbcTemaCadastro.Name = "tbcTemaCadastro";
            tbcTemaCadastro.SelectedIndex = 0;
            tbcTemaCadastro.Size = new Size(469, 318);
            tbcTemaCadastro.TabIndex = 0;
            // 
            // tbDadosBasicos
            // 
            tbDadosBasicos.Controls.Add(txtNomeTema);
            tbDadosBasicos.Controls.Add(label2);
            tbDadosBasicos.Controls.Add(txtId);
            tbDadosBasicos.Controls.Add(label1);
            tbDadosBasicos.Location = new Point(4, 29);
            tbDadosBasicos.Name = "tbDadosBasicos";
            tbDadosBasicos.Padding = new Padding(3);
            tbDadosBasicos.Size = new Size(461, 285);
            tbDadosBasicos.TabIndex = 0;
            tbDadosBasicos.Text = "Dados Básicos";
            tbDadosBasicos.UseVisualStyleBackColor = true;
            // 
            // txtNomeTema
            // 
            txtNomeTema.Location = new Point(79, 55);
            txtNomeTema.Name = "txtNomeTema";
            txtNomeTema.Size = new Size(282, 27);
            txtNomeTema.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 58);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(79, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 25);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // tbSelecionarItens
            // 
            tbSelecionarItens.Controls.Add(chklistItens);
            tbSelecionarItens.Location = new Point(4, 29);
            tbSelecionarItens.Name = "tbSelecionarItens";
            tbSelecionarItens.Padding = new Padding(3);
            tbSelecionarItens.Size = new Size(461, 285);
            tbSelecionarItens.TabIndex = 1;
            tbSelecionarItens.Text = "Seleção de Itens";
            tbSelecionarItens.UseVisualStyleBackColor = true;
            // 
            // chklistItens
            // 
            chklistItens.Dock = DockStyle.Fill;
            chklistItens.FormattingEnabled = true;
            chklistItens.Location = new Point(3, 3);
            chklistItens.Name = "chklistItens";
            chklistItens.Size = new Size(455, 279);
            chklistItens.TabIndex = 0;
            chklistItens.SelectedIndexChanged += chklistItens_SelectedIndexChanged;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(283, 345);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 54);
            btnGravar.TabIndex = 1;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(383, 345);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 54);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaTemaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 411);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(tbcTemaCadastro);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTemaForm";
            ShowIcon = false;
            Text = "Cadastro de Temas";
            tbcTemaCadastro.ResumeLayout(false);
            tbDadosBasicos.ResumeLayout(false);
            tbDadosBasicos.PerformLayout();
            tbSelecionarItens.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcTemaCadastro;
        private TabPage tbDadosBasicos;
        private TabPage tbSelecionarItens;
        private Button btnGravar;
        private Button btnCancelar;
        private TextBox txtNomeTema;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private CheckedListBox chklistItens;
    }
}