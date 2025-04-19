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
                string telefone = txtTelefone.Text;
                string cpf = txtCpf.Text;

                if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSenha.Text) ||
                    string.IsNullOrWhiteSpace(txtConfirmarSenha.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                    string.IsNullOrWhiteSpace(txtCpf.Text))
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
                else if  (!ValidarTelefone.ValidarTelefones(telefone))
                {
                    MessageBox.Show("Telefone inválido. O telefone deve estar no formato (XX) XXXX-XXXX.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtCpf.Text = " ";
            txtEmail.Text = " ";
            txtNome.Text = " ";
            txtSenha.Text = " ";
            txtTelefone.Text = " ";
            txtUsuario.Text = " ";
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
    }
}
