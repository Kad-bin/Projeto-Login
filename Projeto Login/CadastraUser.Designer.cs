namespace Projeto_Login
{
    partial class CadastraUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastraUser));
            btnCadastrarUsuario = new Button();
            pictureBox1 = new PictureBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtConfirmarSenha = new TextBox();
            label6 = new Label();
            txtSenha = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnLimparFormulario = new Button();
            pictureBox2 = new PictureBox();
            maskedTxtTelefone = new MaskedTextBox();
            maskedCpf = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.BackgroundImage = (Image)resources.GetObject("btnCadastrarUsuario.BackgroundImage");
            btnCadastrarUsuario.Location = new Point(360, 96);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(74, 76);
            btnCadastrarUsuario.TabIndex = 0;
            btnCadastrarUsuario.UseVisualStyleBackColor = true;
            btnCadastrarUsuario.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-34, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 97);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 96);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(342, 23);
            txtNome.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 47);
            label1.TabIndex = 3;
            label1.Text = "Cadastro de Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome completo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 131);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 221);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 10;
            label5.Text = "Confirmar Senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(211, 239);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(143, 23);
            txtConfirmarSenha.TabIndex = 9;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 221);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 12;
            label6.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 239);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(143, 23);
            txtSenha.TabIndex = 11;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 177);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 15;
            label7.Text = "Telefone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 177);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 16;
            label8.Text = "CPF";
            // 
            // btnLimparFormulario
            // 
            btnLimparFormulario.BackgroundImage = Properties.Resources.floppy_disk_circle_xmark;
            btnLimparFormulario.Location = new Point(361, 186);
            btnLimparFormulario.Name = "btnLimparFormulario";
            btnLimparFormulario.Size = new Size(73, 76);
            btnLimparFormulario.TabIndex = 17;
            btnLimparFormulario.UseVisualStyleBackColor = true;
            btnLimparFormulario.Click += btnLimparFormulario_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.arrow_right;
            pictureBox2.Location = new Point(147, 212);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // maskedTxtTelefone
            // 
            maskedTxtTelefone.Location = new Point(12, 195);
            maskedTxtTelefone.Mask = "(00) 00000-0000";
            maskedTxtTelefone.Name = "maskedTxtTelefone";
            maskedTxtTelefone.Size = new Size(100, 23);
            maskedTxtTelefone.TabIndex = 19;
            maskedTxtTelefone.MaskInputRejected += maskedTxtTelefone_MaskInputRejected;
            // 
            // maskedCpf
            // 
            maskedCpf.Location = new Point(207, 195);
            maskedCpf.Mask = "000.000.000-00";
            maskedCpf.Name = "maskedCpf";
            maskedCpf.Size = new Size(100, 23);
            maskedCpf.TabIndex = 20;
            // 
            // CadastraUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 287);
            Controls.Add(maskedCpf);
            Controls.Add(maskedTxtTelefone);
            Controls.Add(btnLimparFormulario);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtSenha);
            Controls.Add(label5);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(pictureBox1);
            Controls.Add(btnCadastrarUsuario);
            Controls.Add(pictureBox2);
            Name = "CadastraUser";
            Text = "CadastraUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarUsuario;
        private PictureBox pictureBox1;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtConfirmarSenha;
        private Label label6;
        private TextBox txtSenha;
        private Label label7;
        private Label label8;
        private Button btnLimparFormulario;
        private PictureBox pictureBox2;
        private MaskedTextBox maskedTxtTelefone;
        private MaskedTextBox maskedCpf;
    }
}