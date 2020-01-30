using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GamesQuiz.Connection;
using GamesQuiz.DataPlayer;
using System.Data;

namespace GamesQuiz.DataPlayer
{
    class C_ControlePlayerDados
    {
        public bool localizaAcesso = false;
        private string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConectionDB conectionDB = new ConectionDB();        

        public void Cadastrar(C_CadatrarDados dados)
        {
            try
            {
                conectionDB.Conectar();
                cmd.Connection = conectionDB.ObjetoConexao;
                cmd.CommandText = "INSERT INTO TB_DADOSJOGADOR (ID_JOGADOR, JOGADOR, SENHA) VALUES (NEWID(),@NOME,@SENHA)";
                cmd.Parameters.AddWithValue("@NOME", dados.Nome);
                cmd.Parameters.AddWithValue("@SENHA", dados.Senha);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erroIN)
            {
                throw new ApplicationException(erroIN.Message);
            }
            finally
            {
                conectionDB.Desconectar();
            }
        }
        public bool VerificarLogin(C_CadatrarDados loginFormPrincipal)
        {
            try
            {
                conectionDB.Conectar();
                cmd.Connection = conectionDB.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM TB_DADOSJOGADOR WHERE JOGADOR = @NOME AND SENHA =@SENHA";
                cmd.Parameters.AddWithValue("@NOME", loginFormPrincipal.Nome);
                cmd.Parameters.AddWithValue("@SENHA", loginFormPrincipal.Senha);
                SqlDataReader result;
                result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    localizaAcesso = true;
                }
                return localizaAcesso;
            }
            catch (SqlException error)
            {
                this.mensagem = error.Message;
            }
            finally
            {
                conectionDB.Desconectar();
            }
            return localizaAcesso;
        }

        public DataTable Verifica(string DAD)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("SELECT FROM TB_DADOSJOGADOR WHERE JOGADOR = @NOMES", conectionDB.ObjetoConexao);
            cmd.Parameters.AddWithValue("@NOMES", DAD);
            dt.Fill(tabela);
            return tabela;
        }
    }
}
