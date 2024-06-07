namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaDescontoForm
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtPorcentagemAluguel = new NumericUpDown();
            txtPorcentagemDesconto = new NumericUpDown();
            label2 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemAluguel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemDesconto).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPorcentagemDesconto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPorcentagemAluguel);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Porcentagem de Desconto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 0;
            label1.Text = "Porcentagem por Aluguel:";
            // 
            // txtPorcentagemAluguel
            // 
            txtPorcentagemAluguel.Location = new Point(255, 42);
            txtPorcentagemAluguel.Name = "txtPorcentagemAluguel";
            txtPorcentagemAluguel.Size = new Size(84, 27);
            txtPorcentagemAluguel.TabIndex = 1;
            // 
            // txtPorcentagemDesconto
            // 
            txtPorcentagemDesconto.Location = new Point(255, 97);
            txtPorcentagemDesconto.Name = "txtPorcentagemDesconto";
            txtPorcentagemDesconto.Size = new Size(84, 27);
            txtPorcentagemDesconto.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(32, 85);
            label2.Name = "label2";
            label2.Size = new Size(181, 51);
            label2.TabIndex = 2;
            label2.Text = "Máximo de Porcentagem de Desconto:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(312, 305);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 54);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(212, 305);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 54);
            btnGravar.TabIndex = 12;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // TelaDescontoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 371);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaDescontoForm";
            ShowIcon = false;
            Text = "Configuração de Desconto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemAluguel).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentagemDesconto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown txtPorcentagemDesconto;
        private Label label2;
        private NumericUpDown txtPorcentagemAluguel;
        private Button btnCancelar;
        private Button btnGravar;
    }
}