using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Login
{
    public partial class CadastraUser : Form
    {
        public CadastraUser()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string senha = txtSenha.Text;
                string confirmarSenha = txtConfirmarSenha.Text;
                string telefone = maskedTxtTelefone.Text;
                string cpf = maskedCpf.Text;

                if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSenha.Text) ||
                    string.IsNullOrWhiteSpace(txtConfirmarSenha.Text) ||
                    string.IsNullOrWhiteSpace(maskedTxtTelefone.Text) ||
                    string.IsNullOrWhiteSpace(maskedCpf.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtSenha.Text != txtConfirmarSenha.Text)
                {
                    MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                else if (!VerificarEmail.EmailValidator.IsValidEmail(email))
                {
                    MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!ValidarNome.ValidarNomes(nome))
                {
                    MessageBox.Show("Nome inválido. O nome deve conter apenas letras e espaços.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //else if (!ValidarCpf.ValidarCpf(cpf))
                //{
                //    MessageBox.Show("CPF inválido. O CPF deve conter 11 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                else
                {

                }


                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);





                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimparFormulario_Click(object sender, EventArgs e)
        {
            //limpar formulario
            txtConfirmarSenha.Text = " ";
            maskedCpf.Text = " ";
            txtEmail.Text = " ";
            txtNome.Text = " ";
            txtSenha.Text = " ";
            maskedTxtTelefone.Text = " ";
           
            txtNome.Focus();

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '●';

        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            txtConfirmarSenha.PasswordChar = '●';
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {


        }

        private void maskedTxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTxtTelefone.Mask = "(00) 00000-0000"; // Formato para celular (11 dígitos)                                                    // Ou, se quiser aceitar telefone fixo (10 dígitos):                                                   // maskedTextBox1.Mask = "(00) 0000-00009"; // O "9" no final é opcional
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
