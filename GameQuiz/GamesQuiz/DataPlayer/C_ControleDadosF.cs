using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesQuiz.DataPlayer
{
    class C_ControleDadosF : C_ControlePlayerDados
    {
        public C_ControleDadosF(string id,string nome, string senha, int codigo) : base(nome, senha)
        {
            this.ID_Player = id;
            this.Codigo = codigo;
        }
        public C_ControleDadosF()
        {
        }
        private string D_IdJogador;

        public string ID_Player
        {
            get { return this.D_IdJogador; }
            set { this.D_IdJogador = value; }
        }
        private int D_codigo;

        public int Codigo
        {
            get { return this.D_codigo; }
            set { this.D_codigo = value; }
        }
    }
}
