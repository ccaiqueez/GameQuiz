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
    public partial class F_Cinema : Form
    {
        string respostaCerta, guardaRespostaCerta, guardaNome;
        int pontos = 0, passa = 1, pontosAcerto = 0, questaoRodada;
        float porcentagem;

        public F_Cinema(string valors)
        {
            InitializeComponent();
            guardaNome = valors;
        }

        public F_Cinema()
        {
            InitializeComponent();
        }

        private void F_Cinema_Load(object sender, EventArgs e)
        {
            QuestaoCinema();
            cases();
        }

        //QUANDO E SELECIONADO UM RADIONBUTTON GRAVA NA VARIAVEL
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

        private void rb_perguntaD_MouseClick(object sender, MouseEventArgs e)
        {
            guardaRespostaCerta = rb_perguntaD.Text;
        }

        //BOTÃO QUE VERIFICA A QUESTÃO E PASSA PARA A PROXIMA QUESTÃO

        private void btn_avancar_Click(object sender, EventArgs e)
        {
            if (rb_perguntaA.Checked || rb_perguntaB.Checked || rb_perguntaC.Checked || rb_perguntaD.Checked)
            {

                if (guardaRespostaCerta == respostaCerta)
                {
                    passa = passa + 1;

                    QuestaoCinema();

                    rb_perguntaA.Checked = false;
                    rb_perguntaB.Checked = false;
                    rb_perguntaC.Checked = false;
                    rb_perguntaD.Checked = false;

                    pontos = pontos + Convert.ToInt32(porcentagem);
                    pontosAcerto = pontosAcerto + 1;
                    lb_pontos.Text = Convert.ToString(pontos);
                }
                //CASO A QUESTÃO ESTEJA ERRADO PASSA PARA A PROXIMA MOSTRANDO A QUESTÃO CORRETA
                else
                {
                    timer1.Stop();

                    passa = passa + 1;
                    
                    C_PerguntaDadosQuestoesMusicas metodoRetornaQuestaoTecnologias = new C_PerguntaDadosQuestoesMusicas(passa);
                    MessageBox.Show("Resposta certa:  " + "(" + respostaCerta + ")", "ERROOOOOU");

                    rb_perguntaA.Checked = false;
                    rb_perguntaB.Checked = false;
                    rb_perguntaC.Checked = false;
                    rb_perguntaD.Checked = false;

                    QuestaoCinema();
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
        //BOTAO MENU
        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Categorias catego = new F_Categorias(guardaNome);
            catego.Show();
        }
        //BOTAO PARA FECHAR
        private void btn_close_Click(object sender, EventArgs e)
        {            
            FormularioPrincipal forms = new FormularioPrincipal();
            forms.Show();
            this.Close();
        }

        private void lb_numequest_Click(object sender, EventArgs e)
        {

        }
        //BOTAO JOGAR NOVAMENTE 
        private void btn_novamente_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Cinema cinema = new F_Cinema(guardaNome);
            cinema.Show();
        }
        //METODO QUE CHAMA TODOS OS METODOS DA CLASSE DA QUESTÃO DO BANCO DE DADOS
        private void QuestaoCinema()
        {
            C_PerguntaDadosQuestoesCinema metodoRetornaQuestaoCinema = new C_PerguntaDadosQuestoesCinema(passa);
            lb_questao.Text = Convert.ToString(metodoRetornaQuestaoCinema.QuestaoRodadaRetorna());
            lb_Pergunta.Text = metodoRetornaQuestaoCinema.QuestaoRetornaPergunta();
            rb_perguntaA.Text = metodoRetornaQuestaoCinema.QuestaoRetornaQuestaoA();
            rb_perguntaB.Text = metodoRetornaQuestaoCinema.QuestaoRetornaQuestaoB();
            rb_perguntaC.Text = metodoRetornaQuestaoCinema.QuestaoRetornaQuestaoC();
            rb_perguntaD.Text = metodoRetornaQuestaoCinema.QuestaoRetornaQuestaoD();
            respostaCerta = metodoRetornaQuestaoCinema.QuestaoRetornaResposta();
            questaoRodada = metodoRetornaQuestaoCinema.QuestaoRodadaRetorna();
            cases();
        }
        //TIMER PARA PROGRESS
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar12.Increment(-1);
            porcentagem = progressBar12.Value;
            Timers();
        }

        //METODOS  TIMER, QUANDO O USUÁRIO NÃO RESPONDE A ULTIMA QUESTÃO NO TEMPO ADEQUADO 

        private void Timers()
        {
            if (progressBar12.Value == 0)
            {
                this.timer1.Stop();

                passa = passa + 1;
                C_PerguntaDadosQuestoesMusicas metodoRetornaQuestaoTecnologias = new C_PerguntaDadosQuestoesMusicas(passa);
                MessageBox.Show("Resposta certa:  " + "(" + respostaCerta + ")", "Tempo Esgotado");

                rb_perguntaA.Checked = false;
                rb_perguntaB.Checked = false;
                rb_perguntaC.Checked = false;
                rb_perguntaD.Checked = false;

                QuestaoCinema();

                if (passa == 11)
                {
                    questaoFinal();
                }
            }
        }
        //METODO QUESTAO FINAL, ONDE É EXIBIDO PONTUAÇÃO ACERTOS.
        private void questaoFinal()
        {
            timer1.Stop();
            lb_tempo.Visible = false;
            progressBar12.Visible = false;
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

            //VERIFICA SE EXISTE JÁ UMA PONTUAÇÃO NO RANK // CASO EXISTE O SISTEMA VERIFICA SE A PONTUAÇÃO FINAL É MAIOR QUE A PONTUAÇÃO NO BANCO DE DADOS
            if (rank._temdados)
            {
                int pontuacaoBanco = Convert.ToInt32(rank.metodoRetornaPontuacao());

                if (pontos > pontuacaoBanco)
                {
                    MessageBox.Show("Você bateu um novo record \n Pontuação: " +pontuacaoBanco+ "\n Nova Pontuação: " +pontos,"Parabéeens!!");
                    rank.UpdatePontuacao(pontos);                    
                }
            }
            //CASO NÃO EXISTA UMA PONTUAÇÃO CADASTRADA NO BANCO O SISTEMA INSERE OS DADOS NA TABELA
            else
            {
                rank.CadastrarRanking(pontos);
            }
        }
        //METODO DE CASES A CADA QUESTÃO NOVA O PRGESSBAR É ZERADO
        private void cases()
        {
            switch (questaoRodada)
            {
                case 0:
                    timer1.Start();
                    break;
                case 1:

                    timer1.Start();
                    break;
                case 2:
                    this.progressBar12.Value = 100;
                    timer1.Start();
                    break;

                case 3:
                    this.progressBar12.Value = 100;
                    timer1.Start();
                    break;

                case 4:
                    this.progressBar12.Value = 100;
                    timer1.Start();
                    break;

                case 5:
                    this.progressBar12.Value = 100;
                    timer1.Start();
                    break;

                case 6:
                    this.progressBar12.Value = 100;
                    timer1.Start();
                    break;

                case 7:
                    this.progressBar12.Value = 100;
                    timer1.Start();
                    break;

                case 8:
                    this.progressBar12.Value = 100;
                    timer1.Start();
                    break;

                case 9:
                    this.progressBar12.Value = 100;
                    timer1.Start();
                    break;

                case 10:
                    this.progressBar12.Value = 100;
                    timer1.Start();
                    break;
            }
        }
    }
}
