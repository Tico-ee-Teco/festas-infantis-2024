namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            tbDadosAluguel = new TabControl();
            tbDadosFesta = new TabPage();
            groupBox2 = new GroupBox();
            txtNumero = new TextBox();
            label8 = new Label();
            txtBairro = new TextBox();
            label9 = new Label();
            txtRua = new TextBox();
            label7 = new Label();
            txtEstado = new TextBox();
            label6 = new Label();
            txtCidade = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtHorarioTermino = new DateTimePicker();
            label3 = new Label();
            txtHorarioInicio = new DateTimePicker();
            label2 = new Label();
            txtData = new DateTimePicker();
            tabPage2 = new TabPage();
            groupBox3 = new GroupBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            txtDescontoTema = new TextBox();
            label16 = new Label();
            txtValorPendente = new TextBox();
            label17 = new Label();
            txtValorTema = new TextBox();
            label15 = new Label();
            txtValorsinal = new TextBox();
            label14 = new Label();
            txtPercentualDesconto = new TextBox();
            label13 = new Label();
            label12 = new Label();
            cmbTema = new ComboBox();
            label11 = new Label();
            cmbCliente = new ComboBox();
            label10 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            cmbSinal = new ComboBox();
            tbDadosAluguel.SuspendLayout();
            tbDadosFesta.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbDadosAluguel
            // 
            tbDadosAluguel.Controls.Add(tbDadosFesta);
            tbDadosAluguel.Controls.Add(tabPage2);
            tbDadosAluguel.Location = new Point(24, 81);
            tbDadosAluguel.Name = "tbDadosAluguel";
            tbDadosAluguel.SelectedIndex = 0;
            tbDadosAluguel.Size = new Size(676, 381);
            tbDadosAluguel.TabIndex = 0;
            // 
            // tbDadosFesta
            // 
            tbDadosFesta.Controls.Add(groupBox2);
            tbDadosFesta.Controls.Add(groupBox1);
            tbDadosFesta.Location = new Point(4, 29);
            tbDadosFesta.Name = "tbDadosFesta";
            tbDadosFesta.Padding = new Padding(3);
            tbDadosFesta.Size = new Size(668, 348);
            tbDadosFesta.TabIndex = 0;
            tbDadosFesta.Text = "Dados da Festa";
            tbDadosFesta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtRua);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtEstado);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(21, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(628, 161);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Endereço";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(449, 93);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(140, 27);
            txtNumero.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(377, 96);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 8;
            label8.Text = "Número:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(95, 93);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(228, 27);
            txtBairro.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 96);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 6;
            label9.Text = "Bairro:";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(95, 60);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(494, 27);
            txtRua.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 63);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 4;
            label7.Text = "Rua:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(449, 27);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(140, 27);
            txtEstado.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(384, 30);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 2;
            label6.Text = "Estado:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(95, 27);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(228, 27);
            txtCidade.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 30);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 0;
            label5.Text = "Cidade:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHorarioTermino);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtHorarioInicio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtData);
            groupBox1.Location = new Point(21, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(628, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data e Hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 5;
            label4.Text = "Horário de Termino: ";
            // 
            // txtHorarioTermino
            // 
            txtHorarioTermino.CustomFormat = "HH:mm";
            txtHorarioTermino.Format = DateTimePickerFormat.Custom;
            txtHorarioTermino.Location = new Point(156, 94);
            txtHorarioTermino.Name = "txtHorarioTermino";
            txtHorarioTermino.Size = new Size(135, 27);
            txtHorarioTermino.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 66);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 3;
            label3.Text = "Horário de Início: ";
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.CustomFormat = "HH:mm";
            txtHorarioInicio.Format = DateTimePickerFormat.Custom;
            txtHorarioInicio.Location = new Point(156, 61);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.Size = new Size(135, 27);
            txtHorarioInicio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 31);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Data da Festa: ";
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Custom;
            txtData.Location = new Point(156, 26);
            txtData.Name = "txtData";
            txtData.Size = new Size(135, 27);
            txtData.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(cmbSinal);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(cmbTema);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(cmbCliente);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(668, 348);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dados do Alguel";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(toolStrip1);
            groupBox3.Controls.Add(txtDescontoTema);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(txtValorPendente);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(txtValorTema);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(txtValorsinal);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtPercentualDesconto);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(21, 90);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(631, 240);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dados de Pagamento";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(3, 23);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(625, 42);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new Padding(10);
            toolStripButton1.Size = new Size(74, 39);
            toolStripButton1.Text = "Calcular";
            // 
            // txtDescontoTema
            // 
            txtDescontoTema.Location = new Point(457, 144);
            txtDescontoTema.Name = "txtDescontoTema";
            txtDescontoTema.Size = new Size(100, 27);
            txtDescontoTema.TabIndex = 9;
            // 
            // label16
            // 
            label16.ImageAlign = ContentAlignment.TopLeft;
            label16.Location = new Point(342, 134);
            label16.Name = "label16";
            label16.Size = new Size(109, 41);
            label16.TabIndex = 8;
            label16.Text = "Valor do Tema com desconto:";
            // 
            // txtValorPendente
            // 
            txtValorPendente.Location = new Point(457, 177);
            txtValorPendente.Name = "txtValorPendente";
            txtValorPendente.Size = new Size(100, 27);
            txtValorPendente.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(342, 180);
            label17.Name = "label17";
            label17.Size = new Size(111, 20);
            label17.TabIndex = 6;
            label17.Text = "Valor Pendente:";
            // 
            // txtValorTema
            // 
            txtValorTema.Location = new Point(139, 148);
            txtValorTema.Name = "txtValorTema";
            txtValorTema.Size = new Size(100, 27);
            txtValorTema.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 151);
            label15.Name = "label15";
            label15.Size = new Size(108, 20);
            label15.TabIndex = 4;
            label15.Text = "Valor do Tema:";
            // 
            // txtValorsinal
            // 
            txtValorsinal.Location = new Point(139, 181);
            txtValorsinal.Name = "txtValorsinal";
            txtValorsinal.Size = new Size(100, 27);
            txtValorsinal.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 184);
            label14.Name = "label14";
            label14.Size = new Size(104, 20);
            label14.TabIndex = 2;
            label14.Text = "Valor do Sinal:";
            // 
            // txtPercentualDesconto
            // 
            txtPercentualDesconto.Enabled = false;
            txtPercentualDesconto.Location = new Point(139, 115);
            txtPercentualDesconto.Name = "txtPercentualDesconto";
            txtPercentualDesconto.PlaceholderText = "0";
            txtPercentualDesconto.Size = new Size(100, 27);
            txtPercentualDesconto.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 118);
            label13.Name = "label13";
            label13.Size = new Size(112, 20);
            label13.TabIndex = 0;
            label13.Text = "% de Desconto:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 59);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 4;
            label12.Text = "Sinal:";
            // 
            // cmbTema
            // 
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(425, 13);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(181, 28);
            cmbTema.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(371, 16);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 2;
            label11.Text = "Tema:";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(85, 13);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(181, 28);
            cmbCliente.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 16);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 0;
            label10.Text = "Cliente:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(49, 31);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 5;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 4;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(606, 520);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 54);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(506, 520);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 54);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // cmbSinal
            // 
            cmbSinal.FormattingEnabled = true;
            cmbSinal.Location = new Point(85, 56);
            cmbSinal.Name = "cmbSinal";
            cmbSinal.Size = new Size(181, 28);
            cmbSinal.TabIndex = 5;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 586);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(tbDadosAluguel);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            ShowIcon = false;
            Text = "Cadastro de Aluguéis";
            tbDadosAluguel.ResumeLayout(false);
            tbDadosFesta.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbDadosAluguel;
        private TabPage tbDadosFesta;
        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private DateTimePicker txtHorarioTermino;
        private Label label3;
        private DateTimePicker txtHorarioInicio;
        private Label label2;
        private DateTimePicker txtData;
        private TextBox txtNumero;
        private Label label8;
        private TextBox txtBairro;
        private Label label9;
        private TextBox txtRua;
        private Label label7;
        private TextBox txtCidade;
        private Label label5;
        private ComboBox cmbTema;
        private Label label11;
        private ComboBox cmbCliente;
        private Label label10;
        private Label label12;
        private GroupBox groupBox3;
        private Label label13;
        private TextBox txtDescontoTema;
        private Label label16;
        private TextBox txtValorPendente;
        private Label label17;
        private TextBox txtValorTema;
        private Label label15;
        private TextBox txtValorsinal;
        private Label label14;
        private TextBox txtPercentualDesconto;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private TextBox txtEstado;
        private Label label6;
        private ComboBox cmbSinal;
    }
}