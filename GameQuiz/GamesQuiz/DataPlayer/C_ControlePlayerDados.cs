using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesQuiz.DataPlayer
{
    class C_ControlePlayerDados
    {
        public C_ControlePlayerDados( string nome, string senha)
        {
            this.Nome = nome;
            this.Senha = senha;
        }

        public C_ControlePlayerDados()
        {

        }

        private string ID_Jogador;

        public string ID
        {
            get { return this.ID_Jogador; }
            set { this.ID_Jogador = value; }
        }
        private string D_jogador;

        public string Nome
        {
            get { return this.D_jogador; }
            set { this.D_jogador = value; }
        }

        private string D_senha;

        public string Senha
        {
            get { return this.D_senha; }
            set { this.D_senha = value; }
        }
    }
}
