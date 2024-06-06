namespace FestasInfantis.WinApp.ModuloItem
{
    partial class TelaItemForm
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
            txtId = new TextBox();
            label1 = new Label();
            txtDescricaoItem = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtValor = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)txtValor).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(103, 47);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 3;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 51);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 2;
            label1.Text = "Id:";
            // 
            // txtDescricaoItem
            // 
            txtDescricaoItem.Location = new Point(103, 82);
            txtDescricaoItem.Margin = new Padding(3, 4, 3, 4);
            txtDescricaoItem.Name = "txtDescricaoItem";
            txtDescricaoItem.Size = new Size(322, 27);
            txtDescricaoItem.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 86);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Descricao:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 121);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Valor:";
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(421, 161);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 54);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(321, 161);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 54);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(103, 119);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(87, 27);
            txtValor.TabIndex = 10;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 227);
            Controls.Add(txtValor);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label3);
            Controls.Add(txtDescricaoItem);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Itens";
            ((System.ComponentModel.ISupportInitialize)txtValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private TextBox txtDescricaoItem;
        private Label label2;
        private Label label3;
        private Button btnCancelar;
        private Button btnGravar;
        private NumericUpDown txtValor;
    }
}