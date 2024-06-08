namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            txtNomebtn = new TextBox();
            txtTelefonebtn = new TextBox();
            txtCPFbtn = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btngravar1 = new Button();
            btncancelar1 = new Button();
            txtIDbtn = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNomebtn
            // 
            txtNomebtn.Location = new Point(109, 60);
            txtNomebtn.Name = "txtNomebtn";
            txtNomebtn.Size = new Size(164, 23);
            txtNomebtn.TabIndex = 0;
            txtNomebtn.TextChanged += textBox1_TextChanged;
            // 
            // txtTelefonebtn
            // 
            txtTelefonebtn.Location = new Point(109, 98);
            txtTelefonebtn.Name = "txtTelefonebtn";
            txtTelefonebtn.Size = new Size(164, 23);
            txtTelefonebtn.TabIndex = 1;
            // 
            // txtCPFbtn
            // 
            txtCPFbtn.Location = new Point(109, 138);
            txtCPFbtn.Name = "txtCPFbtn";
            txtCPFbtn.Size = new Size(164, 23);
            txtCPFbtn.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 63);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 101);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 4;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(65, 141);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 5;
            label3.Text = "Cpf";
            // 
            // btngravar1
            // 
            btngravar1.DialogResult = DialogResult.OK;
            btngravar1.Font = new Font("Segoe UI", 11.25F);
            btngravar1.Location = new Point(214, 186);
            btngravar1.Name = "btngravar1";
            btngravar1.Size = new Size(94, 54);
            btngravar1.TabIndex = 6;
            btngravar1.Text = "Gravar";
            btngravar1.UseVisualStyleBackColor = true;
            btngravar1.Click += btnGravar_Click;
            // 
            // btncancelar1
            // 
            btncancelar1.DialogResult = DialogResult.Cancel;
            btncancelar1.Font = new Font("Segoe UI", 11.25F);
            btncancelar1.Location = new Point(338, 187);
            btncancelar1.Name = "btncancelar1";
            btncancelar1.Size = new Size(94, 54);
            btncancelar1.TabIndex = 7;
            btncancelar1.Text = "Cancelar";
            btncancelar1.UseVisualStyleBackColor = true;
            // 
            // txtIDbtn
            // 
            txtIDbtn.Location = new Point(109, 27);
            txtIDbtn.Name = "txtIDbtn";
            txtIDbtn.Size = new Size(164, 23);
            txtIDbtn.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(65, 30);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 9;
            label4.Text = "Id";
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 245);
            Controls.Add(label4);
            Controls.Add(txtIDbtn);
            Controls.Add(btncancelar1);
            Controls.Add(btngravar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCPFbtn);
            Controls.Add(txtTelefonebtn);
            Controls.Add(txtNomebtn);
            Name = "TelaClienteForm";
            Text = "Cadastro de Clientes";
            Load += TelaClientefiorm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomebtn;
        private TextBox txtTelefonebtn;
        private TextBox txtCPFbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btngravar1;
        private Button btncancelar1;
        private TextBox txtIDbtn;
        private Label label4;
    }
}