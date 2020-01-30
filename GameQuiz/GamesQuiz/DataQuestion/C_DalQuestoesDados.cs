using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GamesQuiz.Connection;
using System.Data;

namespace GamesQuiz.DataQuestion
{
    class C_DalQuestoesDados
    {
        SqlCommand cmd = new SqlCommand();
        ConectionDB conectionDB = new ConectionDB();
        SqlDataReader mdr;

        public void CadastrarQuestoesMedicina(C_ControleQuestoesDados _questoesDados)
        {
            try
            {
                conectionDB.Conectar();
                cmd.Connection = conectionDB.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Quiz_Medicina(ID_PERGUNTA,PERGUNTA, A, B, C, D, RESPOSTA) VALUES (@ID_PERGUNTA,@PERGUNTA, @A, @B, @C, @D, @RESPOSTA)";
                cmd.Parameters.AddWithValue("@ID_PERGUNTA", _questoesDados.ID_Pergunta);
                cmd.Parameters.AddWithValue("@PERGUNTA", _questoesDados.Pergunta);
                cmd.Parameters.AddWithValue("@A", _questoesDados.QuestaoA);
                cmd.Parameters.AddWithValue("@B", _questoesDados.QuestaoB);
                cmd.Parameters.AddWithValue("@C", _questoesDados.QuestaoC);
                cmd.Parameters.AddWithValue("@D", _questoesDados.QuestaoD);
                cmd.Parameters.AddWithValue("@RESPOSTA", _questoesDados.Resposta);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                throw new ApplicationException(error.Message);
            }
        }

        public void EditarQuestaoMedicina(C_ControleQuestoesDados _questaoEditar)
        {
            try
            {
                conectionDB.Conectar();
                cmd.Connection = conectionDB.ObjetoConexao;
                cmd.CommandText = "UPDATE Quiz_Medicina SET ID_PERGUNTA = @ID_PERGUNTA, PERGUNTA = @PERGUNTA, A = @A, B = @B, C = @C, D = @D, RESPOSTA =  @RESPOSTA WHERE ID_PERGUNTA = @ID_PERGUNTA";
                cmd.Parameters.AddWithValue("@ID_PERGUNTA", _questaoEditar.ID_Pergunta);
                cmd.Parameters.AddWithValue("@PERGUNTA", _questaoEditar.Pergunta);
                cmd.Parameters.AddWithValue("@A", _questaoEditar.QuestaoA);
                cmd.Parameters.AddWithValue("@B", _questaoEditar.QuestaoB);
                cmd.Parameters.AddWithValue("@C", _questaoEditar.QuestaoC);
                cmd.Parameters.AddWithValue("@D", _questaoEditar.QuestaoD);
                cmd.Parameters.AddWithValue("@RESPOSTA", _questaoEditar.Resposta);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                throw new ApplicationException(error.Message);
            }
        }

        public void DeletarQuestaoMedicina(C_ControleQuestoesDados _questaoEditar)
        {
            try
            {
                conectionDB.Conectar();
                cmd.Connection = conectionDB.ObjetoConexao;
                cmd.CommandText = "DELETE FROM Quiz_Medicina WHERE ID_PERGUNTA = @ID_PERGUNTA";
                cmd.Parameters.AddWithValue("@ID_PERGUNTA", _questaoEditar.ID_Pergunta);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                throw new ApplicationException(error.Message);
            }
        }
        public DataTable ConsultaDeDados()
        {
            conectionDB.Conectar();
            DataTable tabelaMedicina = new DataTable();
            SqlDataAdapter dapter = new SqlDataAdapter("SELECT * FROM Quiz_Medicina", conectionDB.ObjetoConexao);
            dapter.Fill(tabelaMedicina);
            return tabelaMedicina;
            // conectionDB.Desconectar();
        }
    }
}
