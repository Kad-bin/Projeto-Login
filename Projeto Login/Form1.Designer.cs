namespace Projeto_Login
{
    partial class Form1
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
            btnCadatrar = new Button();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            txtNome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // btnCadatrar
            // 
            btnCadatrar.Location = new Point(12, 311);
            btnCadatrar.Name = "btnCadatrar";
            btnCadatrar.Size = new Size(103, 31);
            btnCadatrar.TabIndex = 0;
            btnCadatrar.Text = "Cadastrar";
            btnCadatrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 293);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 1;
            label1.Text = "Caso nao tenha um cadastro:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(153, 37);
            label2.TabIndex = 2;
            label2.Text = "Faça login:";
            label2.Click += label2_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 197);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(15, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(187, 23);
            txtNome.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 106);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(15, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 23);
            txtEmail.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(15, 168);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(187, 23);
            txtSenha.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 354);
            Controls.Add(label5);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadatrar);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadatrar;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private TextBox txtNome;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtSenha;
    }
}
