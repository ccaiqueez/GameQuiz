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
    class C_DalPlayerDados
    {
        public bool _temdados = false;       
        int tipo;
        SqlCommand cmd = new SqlCommand();
        ConectionDB conectionDB = new ConectionDB();
        SqlDataReader dr, mdr;


        //METODO DE CADASTRO QUANDO O USUÁRIO POR JOGADOR
        public void CadastrarJogador(C_ControlePlayerDados dados)
        {
            try
            {
                conectionDB.Conectar();
                cmd.Connection = conectionDB.ObjetoConexao;
                cmd.CommandText = "INSERT INTO TB_DadosPlayer (GUIDJOGADOR,JOGADOR, SENHA) VALUES(NEWID(),@NOME,@SENHA)";
               // cmd.Parameters.AddWithValue("@ID_JOGADOR", dados.ID);
                cmd.Parameters.AddWithValue("@NOME", dados.Nome);
                cmd.Parameters.AddWithValue("@SENHA", dados.Senha);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            finally
            {
                conectionDB.Desconectar();
            }
        }

        //METODO DE CADASTRO QUANDO O USUÁRIO POR ADMINISTRADOR
        public void CadastrarAdministrador(C_ControleDadosF dadosAdm)
        {
            try
            {
                conectionDB.Conectar();
                cmd.Connection = conectionDB.ObjetoConexao;
                cmd.CommandText= "INSERT INTO TB_DadosPlayer (GUIDJOGADOR,JOGADOR, SENHA,CODIGO) VALUES(NEWID(),@NOME,@SENHA, @CODIGO)";
               //cmd.Parameters.AddWithValue("@ID_JOGADOR", dadosAdm.ID);
                cmd.Parameters.AddWithValue("@NOME", dadosAdm.Nome);
                cmd.Parameters.AddWithValue("@SENHA", dadosAdm.Senha);
                cmd.Parameters.AddWithValue("@CODIGO", dadosAdm.Codigo);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            finally
            {
                conectionDB.Desconectar();
            }
        }

        //METODO DE ALTERAR LOGIN
        public void EditarUsuario(C_ControleDadosF dadosAltera)
        {
            try
            {
                conectionDB.Conectar();
                cmd.Connection = conectionDB.ObjetoConexao;
                cmd.CommandText = "UPDATE TB_DadosPlayer SET JOGADOR =@JOGADOR, SENHA = @SENHA, CODIGO = @CODIGO WHERE GUIDJOGADOR = @GUIDJOGADOR ";
               cmd.Parameters.AddWithValue("@GUIDJOGADOR", dadosAltera.ID_Player);
                cmd.Parameters.AddWithValue("@JOGADOR", dadosAltera.Nome);
                cmd.Parameters.AddWithValue("@SENHA", dadosAltera.Senha);
                cmd.Parameters.AddWithValue("@CODIGO", dadosAltera.Codigo);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            finally
            {
                conectionDB.Desconectar();
            }
        }

        public void ExcluirUsuario(C_ControleDadosF dadosAltera)
        {
            try
            {
                conectionDB.Conectar();
                cmd.Connection = conectionDB.ObjetoConexao;
                cmd.CommandText = "DELETE FROM TB_DadosPlayer WHERE JOGADOR = @JOGADOR ";
                cmd.Parameters.AddWithValue("@JOGADOR", dadosAltera.Nome);
                
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            finally
            {
                conectionDB.Desconectar();
            }
        }

        //METODO DE VERIFICAR OS DADOS DE ACESSO
        public bool VerificarLogin(C_ControlePlayerDados Controle)
        {
            try
            {
                cmd.Connection = conectionDB.ObjetoConexao;
                conectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM TB_DadosPlayer WHERE JOGADOR = @JOGADOR AND SENHA = @SENHA";
                cmd.Parameters.AddWithValue("@JOGADOR", Controle.Nome);
                cmd.Parameters.AddWithValue("@SENHA", Controle.Senha);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    _temdados = true;
                }
                conectionDB.Desconectar();
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            return _temdados;
        }

        //METODO QUE RETORNA O NIVEL DE ACESSO
        public int dadosAcessoNivel(C_ControlePlayerDados Controle)
        {
            try
            {
                SqlCommand cmds = new SqlCommand();
                cmds.Connection = conectionDB.ObjetoConexao;
                conectionDB.Conectar();
                cmds.CommandText = "SELECT CODIGO FROM TB_DadosPlayer WHERE JOGADOR = @JOGADOR";
                cmds.Parameters.AddWithValue("@JOGADOR", Controle.Nome);
                mdr = cmds.ExecuteReader();

                if (mdr.Read())
                {
                    tipo = Convert.ToInt32((mdr["CODIGO"].ToString()));
                }
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            finally
            {
                conectionDB.Desconectar();
            }
            return tipo;
        }       
        
        public DataTable ConsultaDeDados()
        {
            try
            {
                conectionDB.Conectar();
                DataTable tabelaUsuario = new DataTable();
                SqlDataAdapter dapter = new SqlDataAdapter("SELECT * FROM TB_DadosPlayer", conectionDB.ObjetoConexao);
                dapter.Fill(tabelaUsuario);
                conectionDB.Desconectar();
                return tabelaUsuario;
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
        }
    }
}
