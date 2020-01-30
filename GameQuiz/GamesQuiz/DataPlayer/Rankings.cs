using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GamesQuiz.Connection;

namespace GamesQuiz.DataPlayer
{
    public class Rankings
    {
        ConectionDB ConectionDB = new ConectionDB();
        SqlDataReader mdr, dr;
        String armazenaID, armazenaPontuacao,nomeJogadors;
        public bool _temdados = false;

        public Rankings(string nomeJogador)
        {
            nomeJogadors = nomeJogador;
        }

      public Rankings() { }

        public string metodoPegaID()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConectionDB.ObjetoConexao;
                ConectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM TB_DadosPlayer WHERE JOGADOR  = @JOGADOR";
                cmd.Parameters.AddWithValue("@JOGADOR", nomeJogadors);
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    armazenaID = (mdr["GUIDJOGADOR"].ToString());
                }
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            finally
            {
                ConectionDB.Desconectar();
            }
            return armazenaID;
        }

        public void CadastrarRanking(int pontuacao)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ConectionDB.Conectar();
                cmd.Connection = ConectionDB.ObjetoConexao;
                cmd.CommandText = "INSERT INTO RANKING(GUIDJOGADOR,PONTUACAO)VALUES(@GUIDJOGADOR,@PONTUACAO)";
                cmd.Parameters.AddWithValue("@GUIDJOGADOR", armazenaID);
                cmd.Parameters.AddWithValue("@PONTUACAO", pontuacao);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            finally
            {
                ConectionDB.Desconectar();
            }
        }

        public void UpdatePontuacao(int pontuacaoUpdate)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                ConectionDB.Conectar();
                cmd.Connection = ConectionDB.ObjetoConexao;
                cmd.CommandText = "UPDATE RANKING SET PONTUACAO = @PONTUACAO WHERE GUIDJOGADOR = @GUIDJOGADOR";
                cmd.Parameters.AddWithValue("@GUIDJOGADOR", armazenaID);
                cmd.Parameters.AddWithValue("@PONTUACAO", pontuacaoUpdate);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            finally
            {
                ConectionDB.Desconectar();
            }
        }

        //FUNÇÃO QUE VERIFICA SE EXISTE O JOGADOR NO RANKING

        public bool verificaSeExistePontuacao(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConectionDB.ObjetoConexao;
                ConectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM RANKING WHERE GUIDJOGADOR = @GUIDJOGADOR";
                cmd.Parameters.AddWithValue("@GUIDJOGADOR", id);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    _temdados = true;
                }
                ConectionDB.Desconectar();
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            return _temdados;
        }

        public string metodoRetornaPontuacao()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ConectionDB.ObjetoConexao;
                ConectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM RANKING WHERE GUIDJOGADOR  = @GUIDJOGADOR";
                cmd.Parameters.AddWithValue("@GUIDJOGADOR", armazenaID);
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    armazenaPontuacao = (mdr["PONTUACAO"].ToString());
                }
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            finally
            {
                ConectionDB.Desconectar();
            }
            return armazenaPontuacao;
        }

         public DataTable ConsultaDeDados()
        {
            try
            {
                ConectionDB.Conectar();
                DataTable TabelaRanking = new DataTable();
                SqlDataAdapter dapter = new SqlDataAdapter(
               "  SELECT ROW_NUMBER() OVER(ORDER BY RANK.PONTUACAO DESC) AS POSIÇÃO, PLAY.JOGADOR, RANK.PONTUACAO" +
              "  FROM TB_DadosPlayer AS PLAY" +
               " INNER JOIN RANKING AS RANK ON PLAY.GUIDJOGADOR = RANK.GUIDJOGADOR ORDER BY" +
              "  RANK.PONTUACAO DESC", ConectionDB.ObjetoConexao);
                dapter.Fill(TabelaRanking);

                return TabelaRanking;
            }
            catch (SqlException erro)
            {
                throw new ApplicationException(erro.Message);
            }
            finally
            {
                ConectionDB.Desconectar();
            }
        }
    }
}
