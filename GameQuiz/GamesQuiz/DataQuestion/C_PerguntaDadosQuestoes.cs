using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GamesQuiz.Connection;

namespace GamesQuiz.DataQuestion
{
    class C_PerguntaDadosQuestoes
    {
        string pergunta, questaoA, questaoB, questaoC, questaoD, resposta;
        int recebeValor, rodadaQuestao;
        SqlDataReader mdr, mdrs;
        ConectionDB conectionDB = new ConectionDB();

        public C_PerguntaDadosQuestoes(int recebeValorPergunta)
        {
            this.recebeValor = recebeValorPergunta;
        }

        public C_PerguntaDadosQuestoes()
        {
            // recebeValor = 10;
        }
        public int QuestaoRodadaRetorna()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conectionDB.ObjetoConexao;
                conectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM Quiz_Medicina WHERE ID_PERGUNTA  = @ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToString(recebeValor));
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    rodadaQuestao = Convert.ToInt32((mdr["ID_PERGUNTA"].ToString()));
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conectionDB.Desconectar();
            }
            return rodadaQuestao;
        }

        public string QuestaoRetornaPergunta()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conectionDB.ObjetoConexao;
                conectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM Quiz_Medicina WHERE ID_PERGUNTA  = @ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToString(recebeValor));
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    pergunta = (mdr["PERGUNTA"].ToString());
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conectionDB.Desconectar();
            }
            return pergunta;
        }

        public string QuestaoRetornaQuestaoA()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conectionDB.ObjetoConexao;
                conectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM Quiz_Medicina WHERE ID_PERGUNTA  = @ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToString(recebeValor));
                mdrs = cmd.ExecuteReader();

                if (mdrs.Read())
                {
                    questaoA = (mdrs["A"].ToString());
                  //  questaoB = (mdrs["B"].ToString());
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conectionDB.Desconectar();
            }
            return questaoA;
        }

        public string QuestaoRetornaQuestaoB()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                QuestaoRetornaPergunta();
                cmd.Connection = conectionDB.ObjetoConexao;
                conectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM Quiz_Medicina WHERE ID_PERGUNTA  = @ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToString(recebeValor));
                mdrs = cmd.ExecuteReader();

                if (mdrs.Read())
                {
                    questaoB = (mdrs["B"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conectionDB.Desconectar();
            }
            return questaoB;
        }

        public string QuestaoRetornaQuestaoC()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                QuestaoRetornaPergunta();
                cmd.Connection = conectionDB.ObjetoConexao;
                conectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM Quiz_Medicina WHERE ID_PERGUNTA  = @ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToString(recebeValor));
                mdrs = cmd.ExecuteReader();

                if (mdrs.Read())
                {
                    questaoC = (mdrs["C"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conectionDB.Desconectar();
            }
            return questaoC;
        }

        public string QuestaoRetornaQuestaoD()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(); ;
                QuestaoRetornaPergunta();
                cmd.Connection = conectionDB.ObjetoConexao;
                conectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM Quiz_Medicina WHERE ID_PERGUNTA  = @ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToString(recebeValor));
                mdrs = cmd.ExecuteReader();

                if (mdrs.Read())
                {
                    questaoD = (mdrs["D"].ToString());
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conectionDB.Desconectar();
            }
            return questaoD;
        }

        public string QuestaoRetornaResposta()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(); ;
                QuestaoRetornaPergunta();
                cmd.Connection = conectionDB.ObjetoConexao;
                conectionDB.Conectar();
                cmd.CommandText = "SELECT * FROM Quiz_Medicina WHERE ID_PERGUNTA  = @ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToString(recebeValor));
                mdrs = cmd.ExecuteReader();

                if (mdrs.Read())
                {
                    resposta = (mdrs["RESPOSTA"].ToString());
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conectionDB.Desconectar();
            }
            return resposta;
        }
    }
}
