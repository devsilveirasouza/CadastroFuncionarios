namespace CadastroFuncionarios
{
    partial class FormularioPrincipal
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
            lblNome = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            lblEndereco = new Label();
            txtbNome = new TextBox();
            txtbEmail = new TextBox();
            txtbCpf = new TextBox();
            txtbEndereco = new TextBox();
            btnSalvar = new Button();
            lblIdFuncionario = new Label();
            btnPesquisar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(48, 95);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(46, 154);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCpf.Location = new Point(48, 207);
            lblCpf.Margin = new Padding(4, 0, 4, 0);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(40, 21);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndereco.Location = new Point(46, 266);
            lblEndereco.Margin = new Padding(4, 0, 4, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(77, 21);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // txtbNome
            // 
            txtbNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbNome.Location = new Point(225, 84);
            txtbNome.Margin = new Padding(4);
            txtbNome.Name = "txtbNome";
            txtbNome.Size = new Size(388, 29);
            txtbNome.TabIndex = 1;
            // 
            // txtbEmail
            // 
            txtbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbEmail.Location = new Point(225, 143);
            txtbEmail.Margin = new Padding(4);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(388, 29);
            txtbEmail.TabIndex = 2;
            // 
            // txtbCpf
            // 
            txtbCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbCpf.Location = new Point(225, 196);
            txtbCpf.Margin = new Padding(4);
            txtbCpf.Name = "txtbCpf";
            txtbCpf.Size = new Size(388, 29);
            txtbCpf.TabIndex = 3;
            // 
            // txtbEndereco
            // 
            txtbEndereco.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbEndereco.Location = new Point(225, 255);
            txtbEndereco.Margin = new Padding(4);
            txtbEndereco.Name = "txtbEndereco";
            txtbEndereco.Size = new Size(388, 29);
            txtbEndereco.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(225, 326);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 60);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Cadastrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblIdFuncionario
            // 
            lblIdFuncionario.AutoSize = true;
            lblIdFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdFuncionario.Location = new Point(54, 24);
            lblIdFuncionario.Margin = new Padding(4, 0, 4, 0);
            lblIdFuncionario.Name = "lblIdFuncionario";
            lblIdFuncionario.Size = new Size(109, 21);
            lblIdFuncionario.TabIndex = 9;
            lblIdFuncionario.Text = "Id Funcionario";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesquisar.Location = new Point(335, 326);
            btnPesquisar.Margin = new Padding(4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(85, 60);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(528, 19);
            btnLimpar.Margin = new Padding(4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(85, 31);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FormularioPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 417);
            Controls.Add(btnLimpar);
            Controls.Add(btnPesquisar);
            Controls.Add(lblIdFuncionario);
            Controls.Add(btnSalvar);
            Controls.Add(txtbEndereco);
            Controls.Add(txtbCpf);
            Controls.Add(txtbEmail);
            Controls.Add(txtbNome);
            Controls.Add(lblEndereco);
            Controls.Add(lblCpf);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormularioPrincipal";
            Text = "CADASTRO DE FUNCIONÁRIOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblEndereco;
        private TextBox txtbNome;
        private TextBox txtbEmail;
        private TextBox txtbCpf;
        private TextBox txtbEndereco;
        private Button btnSalvar;
        private Label lblIdFuncionario;
        private Button btnPesquisar;
        private Button btnLimpar;
    }
}
