using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;

namespace CadastroFuncionarios
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtbNome.Text.Equals("") && !txtbEmail.Text.Equals("") && !txtbCpf.Text.Equals("") && !txtbEndereco.Text.Equals(""))
                {
                    CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                    cadFuncionarios.Nome = txtbNome.Text;
                    cadFuncionarios.Email = txtbEmail.Text;
                    cadFuncionarios.Cpf = txtbCpf.Text;
                    cadFuncionarios.Endereco = txtbEndereco.Text;

                    if (cadFuncionarios.CadastrarFuncionarios())
                    {
                        MessageBox.Show($"Funcionário {cadFuncionarios.Nome} cadastrado com sucesso!");
                        txtbNome.Clear();
                        txtbEmail.Clear();
                        txtbCpf.Clear();
                        txtbEndereco.Clear();
                        txtbNome.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente");
                    txtbNome.Clear();
                    txtbEmail.Clear();
                    txtbCpf.Clear();
                    txtbEndereco.Clear();
                    txtbNome.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtbCpf.Text.Equals(""))
                {
                    CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                    cadFuncionarios.Cpf = txtbCpf.Text;

                    MySqlDataReader reader = cadFuncionarios.localizarFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblIdFuncionario.Text = reader["id"].ToString();
                            txtbNome.Text = reader["nome"].ToString();
                            txtbEmail.Text = reader["email"].ToString();
                            txtbEndereco.Text = reader["endereco"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado");
                            txtbNome.Clear();
                            txtbEmail.Clear();
                            txtbCpf.Clear();
                            txtbEndereco.Clear();
                            lblIdFuncionario.Text = "";
                            txtbCpf.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado");
                        txtbNome.Clear();
                        txtbEmail.Clear();
                        txtbCpf.Clear();
                        txtbEndereco.Clear();
                        lblIdFuncionario.Text = "";
                        txtbCpf.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Favor preencher o campo CPF para realizar a pesquisa!");
                    txtbNome.Clear();
                    txtbEmail.Clear();
                    txtbCpf.Clear();
                    txtbEndereco.Clear();
                    lblIdFuncionario.Text = "";
                    txtbCpf.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a pesquisa no banco de dados");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbNome.Clear();
            txtbEmail.Clear();
            txtbCpf.Clear();
            txtbEndereco.Clear();
            lblIdFuncionario.Text = "";
        }
    }
}