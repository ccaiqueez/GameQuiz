using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesQuiz.DataQuestion;
using GamesQuiz.Connection;
using GamesQuiz.DataPlayer;

namespace GamesQuiz.Forms
{
    public partial class F_Musicas : Form
    {
        string respostaCerta, guardaRespostaCerta,guardaNome;
        int pontos = 0, passa = 1, pontosAcerto = 0, questaoRodada;
        float porcentagem;

        public F_Musicas(string valors)
        {
            InitializeComponent();
            guardaNome = valors;
        }

        public F_Musicas()
        {
            InitializeComponent();
        }

        private void rb_perguntaA_MouseClick(object sender, MouseEventArgs e)
        {
            guardaRespostaCerta = rb_perguntaA.Text;
        }

        private void rb_perguntaB_MouseClick(object sender, MouseEventArgs e)
        {
            guardaRespostaCerta = rb_perguntaB.Text;
        }

        private void rb_perguntaC_MouseClick(object sender, MouseEventArgs e)
        {
            guardaRespostaCerta = rb_perguntaC.Text;
        }

        private void F_Musicas_Load(object sender, EventArgs e)
        {
            QuestoesMusicas();
            cases();
        }

        private void rb_perguntaD_MouseClick(object sender, MouseEventArgs e)
        {
            guardaRespostaCerta = rb_perguntaD.Text;
        }

        private void btn_avancar_Click(object sender, EventArgs e)
        {
            if (rb_perguntaA.Checked || rb_perguntaB.Checked || rb_perguntaC.Checked || rb_perguntaD.Checked)
            {
                if (guardaRespostaCerta == respostaCerta)
                {
                    passa = passa + 1;

                    QuestoesMusicas();

                    rb_perguntaA.Checked = false;
                    rb_perguntaB.Checked = false;
                    rb_perguntaC.Checked = false;
                    rb_perguntaD.Checked = false;

                    pontos = pontos + Convert.ToInt32(porcentagem);
                    pontosAcerto = pontosAcerto + 1;
                    lb_pontos.Text = Convert.ToString(pontos);
                }
                else
                {
                    timer1.Stop();

                    passa = passa + 1;
                    C_PerguntaDadosQuestoesMusicas metodoRetornaQuestaos = new C_PerguntaDadosQuestoesMusicas(passa);
                    MessageBox.Show("Resposta certa:  " + "(" + respostaCerta + ")","ERROOOOOU");
                    rb_perguntaA.Checked = false;
                    rb_perguntaB.Checked = false;
                    rb_perguntaC.Checked = false;
                    rb_perguntaD.Checked = false;

                    QuestoesMusicas();
                }
                if (passa == 11)
                {
                    questaoFinal();
                }
            }
            else
            {
                MessageBox.Show("Selecione um questão para avançar!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Categorias CATE = new F_Categorias(guardaNome);
            CATE.Show();
        }

        private void btn_novamente_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Musicas musicas = new F_Musicas(guardaNome);
            musicas.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            FormularioPrincipal forms = new FormularioPrincipal();
            forms.Show();
            this.Close();
        }

        private void QuestoesMusicas()
        {
            C_PerguntaDadosQuestoesMusicas metodoRetornaQuestao = new C_PerguntaDadosQuestoesMusicas(passa);
            respostaCerta = metodoRetornaQuestao.QuestaoRetornaResposta();
            lb_Pergunta.Text = metodoRetornaQuestao.QuestaoRetornaPergunta();
            rb_perguntaA.Text = metodoRetornaQuestao.QuestaoRetornaQuestaoA();
            rb_perguntaB.Text = metodoRetornaQuestao.QuestaoRetornaQuestaoB();
            rb_perguntaC.Text = metodoRetornaQuestao.QuestaoRetornaQuestaoC();
            rb_perguntaD.Text = metodoRetornaQuestao.QuestaoRetornaQuestaoD();
            lb_questao.Text = Convert.ToString(metodoRetornaQuestao.QuestaoRodadaRetorna());
            questaoRodada = metodoRetornaQuestao.QuestaoRodadaRetorna();
            cases();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(-1);
            porcentagem = progressBar1.Value;
            Timers();
        }

        private void Timers()
        {
            if (progressBar1.Value == 0)
            {
                this.timer1.Stop();

                passa = passa + 1;
                C_PerguntaDadosQuestoesMusicas metodoRetornaQuestaoTecnologias = new C_PerguntaDadosQuestoesMusicas(passa);
                MessageBox.Show("Resposta certa:  " + "(" + respostaCerta + ")", "Tempo Esgotado");
                rb_perguntaA.Checked = false;
                rb_perguntaB.Checked = false;
                rb_perguntaC.Checked = false;
                rb_perguntaD.Checked = false;
                QuestoesMusicas();

                if (passa == 11)
                {
                    questaoFinal();
                }
            }
        }

        private void questaoFinal()
        {
            timer1.Stop();
            lb_tempo.Visible = false;
            progressBar1.Visible = false;
            lb_questaov.Visible = false;
            lb_questao.Visible = false;
            lb_pontosv.Visible = false;
            lb_pontos.Visible = false;
            rb_perguntaA.Visible = false;
            rb_perguntaB.Visible = false;
            rb_perguntaC.Visible = false;
            rb_perguntaD.Visible = false;
            btn_avancar.Visible = false;

            label4.Visible = true;
            label4.Text = Convert.ToString(pontosAcerto);
            lb_pontScore.Visible = true;
            lb_score.Visible = true;
            lb_score.Text = Convert.ToString(pontos);
            lb_numequest.Visible = true;
            lb_questCertas.Visible = true;
            btn_menu.Visible = true;
            btn_novamente.Visible = true;

            Rankings rank = new Rankings(guardaNome);
            rank.verificaSeExistePontuacao(rank.metodoPegaID());


            if (rank._temdados)
            {
                int pontuacaoBanco = Convert.ToInt32(rank.metodoRetornaPontuacao());

                if (pontos > pontuacaoBanco)
                {
                    rank.UpdatePontuacao(pontos);
                }
            }
            else
            {
                rank.CadastrarRanking(pontos);
            }
        }

        private void cases()
        {
            switch (questaoRodada)
            {

                case 1:
                    timer1.Start();
                    break;
                case 2:
                    this.progressBar1.Value = 100;
                    timer1.Start();
                    break;

                case 3:
                    this.progressBar1.Value = 100;
                    timer1.Start();
                    break;

                case 4:
                    this.progressBar1.Value = 100;
                    timer1.Start();
                    break;

                case 5:
                    this.progressBar1.Value = 100;
                    timer1.Start();
                    break;

                case 6:
                    this.progressBar1.Value = 100;
                    timer1.Start();
                    break;

                case 7:
                    this.progressBar1.Value = 100;
                    timer1.Start();
                    break;

                case 8:
                    this.progressBar1.Value = 100;
                    timer1.Start();
                    break;

                case 9:
                    this.progressBar1.Value = 100;
                    timer1.Start();
                    break;

                case 10:
                    this.progressBar1.Value = 100;
                    timer1.Start();
                    break;
            }
        }
    }
}
