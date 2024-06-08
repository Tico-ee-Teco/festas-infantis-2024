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
            btngravar1 = new Button();
            btncancelar1 = new Button();
            txtIDbtn = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNomebtn
            // 
            txtNomebtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomebtn.Location = new Point(27, 173);
            txtNomebtn.Name = "txtNomebtn";
            txtNomebtn.PlaceholderText = "Nome";
            txtNomebtn.Size = new Size(446, 34);
            txtNomebtn.TabIndex = 0;
            txtNomebtn.TextChanged += textBox1_TextChanged;
            // 
            // txtTelefonebtn
            // 
            txtTelefonebtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefonebtn.Location = new Point(27, 231);
            txtTelefonebtn.Name = "txtTelefonebtn";
            txtTelefonebtn.PlaceholderText = "Telefone";
            txtTelefonebtn.Size = new Size(446, 34);
            txtTelefonebtn.TabIndex = 1;
            // 
            // txtCPFbtn
            // 
            txtCPFbtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCPFbtn.Location = new Point(27, 291);
            txtCPFbtn.Name = "txtCPFbtn";
            txtCPFbtn.PlaceholderText = "Cpf";
            txtCPFbtn.Size = new Size(446, 34);
            txtCPFbtn.TabIndex = 2;
            txtCPFbtn.TextChanged += txtCPFbtn_TextChanged;
            // 
            // btngravar1
            // 
            btngravar1.BackColor = Color.Lime;
            btngravar1.BackgroundImageLayout = ImageLayout.Stretch;
            btngravar1.DialogResult = DialogResult.OK;
            btngravar1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btngravar1.ForeColor = SystemColors.ActiveCaptionText;
            btngravar1.Location = new Point(27, 362);
            btngravar1.Name = "btngravar1";
            btngravar1.Size = new Size(214, 61);
            btngravar1.TabIndex = 6;
            btngravar1.Text = "Gravar";
            btngravar1.UseVisualStyleBackColor = false;
            btngravar1.Click += btnGravar_Click;
            // 
            // btncancelar1
            // 
            btncancelar1.BackColor = Color.FromArgb(192, 0, 0);
            btncancelar1.DialogResult = DialogResult.Cancel;
            btncancelar1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancelar1.Location = new Point(259, 362);
            btncancelar1.Name = "btncancelar1";
            btncancelar1.Size = new Size(214, 61);
            btncancelar1.TabIndex = 7;
            btncancelar1.Text = "Cancelar";
            btncancelar1.UseVisualStyleBackColor = false;
            // 
            // txtIDbtn
            // 
            txtIDbtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDbtn.Location = new Point(27, 114);
            txtIDbtn.Name = "txtIDbtn";
            txtIDbtn.PlaceholderText = "Id";
            txtIDbtn.Size = new Size(446, 34);
            txtIDbtn.TabIndex = 8;
            txtIDbtn.TextChanged += txtIDbtn_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(446, 45);
            label1.TabIndex = 9;
            label1.Text = "Adicione os dados do cliente ";
            label1.Click += label1_Click_1;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 469);
            Controls.Add(label1);
            Controls.Add(txtIDbtn);
            Controls.Add(btncancelar1);
            Controls.Add(btngravar1);
            Controls.Add(txtCPFbtn);
            Controls.Add(txtTelefonebtn);
            Controls.Add(txtNomebtn);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
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
        private Button btngravar1;
        private Button btncancelar1;
        private TextBox txtIDbtn;
        private Label label1;
    }
}