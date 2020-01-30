using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesQuiz.DataQuestion
{
    class C_ControleQuestoesDados
    {
        public C_ControleQuestoesDados(int id,string pergunta, string a, string b, string c, string d, string resposta)
        {
            this.ID_Pergunta = id;
            this.Pergunta = pergunta;
            this.QuestaoA = a;
            this.QuestaoB = b;
            this.QuestaoC = c;
            this.QuestaoC = d;
            this.Resposta = resposta;
        }

        public C_ControleQuestoesDados()
        {
        }

        private int _ContIdPergunta;

        public int ID_Pergunta
        {
            get { return this._ContIdPergunta; }
            set { this._ContIdPergunta = value; }
        }

        private string _ContQuestaoPergunta;

        public string Pergunta
        {
            get { return this._ContQuestaoPergunta; }
            set { this._ContQuestaoPergunta = value; }
        }

        private string _ContQuestaoA;

        public string QuestaoA
        {
            get { return this._ContQuestaoA; }
            set { this._ContQuestaoA = value; }
        }

        private string _ContQuestaoB;

        public string QuestaoB
        {
            get { return this._ContQuestaoB; }
            set { this._ContQuestaoB = value; }
        }

        private string _ContQuestaoC;

        public string QuestaoC
        {
            get { return this._ContQuestaoC; }
            set { this._ContQuestaoC = value; }
        }

        private string _ContQuestaoD;

        public string QuestaoD
        {
            get { return this._ContQuestaoD; }
            set { this._ContQuestaoD = value; }
        }

        private string _ContResposta;

        public string Resposta
        {
            get { return this._ContResposta; }
            set { this._ContResposta = value; }
        }
    }
}
