
namespace Login
{
    partial class CadastraUsuario
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
            btnCadastrarUsuario = new Button();
            label1 = new Label();
            txtEmailCadastro = new TextBox();
            label2 = new Label();
            txtEnderecoCadastro = new TextBox();
            label3 = new Label();
            txtTelefoneCadastro = new TextBox();
            label4 = new Label();
            txtSenhaCadastro = new TextBox();
            label5 = new Label();
            LimparFormulario = new Button();
            txtCpfCadastro = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtNomeCadastro = new TextBox();
            SuspendLayout();
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.Location = new Point(109, 309);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(123, 42);
            btnCadastrarUsuario.TabIndex = 0;
            btnCadastrarUsuario.Text = "Cadatrar";
            btnCadastrarUsuario.UseVisualStyleBackColor = true;
            btnCadastrarUsuario.Click += btnCadastrarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 86);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.Location = new Point(17, 104);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.Size = new Size(215, 23);
            txtEmailCadastro.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 42);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // txtEnderecoCadastro
            // 
            txtEnderecoCadastro.Location = new Point(17, 192);
            txtEnderecoCadastro.Name = "txtEnderecoCadastro";
            txtEnderecoCadastro.Size = new Size(215, 23);
            txtEnderecoCadastro.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 130);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Telefone";
            // 
            // txtTelefoneCadastro
            // 
            txtTelefoneCadastro.Location = new Point(17, 148);
            txtTelefoneCadastro.Name = "txtTelefoneCadastro";
            txtTelefoneCadastro.Size = new Size(215, 23);
            txtTelefoneCadastro.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 174);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 1;
            label4.Text = "Endereço";
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Location = new Point(18, 280);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.Size = new Size(215, 23);
            txtSenhaCadastro.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 262);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 1;
            label5.Text = "Senha";
            label5.Click += label5_Click;
            // 
            // LimparFormulario
            // 
            LimparFormulario.Location = new Point(17, 309);
            LimparFormulario.Name = "LimparFormulario";
            LimparFormulario.Size = new Size(86, 42);
            LimparFormulario.TabIndex = 3;
            LimparFormulario.Text = "Limpar";
            LimparFormulario.UseVisualStyleBackColor = true;
            LimparFormulario.Click += LimparFormulario_Click;
            // 
            // txtCpfCadastro
            // 
            txtCpfCadastro.Location = new Point(17, 236);
            txtCpfCadastro.Name = "txtCpfCadastro";
            txtCpfCadastro.Size = new Size(215, 23);
            txtCpfCadastro.TabIndex = 2;
            txtCpfCadastro.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 218);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 1;
            label6.Text = "CPF";
            label6.Click += Label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(17, 5);
            label7.Name = "label7";
            label7.Size = new Size(139, 37);
            label7.TabIndex = 4;
            label7.Text = "Cadastro:";
            // 
            // txtNomeCadastro
            // 
            txtNomeCadastro.Location = new Point(17, 60);
            txtNomeCadastro.Name = "txtNomeCadastro";
            txtNomeCadastro.Size = new Size(215, 23);
            txtNomeCadastro.TabIndex = 5;
            // 
            // CadastraUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 354);
            Controls.Add(txtNomeCadastro);
            Controls.Add(label7);
            Controls.Add(LimparFormulario);
            Controls.Add(txtTelefoneCadastro);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCpfCadastro);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(txtEnderecoCadastro);
            Controls.Add(label2);
            Controls.Add(txtEmailCadastro);
            Controls.Add(label1);
            Controls.Add(btnCadastrarUsuario);
            Name = "CadastraUsuario";
            Text = "Cadastrar usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnCadastrarUsuario;
        private Label label1;
        private TextBox txtEmailCadastro;
        private Label label2;
        private TextBox txtEnderecoCadastro;
        private Label label3;
        private TextBox txtTelefoneCadastro;
        private Label label4;
        private TextBox txtSenhaCadastro;
        private Label label5;
        private Button LimparFormulario;
        private TextBox txtCpfCadastro;
        private Label label6;
        private Label label7;
        private TextBox txtNomeCadastro;
    }
}
