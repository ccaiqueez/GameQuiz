using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GamesQuiz.Connection
{
    class ConectionDB
    {
        private String _stringConexao;
        private SqlConnection _conexao;
        private string _caminhoConexao = @"Data Source=DESKTOP-SB2KE7K\SQLEXPRESS;Initial Catalog = QUIZ_DB; User ID = sa; Password=12345";

        public ConectionDB()
        {
            this._conexao = new SqlConnection();
            this.StringConexao = _caminhoConexao;
            this._conexao.ConnectionString = _caminhoConexao;
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
