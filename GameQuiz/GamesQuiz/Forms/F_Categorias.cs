using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesQuiz.DataPlayer;

namespace GamesQuiz.Forms
{
    public partial class F_Categorias : Form
    {       
        string caio;
        public F_Categorias(string guardaNome)
        {
            InitializeComponent();
            caio=guardaNome;
        }

        public F_Categorias()
        {
            InitializeComponent();
        }

        private void F_Categorias_Load(object sender, EventArgs e)
        {
            MetodoDataGridCinema();
        }

        private void btn_Medicina_Click(object sender, EventArgs e)
        {
            F_Medicina painelMedicina = new F_Medicina(caio);
            painelMedicina.Show();
            this.Close();
        }

        private void btn__Musicas_Click(object sender, EventArgs e)
        {
            F_Musicas painelMusica = new F_Musicas(caio);
            painelMusica.Show();
            this.Close();
        }

        private void btn_Tecnologia_Click(object sender, EventArgs e)
        {
            F_Tecnologia painelTecnologia = new F_Tecnologia(caio);
            painelTecnologia.Show();
            this.Close();
        }

        private void btn_Cinema_Click(object sender, EventArgs e)
        {
            F_Cinema painelCinema = new F_Cinema(caio);
            painelCinema.Show();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            FormularioPrincipal forms = new FormularioPrincipal();
            forms.Show();
            this.Close();
        }        

        private void MetodoDataGridCinema()
        {
            try
            {
                Rankings ranking = new Rankings();

                bunifuCustomDataGrid1.DataSource = ranking.ConsultaDeDados();
                bunifuCustomDataGrid1.FirstDisplayedScrollingRowIndex = bunifuCustomDataGrid1.RowCount - 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}
