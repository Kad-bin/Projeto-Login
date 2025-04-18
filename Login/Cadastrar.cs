namespace Login
{
    public partial class CadastraUsuario : Form
    {
        public CadastraUsuario()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeCadastro.Text;
                string email = txtEmailCadastro.Text;
                string telefone = txtTelefoneCadastro.Text;
                string endereco = txtEnderecoCadastro.Text;
                string cpf = txtCpfCadastro.Text;
                var senha = txtSenhaCadastro.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuario: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void LimparFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                txtNomeCadastro.Text = "";
                txtSenhaCadastro.Text = "";
                txtEmailCadastro.Text = "";
                txtTelefoneCadastro.Text = "";
                txtEnderecoCadastro.Text = "";
                txtCpfCadastro.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuario: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }
    }
} 


