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
using GamesQuiz.DataPlayer;

namespace GamesQuiz.Forms
{
    public partial class F_PainelAdministrador : Form
    {
        public F_PainelAdministrador()
        {
            InitializeComponent();
        }

        //LOAD DATAGRID 
        private void F_PainelAdministrador_Load_2(object sender, EventArgs e)
        {
            MetodoDataGridUsuario();
            MetodoDataGridMedicina();
            MetodoDataGridCinema();
            MetodoDataGridMusica();
            MetodoDataGridTecnologia();
        }

        private void cb_tipoUsuario_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        // BOTÃO CADASTRAR USUÁRIOS

        private void btn_cUsuario_Click(object sender, EventArgs e)
        {
         
                if (tb_tipo.Text == "0")
                {
                    C_ControlePlayerDados dadosCadatrar = new C_ControlePlayerDados();
                    C_DalPlayerDados dal = new C_DalPlayerDados();

                 //   dadosCadatrar.ID = Convert.ToInt32(tb_idPlayer.Text);
                    dadosCadatrar.Nome = tb_usuario.Text;
                    dadosCadatrar.Senha = tb_senha.Text;

                    dal.CadastrarJogador(dadosCadatrar);
                    MessageBox.Show("Cadastro realizado com sucesso!!", "Parabéns!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    LimparTextBoxUsuario();
                    MetodoDataGridUsuario();
                }
                if (tb_tipo.Text == "1")
                {
                    C_ControleDadosF dadosAdm = new C_ControleDadosF();
                    C_DalPlayerDados dals = new C_DalPlayerDados();

                  // dadosAdm.ID = Convert.ToInt32(tb_idPlayer.Text);
                    dadosAdm.Nome = tb_usuario.Text;
                    dadosAdm.Senha = tb_senha.Text;
                    dadosAdm.Codigo = Convert.ToInt32(tb_tipo.Text);

                    dals.CadastrarAdministrador(dadosAdm);
                    MessageBox.Show("Cadastro realizado com sucesso!!", "Parabéns!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    LimparTextBoxUsuario();
                    MetodoDataGridUsuario();
                }
           
            
        }

        //BOTÃO ALTERAR USUÁRIOS
        private void btn_cAlterar_Click(object sender, EventArgs e)
        {
            C_ControleDadosF dadosAdm = new C_ControleDadosF();
            C_ControlePlayerDados dadosAltera = new C_ControlePlayerDados();
            C_DalPlayerDados dals = new C_DalPlayerDados();

            try
            {
                if (tb_tipo.Text != "")
                {
                    dadosAdm.ID_Player =tb_idPlayer.Text;
                    dadosAdm.Nome = tb_usuario.Text;
                    dadosAdm.Senha = tb_senha.Text;
                    dadosAdm.Codigo = Convert.ToInt32(tb_tipo.Text);
                    dals.EditarUsuario(dadosAdm);
                    MessageBox.Show("Dados Alterado com sucesso!!", "Parabéns!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MetodoDataGridUsuario();
                    LimparTextBoxUsuario();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        //BOTÃO DELETAR USUÁRIO
        private void btn_cDeletar_Click(object sender, EventArgs e)
        {
            C_ControleDadosF dadosAdm = new C_ControleDadosF();
            C_ControlePlayerDados dadosAltera = new C_ControlePlayerDados();
            C_DalPlayerDados dals = new C_DalPlayerDados();
            try
            {
                dadosAdm.Nome = tb_usuario.Text;
                dals.ExcluirUsuario(dadosAdm);
                MessageBox.Show("Dados apagado com sucesso!!", "Parabéns!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MetodoDataGridUsuario();
                LimparTextBoxUsuario();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //METODO DE EXIBIR TODOS USUÁRIOS CADASTRADOS
        private void MetodoDataGridUsuario()
        {
            try
            {
                C_DalPlayerDados dadadosUsuario = new C_DalPlayerDados();
                dataGrid_Usuarios.DataSource = dadadosUsuario.ConsultaDeDados();
                dataGrid_Usuarios.FirstDisplayedScrollingRowIndex = dataGrid_Usuarios.RowCount - 1;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //EVENTO DE EXIBIR DADOS DOS USUÁRIOS NO DATAGRID NOS TEXTBOXS
        private void dataGrid_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGrid_Usuarios.Rows[e.RowIndex];
            tb_idPlayer.Text = row.Cells[0].Value.ToString();
            tb_usuario.Text = row.Cells[1].Value.ToString();
            tb_senha.Text = row.Cells[2].Value.ToString();
            tb_tipo.Text = row.Cells[3].Value.ToString();
        }

        private void LimparTextBoxUsuario()
        {
            tb_idPlayer.Clear();
            tb_tipo.Clear();
            tb_usuario.Clear();
            tb_senha.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //CADASTRAR QUESTÕES MEDICINA
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarMed = new C_ControleQuestoesDados();
            C_DalQuestoesDados dalMed = new C_DalQuestoesDados();

            try
            {
                if (tb_idPergunta.Text != "" && tb_pergunta.Text != "" && tb_questaoA.Text != "" && tb_questaoB.Text != "" && tb_questaoC.Text != "" && tb_questaoD.Text != "" && tb_resposta.Text != "")
                {
                    cadastrarMed.ID_Pergunta = Convert.ToInt32(tb_idPergunta.Text);
                    cadastrarMed.Pergunta = tb_pergunta.Text;
                    cadastrarMed.QuestaoA = tb_questaoA.Text;
                    cadastrarMed.QuestaoB = tb_questaoB.Text;
                    cadastrarMed.QuestaoC = tb_questaoC.Text;
                    cadastrarMed.QuestaoD = tb_questaoD.Text;
                    cadastrarMed.Resposta = tb_resposta.Text;

                    dalMed.CadastrarQuestoesMedicina(cadastrarMed);

                    LimparTextBox();
                    MetodoDataGridMedicina();
                    MessageBox.Show("Cadastro realizado com sucesso!!", "Parabéns!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Existem campos vazios!Por favor preencha corretamente para o acesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception erro)
            {
                throw new ApplicationException(erro.Message);
            }
        }

        //ALTERAR QUESTÕES MEDICINA
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarMed = new C_ControleQuestoesDados();
            C_DalQuestoesDados dalMed = new C_DalQuestoesDados();

            if (tb_idPergunta.Text != "")
            {
                try
                {
                    cadastrarMed.ID_Pergunta = Convert.ToInt32(tb_idPergunta.Text);
                    cadastrarMed.Pergunta = tb_pergunta.Text;
                    cadastrarMed.QuestaoA = tb_questaoA.Text;
                    cadastrarMed.QuestaoB = tb_questaoB.Text;
                    cadastrarMed.QuestaoC = tb_questaoC.Text;
                    cadastrarMed.QuestaoD = tb_questaoD.Text;
                    cadastrarMed.Resposta = tb_resposta.Text;

                    dalMed.EditarQuestaoMedicina(cadastrarMed);
                    MessageBox.Show("Dados alterados com sucesso");
                    MetodoDataGridMedicina();
                    LimparTextBox();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Para alterar um dado é necessário inserir o valor do ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //DELETAR QUESTÕES MEDICINA
        private void btn_mDeletar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarMed = new C_ControleQuestoesDados();
            C_DalQuestoesDados dalMed = new C_DalQuestoesDados();

            if (tb_idPergunta.Text != "")
            {
                try
                {
                    cadastrarMed.ID_Pergunta = Convert.ToInt32(tb_idPergunta.Text);

                    dalMed.DeletarQuestaoMedicina(cadastrarMed);
                    MessageBox.Show("Dados deletado com sucesso");
                    MetodoDataGridMedicina();
                    LimparTextBox();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Para apagar um dado é necessário inserir o valor do ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //EVENTO DE CARREGAR DADOS DO DATAGRID NO TEXTBOX'S MEDICINA
        private void dataGrid_ConteudoMedicina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGrid_ConteudoMedicina.Rows[e.RowIndex];
            tb_idPergunta.Text = row.Cells[0].Value.ToString();
            tb_pergunta.Text = row.Cells[1].Value.ToString();
            tb_questaoA.Text = row.Cells[2].Value.ToString();
            tb_questaoB.Text = row.Cells[3].Value.ToString();
            tb_questaoC.Text = row.Cells[4].Value.ToString();
            tb_questaoD.Text = row.Cells[5].Value.ToString();
            tb_resposta.Text = row.Cells[6].Value.ToString();
        }


        //METODO DE CARREGAR DADOS CADASTRADOS NO DATAGRID MEDICINA
        private void MetodoDataGridMedicina()
        {
            try
            {
                C_DalQuestoesDados dadosMedicina = new C_DalQuestoesDados();
                dataGrid_ConteudoMedicina.DataSource = dadosMedicina.ConsultaDeDados();
                dataGrid_ConteudoMedicina.FirstDisplayedScrollingRowIndex = dataGrid_ConteudoMedicina.RowCount - 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void LimparTextBox()
        {
            tb_idPergunta.Clear();
            tb_pergunta.Clear();
            tb_questaoA.Clear();
            tb_questaoB.Clear();
            tb_questaoC.Clear();
            tb_questaoD.Clear();
            tb_resposta.Clear();
        }


        //CADASTRAR QUESTOES MÚSICA
        private void btn_MuCadastrar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarMusica = new C_ControleQuestoesDados();
            C_DalQuestoesDadosMusica dalMusica = new C_DalQuestoesDadosMusica();

            try
            {
                if (tb_MuId.Text != "" && tb_MuPergunta.Text != "" && tb_MuQuestaoA.Text != "" && tb_MuQuestaoB.Text != "" && tb_MuQuestaoC.Text != "" && tb_MuQuestaoD.Text != "" && tb_MuResposta.Text != "")
                {
                    cadastrarMusica.ID_Pergunta = Convert.ToInt32(tb_MuId.Text);
                    cadastrarMusica.Pergunta = tb_MuPergunta.Text;
                    cadastrarMusica.QuestaoA = tb_MuQuestaoA.Text;
                    cadastrarMusica.QuestaoB = tb_MuQuestaoB.Text;
                    cadastrarMusica.QuestaoC = tb_MuQuestaoC.Text;
                    cadastrarMusica.QuestaoD = tb_MuQuestaoD.Text;
                    cadastrarMusica.Resposta = tb_MuResposta.Text;

                    dalMusica.CadastrarQuestoesCinema(cadastrarMusica);

                    LimparTextBoxMusica();
                    MetodoDataGridMusica();
                    MessageBox.Show("Cadastro realizado com sucesso!!", "Parabéns!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Existem campos vazios!Por favor preencha corretamente para o acesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception erro)
            {
                throw new ApplicationException(erro.Message);
            }
        }

        //BOTAO ALTERAR DADOS 
        private void btn_MuAlterar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarMusica = new C_ControleQuestoesDados();
            C_DalQuestoesDadosMusica dalMusica = new C_DalQuestoesDadosMusica();

            if (tb_MuId.Text != "")
            {
                try
                {
                    cadastrarMusica.ID_Pergunta = Convert.ToInt32(tb_MuId.Text);
                    cadastrarMusica.Pergunta = tb_MuPergunta.Text;
                    cadastrarMusica.QuestaoA = tb_MuQuestaoA.Text;
                    cadastrarMusica.QuestaoB = tb_MuQuestaoB.Text;
                    cadastrarMusica.QuestaoC = tb_MuQuestaoC.Text;
                    cadastrarMusica.QuestaoD = tb_MuQuestaoD.Text;
                    cadastrarMusica.Resposta = tb_MuResposta.Text;

                    dalMusica.EditarQuestaoCinema(cadastrarMusica);
                    MessageBox.Show("Dados alterado com sucesso");
                    MetodoDataGridMusica();
                    LimparTextBoxMusica();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Para alterar um dado é necessário inserir o valor do ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_MuDeletar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarMusica = new C_ControleQuestoesDados();
            C_DalQuestoesDadosMusica dalMusica = new C_DalQuestoesDadosMusica();

            if (tb_MuId.Text != "")
            {
                try
                {
                    cadastrarMusica.ID_Pergunta = Convert.ToInt32(tb_MuId.Text);

                    dalMusica.DeletarQuestaoCinema(cadastrarMusica);
                    MessageBox.Show("Dados deletado com sucesso");
                    MetodoDataGridMusica();
                    LimparTextBoxMusica();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Para apagar um dado é necessário inserir o valor do ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //EXIBIR DADOS DO DATAGRID NO TEXTBOX MÚSICA
        private void dataGrid_ConteudoMusica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGrid_ConteudoMusica.Rows[e.RowIndex];
            tb_MuId.Text = row.Cells[0].Value.ToString();
            tb_MuPergunta.Text = row.Cells[1].Value.ToString();
            tb_MuQuestaoA.Text = row.Cells[2].Value.ToString();
            tb_MuQuestaoB.Text = row.Cells[3].Value.ToString();
            tb_MuQuestaoC.Text = row.Cells[4].Value.ToString();
            tb_MuQuestaoD.Text = row.Cells[5].Value.ToString();
            tb_MuResposta.Text = row.Cells[6].Value.ToString();
        }

        //METODO DE CARREGAR DADOS CADASTRADOS NO DATAGRID MÚSICA
        private void MetodoDataGridMusica()
        {
            try
            {
                C_DalQuestoesDadosMusica dadosMusica = new C_DalQuestoesDadosMusica();
                dataGrid_ConteudoMusica.DataSource = dadosMusica.ConsultaDeDados();
                dataGrid_ConteudoMusica.FirstDisplayedScrollingRowIndex = dataGrid_ConteudoMusica.RowCount - 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void LimparTextBoxMusica()
        {
            tb_MuId.Clear();
            tb_MuPergunta.Clear();
            tb_MuQuestaoA.Clear();
            tb_MuQuestaoB.Clear();
            tb_MuQuestaoC.Clear();
            tb_MuQuestaoD.Clear();
            tb_MuResposta.Clear();
        }

        //CADASTRAR QUESTÕES CINEMA
        private void btn_cCadastrar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarCinema = new C_ControleQuestoesDados();
            C_DalQuestoesDadosCinema dalCinema = new C_DalQuestoesDadosCinema();
            try
            {
                if (tb_cID.Text != "" && tb_cPergunta.Text != "" && tb_cquestaoA.Text != "" && tb_cquestaoB.Text != "" && tb_cquestaoC.Text != "" && tb_cquestaoD.Text != "" && tb_cresposta.Text != "")
                {
                    cadastrarCinema.ID_Pergunta = Convert.ToInt32(tb_cID.Text);
                    cadastrarCinema.Pergunta = tb_cPergunta.Text;
                    cadastrarCinema.QuestaoA = tb_cquestaoA.Text;
                    cadastrarCinema.QuestaoB = tb_cquestaoB.Text;
                    cadastrarCinema.QuestaoC = tb_cquestaoC.Text;
                    cadastrarCinema.QuestaoD = tb_cquestaoD.Text;
                    cadastrarCinema.Resposta = tb_cresposta.Text;

                    dalCinema.CadastrarQuestoesCinema(cadastrarCinema);

                    LimparTextBoxCinema();
                    MetodoDataGridCinema();
                    MessageBox.Show("Cadastro realizado com sucesso!!", "Parabéns!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Existem campos vazios!Por favor preencha corretamente para o acesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception erro)
            {
                throw new ApplicationException(erro.Message);
            }
        }

        //BOTÃO ALTERAR QUESTÕES CINEMA
        private void btn_csAlterar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarCinema = new C_ControleQuestoesDados();
            C_DalQuestoesDadosCinema dalCinema = new C_DalQuestoesDadosCinema();

            if (tb_cID.Text != "")
            {
                try
                {
                    cadastrarCinema.ID_Pergunta = Convert.ToInt32(tb_cID.Text);
                    cadastrarCinema.Pergunta = tb_cPergunta.Text;
                    cadastrarCinema.QuestaoA = tb_cquestaoA.Text;
                    cadastrarCinema.QuestaoB = tb_cquestaoB.Text;
                    cadastrarCinema.QuestaoC = tb_cquestaoC.Text;
                    cadastrarCinema.QuestaoD = tb_cquestaoD.Text;
                    cadastrarCinema.Resposta = tb_cresposta.Text;

                    dalCinema.EditarQuestaoCinema(cadastrarCinema);
                    MessageBox.Show("Dados alterados com sucesso");
                    MetodoDataGridCinema();

                    LimparTextBoxCinema();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Para alterar um dado é necessário inserir o valor do ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //BOTÃO DELETAR QUESTÕES CINEMA
        private void btn_csDeletar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarCinema = new C_ControleQuestoesDados();
            C_DalQuestoesDadosCinema dalCinema = new C_DalQuestoesDadosCinema();

            if (tb_cID.Text != "")
            {
                try
                {
                    cadastrarCinema.ID_Pergunta = Convert.ToInt32(tb_cID.Text);

                    dalCinema.DeletarQuestaoCinema(cadastrarCinema);
                    MessageBox.Show("Dados deletado com sucesso");
                    MetodoDataGridCinema();
                    LimparTextBoxCinema();
                }
                catch (Exception erro)
                {
                    throw new ApplicationException(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Para apagar um dado é necessário inserir o valor do ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //EXIBIR DADOS NOS TEXTBOX DO DATAGRID CINEMA
        private void dataGrid_ConteudoCinema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
             
            DataGridViewRow row = dataGrid_ConteudoTecnologia.Rows[e.RowIndex];
            tb_cID.Text = row.Cells[0].Value.ToString();
            tb_cPergunta.Text = row.Cells[1].Value.ToString();
            tb_cquestaoA.Text = row.Cells[2].Value.ToString();
            tb_cquestaoB.Text = row.Cells[3].Value.ToString();
            tb_cquestaoC.Text = row.Cells[4].Value.ToString();
            tb_cquestaoD.Text = row.Cells[5].Value.ToString();
            tb_cresposta.Text = row.Cells[6].Value.ToString();
        }

        //METODO DE CARREGAR DADOS CADASTRADO NO DATAGRID
        private void MetodoDataGridCinema()
        {
            try
            {
                C_DalQuestoesDadosCinema dadosCinema = new C_DalQuestoesDadosCinema();
                dataGrid_ConteudoCinema.DataSource = dadosCinema.ConsultaDeDados();
                dataGrid_ConteudoCinema.FirstDisplayedScrollingRowIndex = dataGrid_ConteudoCinema.RowCount - 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void LimparTextBoxCinema()
        {
            tb_cID.Clear();
            tb_cPergunta.Clear();
            tb_cquestaoA.Clear();
            tb_cquestaoB.Clear();
            tb_cquestaoC.Clear();
            tb_cquestaoD.Clear();
            tb_cresposta.Clear();
        }


        //BOTÃO CADASTRAR QUESTÕES TECNOLOGIA
        private void btn_TeCadastrar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarTecnologia = new C_ControleQuestoesDados();
            C_DalQuestoesDadosTecnologia dalTecnologia = new C_DalQuestoesDadosTecnologia();

            try
            {
                if (tb_TeId.Text != "" && tb_TePergunta.Text != "" && tb_TeQuestaoA.Text != "" && tb_TeQuestaoB.Text != "" && tb_TeQuestaoC.Text != "" && tb_TeQuestaoD.Text != "" && tb_TeResposta.Text != "")
                {
                    cadastrarTecnologia.ID_Pergunta = Convert.ToInt32(tb_TeId.Text);
                    cadastrarTecnologia.Pergunta = tb_TePergunta.Text;
                    cadastrarTecnologia.QuestaoA = tb_TeQuestaoA.Text;
                    cadastrarTecnologia.QuestaoB = tb_TeQuestaoB.Text;
                    cadastrarTecnologia.QuestaoC = tb_TeQuestaoC.Text;
                    cadastrarTecnologia.QuestaoD = tb_TeQuestaoD.Text;
                    cadastrarTecnologia.Resposta = tb_TeResposta.Text;

                    dalTecnologia.CadastrarQuestoesCinema(cadastrarTecnologia);

                    MetodoDataGridTecnologia();
                    MessageBox.Show("Cadastro realizado com sucesso!!", "Parabéns!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ApagarTecnologia();
                }
                else
                {
                    MessageBox.Show("Existem campos vazios!Por favor preencha corretamente para o acesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception erro)
            {
                throw new ApplicationException(erro.Message);
            }
        }

        //BOTÃO ALTERAR QUESTÕES TECNOLOGIA
        private void btn_TeAlterar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarTecnologia = new C_ControleQuestoesDados();
            C_DalQuestoesDadosTecnologia dalTecnologia = new C_DalQuestoesDadosTecnologia();
            try
            {
                if (tb_TeId.Text != "")
                {
                    cadastrarTecnologia.ID_Pergunta = Convert.ToInt32(tb_TeId.Text);
                    cadastrarTecnologia.Pergunta = tb_TePergunta.Text;
                    cadastrarTecnologia.QuestaoA = tb_TeQuestaoA.Text;
                    cadastrarTecnologia.QuestaoB = tb_TeQuestaoB.Text;
                    cadastrarTecnologia.QuestaoC = tb_TeQuestaoC.Text;
                    cadastrarTecnologia.QuestaoD = tb_TeQuestaoD.Text;
                    cadastrarTecnologia.Resposta = tb_TeResposta.Text;

                    dalTecnologia.EditarQuestaoTecnologia(cadastrarTecnologia);

                    MessageBox.Show("Dados Alterados com sucesso");
                    MetodoDataGridTecnologia();
                    ApagarTecnologia();
                }
                else
                {
                    MessageBox.Show("Para alterar um dado é necessário inserir o valor do ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        //BOTÃO DELETAR QUESTÕES TECNOLOGIA
        private void btn_TeDeletar_Click(object sender, EventArgs e)
        {
            C_ControleQuestoesDados cadastrarTecnologia = new C_ControleQuestoesDados();
            C_DalQuestoesDadosTecnologia dalTecnologia = new C_DalQuestoesDadosTecnologia();

            if (tb_TeId.Text != "")
            {
                try
                {
                    cadastrarTecnologia.ID_Pergunta = Convert.ToInt32(tb_TeId.Text);

                    dalTecnologia.DeletarQuestaoCinema(cadastrarTecnologia);
                    MessageBox.Show("Dados deletado com sucesso");
                    MetodoDataGridTecnologia();
                    ApagarTecnologia();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Para apagar um dado é necessário inserir o valor do ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //EXIBIR DADOS DO DATAGRID NO TEXTBOX TECNOLOGIA
        private void dataGrid_ConteudoTecnologia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGrid_ConteudoTecnologia.Rows[e.RowIndex];
            tb_TeId.Text = row.Cells[0].Value.ToString();
            tb_TePergunta.Text = row.Cells[1].Value.ToString();
            tb_TeQuestaoA.Text = row.Cells[2].Value.ToString();
            tb_TeQuestaoB.Text = row.Cells[3].Value.ToString();
            tb_TeQuestaoC.Text = row.Cells[4].Value.ToString();
            tb_TeQuestaoD.Text = row.Cells[5].Value.ToString();
            tb_TeResposta.Text = row.Cells[6].Value.ToString();
        }

        //METODO DE CARREGAR DADOS CADASTRADOS NO DATAGRID TECNOLOGIA
        private void MetodoDataGridTecnologia()
        {
            try
            {
                C_DalQuestoesDadosTecnologia dadosTecnologia = new C_DalQuestoesDadosTecnologia();
                dataGrid_ConteudoTecnologia.DataSource = dadosTecnologia.ConsultaDeDados();
                dataGrid_ConteudoTecnologia.FirstDisplayedScrollingRowIndex = dataGrid_ConteudoTecnologia.RowCount - 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void ApagarTecnologia()
        {
            tb_TeId.Clear();
            tb_TePergunta.Clear();
            tb_TeQuestaoA.Clear();
            tb_TeQuestaoB.Clear();
            tb_TeQuestaoC.Clear();
            tb_TeQuestaoD.Clear();
            tb_TeResposta.Clear();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();

            FormularioPrincipal formp = new FormularioPrincipal();

            formp.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            FormularioPrincipal forms = new FormularioPrincipal();
            forms.Show();
            this.Close();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }
    }
}


