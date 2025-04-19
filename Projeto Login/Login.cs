using System.Diagnostics.Eventing.Reader;

namespace Projeto_Login
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtNome.Text;
                string senha = txtSenha.Text;
                string email = txtEmail.Text;
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!VerificarEmail.EmailValidator.IsValidEmail(email))
                {
                    MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!ValidarNome.ValidarNomes(usuario))
                {
                    MessageBox.Show("Nome inválido. O nome deve conter apenas letras e espaços.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCadatrar_Click(object sender, EventArgs e)
        {
            txtNome.Focus();

            CadastraUser cadastro = new CadastraUser();
            cadastro.ShowDialog();



        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '●';


        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

            txtEmail.MaxLength = 50;

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
