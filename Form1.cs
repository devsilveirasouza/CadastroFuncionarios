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
                        MessageBox.Show($"Funcion�rio {cadFuncionarios.Nome} cadastrado com sucesso!");
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
                MessageBox.Show("Erro ao cadastrar funcion�rio: " + ex.Message);
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
                            MessageBox.Show("Funcion�rio n�o encontrado");
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
                        MessageBox.Show("Funcion�rio n�o encontrado");
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
                MessageBox.Show("Erro ao realizar a pesquisa no banco de dados" + ex.Message);
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtbNome.Text.Equals("") && !txtbEmail.Text.Equals("") && !txtbCpf.Text.Equals("") && !txtbEndereco.Text.Equals(""))
                {
                    CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                    cadFuncionarios.Id = int.Parse(lblIdFuncionario.Text);
                    cadFuncionarios.Email = txtbEmail.Text;
                    cadFuncionarios.Endereco = txtbEndereco.Text;

                    if (cadFuncionarios.atualizarFuncionario())
                    {
                        MessageBox.Show("Os dados do funcion�rio foram atualizados com sucesso!");
                        txtbNome.Clear();
                        txtbEmail.Clear();
                        txtbCpf.Clear();
                        txtbEndereco.Clear();
                        lblIdFuncionario.Text = "";
                        txtbCpf.Focus();
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel atualizar os dados");
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
                    MessageBox.Show("Favor localizar o funcion�rio que deseja atualizar as informa��es");
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
                MessageBox.Show("Erro ao atualizar dados do funcion�rio: " + ex.Message);
            }
        }
        // M�TODO PARA DELETAR REGISTRO DO BANCO DE DADOS
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!txtbNome.Text.Equals("") && !txtbEmail.Text.Equals("") && !txtbCpf.Text.Equals("") && !txtbEndereco.Text.Equals(""))
                {
                    CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                    cadFuncionarios.Id = int.Parse(lblIdFuncionario.Text);

                    if (cadFuncionarios.deletararFuncionario())
                    {
                        MessageBox.Show("O funcion�rio foi exclu�do com sucesso!");
                        txtbNome.Clear();
                        txtbEmail.Clear();
                        txtbCpf.Clear();
                        txtbEndereco.Clear();
                        lblIdFuncionario.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel excluir funcion�rio");
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
                    MessageBox.Show("Favor pesquisar qual funcion�rio deseja excluir");
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
                MessageBox.Show("Erro ao excluir funcion�rio: " + ex.Message);
            }
        }
    }
}