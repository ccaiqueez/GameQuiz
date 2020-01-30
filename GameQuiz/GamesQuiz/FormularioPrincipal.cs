using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GamesQuiz.Forms;
using GamesQuiz.Connection;
using GamesQuiz.DataPlayer;

namespace GamesQuiz
{
    public partial class FormularioPrincipal : Form
    {
        string guardaNome;
        public FormularioPrincipal()
        {
            InitializeComponent();
            ArredondaCantosdoForm();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                C_ControlePlayerDados dadosAcessar = new C_ControlePlayerDados();
                C_DalPlayerDados dal = new C_DalPlayerDados();
                F_Categorias formCategorias = new F_Categorias(tb_usuario.Text);

                F_PainelAdministrador admPainel = new F_PainelAdministrador();

                dadosAcessar.Nome = tb_usuario.Text;
                dadosAcessar.Senha = tb_senha.Text;
                dal.VerificarLogin(dadosAcessar);

                if (dal._temdados && dal.dadosAcessoNivel(dadosAcessar) == 0)
                {
                    formCategorias.Show();
                    this.Hide();
                }
                else if (dal._temdados && dal.dadosAcessoNivel(dadosAcessar) == 1)
                {
                    admPainel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dados Inválidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void link_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_Cadastrar formCadastrar = new F_Cadastrar();
            formCadastrar.ShowDialog();
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
