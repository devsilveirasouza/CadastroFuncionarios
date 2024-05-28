using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios
{
    internal class CadastroFuncionarios
    {
        private int id;
        private string nome = "";
        private string email = "";
        private string cpf = "";
        private string endereco = "";

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        /* MÉTODO PARA CADASTRAR REGISTRO NO BANCO DE DADOS */
        public bool CadastrarFuncionarios()
        {
            bool isSuccess = false;
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.banco);
                MysqlConexaoBanco.Open();
                // CRIANDO A QUERY SQL
                string insert = $"INSERT INTO funcionarios (nome, email, cpf, endereco) values ('{Nome}','{Email}','{Cpf}','{Endereco}')";                                
                // CRIANDO O COMANDO SQL
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;
                // EXECUTA O COMANDO
                comandoSql.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro no banco de dados - método: cadastrarFuncionarios: " + ex.Message);
            }
            return isSuccess;
        }
        // MÉTODO PARA PROCURAR UM REGISTRO NO BANCO DE DADOS
        public MySqlDataReader localizarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.banco);
                MysqlConexaoBanco.Open();

                string select = $"SELECT id, nome, email, endereco FROM funcionarios WHERE cpf = '{Cpf}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = select;

                MySqlDataReader reader = comandosql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método localizarFuncionario: " + ex.Message);
                return null;// SE NÃO ENCONTRAR NADA RETORNA NULO
            }            
        }
        // MÉTODO PARA ATUALIZAR REGISTRO NO BANCO DE DADOS
        public bool atualizarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.banco);
                MysqlConexaoBanco.Open();

                string update = $"update funcionarios set email = '{Email}', endereco = '{Endereco}' where id = '{Id}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = update;

                comandosql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método atualizarFuncionario: " + ex.Message);
                return false;
            }
        }
        // DELETAR REGISTRO DO BANCO DE DADOS
        public bool deletararFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.banco);
                MysqlConexaoBanco.Open();

                string delete = $"delete from funcionarios where id = '{Id}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = delete;

                comandosql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - método deletarFuncionario: " + ex.Message);
                return false;
            }
        }
    }
}