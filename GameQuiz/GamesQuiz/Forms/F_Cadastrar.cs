using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesQuiz.DataPlayer;

namespace GamesQuiz.Forms
{
    public partial class F_Cadastrar : Form
    {
        public F_Cadastrar()
        {
            InitializeComponent();
            ArredondaCantosdoForm();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_usuario.Text != "" && tb_senha.Text != "")
                {
                    C_ControlePlayerDados dadosCadatrar = new C_ControlePlayerDados();
                    C_DalPlayerDados dal = new C_DalPlayerDados();

                    dadosCadatrar.Nome = tb_usuario.Text;
                    dadosCadatrar.Senha = tb_senha.Text;
                    dal.CadastrarJogador(dadosCadatrar);

                    MessageBox.Show("Cadastro realizado com sucesso!!", "Parabéns!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tb_usuario.Clear();
                    tb_senha.Clear();
                }
                else
                {
                    MessageBox.Show("Existem campos vazios!Por favor preencha corretamente para o acesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void ArredondaCantosdoForm()
        {
            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }
    }
}
