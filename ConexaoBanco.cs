using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios
{
    static class ConexaoBanco
    {       
        private const string servidor = "localhost";
        private const string bancoDados = "dbFuncionarios";
        private const string usuario = "wellington";
        private const string senha = "123456";

        static public string banco = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";       
    }
}
