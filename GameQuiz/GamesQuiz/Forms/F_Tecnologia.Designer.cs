namespace GamesQuiz.Forms
{
    partial class F_Tecnologia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rb_perguntaD = new System.Windows.Forms.RadioButton();
            this.rb_perguntaA = new System.Windows.Forms.RadioButton();
            this.rb_perguntaC = new System.Windows.Forms.RadioButton();
            this.rb_perguntaB = new System.Windows.Forms.RadioButton();
            this.lb_Pergunta = new System.Windows.Forms.Label();
            this.btn_avancar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lb_tempo = new System.Windows.Forms.Label();
            this.lb_questao = new System.Windows.Forms.Label();
            this.lb_pontos = new System.Windows.Forms.Label();
            this.lb_questaov = new System.Windows.Forms.Label();
            this.lb_pontosv = new System.Windows.Forms.Label();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_novamente = new System.Windows.Forms.Button();
            this.lb_questCertas = new System.Windows.Forms.Label();
            this.lb_numequest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_pontScore = new System.Windows.Forms.Label();
            this.lb_score = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_perguntaD
            // 
            this.rb_perguntaD.AutoSize = true;
            this.rb_perguntaD.BackColor = System.Drawing.Color.Transparent;
            this.rb_perguntaD.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11F);
            this.rb_perguntaD.ForeColor = System.Drawing.Color.White;
            this.rb_perguntaD.Location = new System.Drawing.Point(15, 470);
            this.rb_perguntaD.Name = "rb_perguntaD";
            this.rb_perguntaD.Size = new System.Drawing.Size(122, 24);
            this.rb_perguntaD.TabIndex = 49;
            this.rb_perguntaD.TabStop = true;
            this.rb_perguntaD.Text = "radioButton4";
            this.rb_perguntaD.UseVisualStyleBackColor = false;
            this.rb_perguntaD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rb_perguntaD_MouseClick);
            // 
            // rb_perguntaA
            // 
            this.rb_perguntaA.AutoSize = true;
            this.rb_perguntaA.BackColor = System.Drawing.Color.Transparent;
            this.rb_perguntaA.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11F);
            this.rb_perguntaA.ForeColor = System.Drawing.Color.White;
            this.rb_perguntaA.Location = new System.Drawing.Point(15, 335);
            this.rb_perguntaA.Name = "rb_perguntaA";
            this.rb_perguntaA.Size = new System.Drawing.Size(122, 24);
            this.rb_perguntaA.TabIndex = 46;
            this.rb_perguntaA.TabStop = true;
            this.rb_perguntaA.Text = "radioButton1";
            this.rb_perguntaA.UseVisualStyleBackColor = false;
            this.rb_perguntaA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rb_perguntaA_MouseClick);
            // 
            // rb_perguntaC
            // 
            this.rb_perguntaC.AutoSize = true;
            this.rb_perguntaC.BackColor = System.Drawing.Color.Transparent;
            this.rb_perguntaC.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11F);
            this.rb_perguntaC.ForeColor = System.Drawing.Color.White;
            this.rb_perguntaC.Location = new System.Drawing.Point(15, 429);
            this.rb_perguntaC.Name = "rb_perguntaC";
            this.rb_perguntaC.Size = new System.Drawing.Size(122, 24);
            this.rb_perguntaC.TabIndex = 48;
            this.rb_perguntaC.TabStop = true;
            this.rb_perguntaC.Text = "radioButton3";
            this.rb_perguntaC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_perguntaC.UseVisualStyleBackColor = false;
            this.rb_perguntaC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rb_perguntaC_MouseClick);
            // 
            // rb_perguntaB
            // 
            this.rb_perguntaB.AutoSize = true;
            this.rb_perguntaB.BackColor = System.Drawing.Color.Transparent;
            this.rb_perguntaB.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11F);
            this.rb_perguntaB.ForeColor = System.Drawing.Color.White;
            this.rb_perguntaB.Location = new System.Drawing.Point(15, 383);
            this.rb_perguntaB.Name = "rb_perguntaB";
            this.rb_perguntaB.Size = new System.Drawing.Size(122, 24);
            this.rb_perguntaB.TabIndex = 47;
            this.rb_perguntaB.TabStop = true;
            this.rb_perguntaB.Text = "radioButton2";
            this.rb_perguntaB.UseVisualStyleBackColor = false;
            this.rb_perguntaB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rb_perguntaB_MouseClick);
            // 
            // lb_Pergunta
            // 
            this.lb_Pergunta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Pergunta.BackColor = System.Drawing.Color.Transparent;
            this.lb_Pergunta.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F);
            this.lb_Pergunta.ForeColor = System.Drawing.Color.White;
            this.lb_Pergunta.Location = new System.Drawing.Point(128, 184);
            this.lb_Pergunta.Name = "lb_Pergunta";
            this.lb_Pergunta.Size = new System.Drawing.Size(531, 105);
            this.lb_Pergunta.TabIndex = 44;
            this.lb_Pergunta.Text = "label5";
            this.lb_Pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_avancar
            // 
            this.btn_avancar.BackColor = System.Drawing.Color.Transparent;
            this.btn_avancar.FlatAppearance.BorderSize = 0;
            this.btn_avancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avancar.Image = global::GamesQuiz.Properties.Resources.Avancar1;
            this.btn_avancar.Location = new System.Drawing.Point(745, 430);
            this.btn_avancar.Name = "btn_avancar";
            this.btn_avancar.Size = new System.Drawing.Size(70, 64);
            this.btn_avancar.TabIndex = 43;
            this.btn_avancar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_avancar.UseVisualStyleBackColor = false;
            this.btn_avancar.Click += new System.EventHandler(this.btn_avancar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.ForeColor = System.Drawing.Color.DarkRed;
            this.progressBar1.Location = new System.Drawing.Point(77, 53);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(149, 16);
            this.progressBar1.TabIndex = 71;
            this.progressBar1.Value = 100;
            // 
            // lb_tempo
            // 
            this.lb_tempo.AutoSize = true;
            this.lb_tempo.BackColor = System.Drawing.Color.Transparent;
            this.lb_tempo.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11F);
            this.lb_tempo.ForeColor = System.Drawing.Color.White;
            this.lb_tempo.Location = new System.Drawing.Point(12, 50);
            this.lb_tempo.Name = "lb_tempo";
            this.lb_tempo.Size = new System.Drawing.Size(60, 20);
            this.lb_tempo.TabIndex = 70;
            this.lb_tempo.Text = "Tempo:";
            // 
            // lb_questao
            // 
            this.lb_questao.AutoSize = true;
            this.lb_questao.BackColor = System.Drawing.Color.Transparent;
            this.lb_questao.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11F);
            this.lb_questao.ForeColor = System.Drawing.Color.White;
            this.lb_questao.Location = new System.Drawing.Point(445, 50);
            this.lb_questao.Name = "lb_questao";
            this.lb_questao.Size = new System.Drawing.Size(18, 20);
            this.lb_questao.TabIndex = 69;
            this.lb_questao.Text = "0";
            // 
            // lb_pontos
            // 
            this.lb_pontos.AutoSize = true;
            this.lb_pontos.BackColor = System.Drawing.Color.Transparent;
            this.lb_pontos.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11F);
            this.lb_pontos.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lb_pontos.Location = new System.Drawing.Point(772, 46);
            this.lb_pontos.Name = "lb_pontos";
            this.lb_pontos.Size = new System.Drawing.Size(18, 20);
            this.lb_pontos.TabIndex = 68;
            this.lb_pontos.Text = "0";
            // 
            // lb_questaov
            // 
            this.lb_questaov.AutoSize = true;
            this.lb_questaov.BackColor = System.Drawing.Color.Transparent;
            this.lb_questaov.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11F);
            this.lb_questaov.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_questaov.Location = new System.Drawing.Point(366, 50);
            this.lb_questaov.Name = "lb_questaov";
            this.lb_questaov.Size = new System.Drawing.Size(73, 20);
            this.lb_questaov.TabIndex = 67;
            this.lb_questaov.Text = "Questão:";
            // 
            // lb_pontosv
            // 
            this.lb_pontosv.AutoSize = true;
            this.lb_pontosv.BackColor = System.Drawing.Color.Transparent;
            this.lb_pontosv.Font = new System.Drawing.Font("Franklin Gothic Heavy", 11F);
            this.lb_pontosv.ForeColor = System.Drawing.Color.White;
            this.lb_pontosv.Location = new System.Drawing.Point(702, 46);
            this.lb_pontosv.Name = "lb_pontosv";
            this.lb_pontosv.Size = new System.Drawing.Size(64, 20);
            this.lb_pontosv.TabIndex = 66;
            this.lb_pontosv.Text = "Pontos:";
            // 
            // btn_menu
            // 
            this.btn_menu.AutoSize = true;
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.5F);
            this.btn_menu.ForeColor = System.Drawing.Color.Transparent;
            this.btn_menu.Image = global::GamesQuiz.Properties.Resources.icon_home;
            this.btn_menu.Location = new System.Drawing.Point(458, 329);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(66, 66);
            this.btn_menu.TabIndex = 78;
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Visible = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_novamente
            // 
            this.btn_novamente.AutoSize = true;
            this.btn_novamente.BackColor = System.Drawing.Color.Transparent;
            this.btn_novamente.BackgroundImage = global::GamesQuiz.Properties.Resources.icon_return;
            this.btn_novamente.FlatAppearance.BorderSize = 0;
            this.btn_novamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novamente.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.5F);
            this.btn_novamente.ForeColor = System.Drawing.Color.Transparent;
            this.btn_novamente.Location = new System.Drawing.Point(338, 335);
            this.btn_novamente.Name = "btn_novamente";
            this.btn_novamente.Size = new System.Drawing.Size(60, 60);
            this.btn_novamente.TabIndex = 77;
            this.btn_novamente.UseVisualStyleBackColor = false;
            this.btn_novamente.Visible = false;
            this.btn_novamente.Click += new System.EventHandler(this.btn_novamente_Click);
            // 
            // lb_questCertas
            // 
            this.lb_questCertas.AutoSize = true;
            this.lb_questCertas.BackColor = System.Drawing.Color.Transparent;
            this.lb_questCertas.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F);
            this.lb_questCertas.ForeColor = System.Drawing.Color.White;
            this.lb_questCertas.Location = new System.Drawing.Point(439, 193);
            this.lb_questCertas.Name = "lb_questCertas";
            this.lb_questCertas.Size = new System.Drawing.Size(154, 24);
            this.lb_questCertas.TabIndex = 76;
            this.lb_questCertas.Text = "de 10 perguntas";
            this.lb_questCertas.Visible = false;
            // 
            // lb_numequest
            // 
            this.lb_numequest.AutoSize = true;
            this.lb_numequest.BackColor = System.Drawing.Color.Transparent;
            this.lb_numequest.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F);
            this.lb_numequest.ForeColor = System.Drawing.Color.White;
            this.lb_numequest.Location = new System.Drawing.Point(274, 192);
            this.lb_numequest.Name = "lb_numequest";
            this.lb_numequest.Size = new System.Drawing.Size(143, 25);
            this.lb_numequest.TabIndex = 75;
            this.lb_numequest.Text = "Você acertou:";
            this.lb_numequest.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F);
            this.label4.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Location = new System.Drawing.Point(418, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "0";
            this.label4.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 120;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_pontScore
            // 
            this.lb_pontScore.AutoSize = true;
            this.lb_pontScore.BackColor = System.Drawing.Color.Transparent;
            this.lb_pontScore.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F);
            this.lb_pontScore.ForeColor = System.Drawing.Color.White;
            this.lb_pontScore.Location = new System.Drawing.Point(397, 242);
            this.lb_pontScore.Name = "lb_pontScore";
            this.lb_pontScore.Size = new System.Drawing.Size(72, 25);
            this.lb_pontScore.TabIndex = 79;
            this.lb_pontScore.Text = "Score:";
            this.lb_pontScore.Visible = false;
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.BackColor = System.Drawing.Color.Transparent;
            this.lb_score.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14F);
            this.lb_score.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lb_score.Location = new System.Drawing.Point(415, 274);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(21, 24);
            this.lb_score.TabIndex = 80;
            this.lb_score.Text = "0";
            this.lb_score.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(794, 6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(23, 24);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 41);
            this.panel1.TabIndex = 93;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // F_Tecnologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GamesQuiz.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(827, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.lb_pontScore);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_novamente);
            this.Controls.Add(this.lb_questCertas);
            this.Controls.Add(this.lb_numequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lb_tempo);
            this.Controls.Add(this.lb_questao);
            this.Controls.Add(this.lb_pontos);
            this.Controls.Add(this.lb_questaov);
            this.Controls.Add(this.lb_pontosv);
            this.Controls.Add(this.rb_perguntaD);
            this.Controls.Add(this.rb_perguntaA);
            this.Controls.Add(this.rb_perguntaC);
            this.Controls.Add(this.rb_perguntaB);
            this.Controls.Add(this.lb_Pergunta);
            this.Controls.Add(this.btn_avancar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Tecnologia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.F_Tecnologia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_perguntaD;
        private System.Windows.Forms.RadioButton rb_perguntaA;
        private System.Windows.Forms.RadioButton rb_perguntaC;
        private System.Windows.Forms.RadioButton rb_perguntaB;
        private System.Windows.Forms.Label lb_Pergunta;
        private System.Windows.Forms.Button btn_avancar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lb_tempo;
        private System.Windows.Forms.Label lb_questao;
        private System.Windows.Forms.Label lb_pontos;
        private System.Windows.Forms.Label lb_questaov;
        private System.Windows.Forms.Label lb_pontosv;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_novamente;
        private System.Windows.Forms.Label lb_questCertas;
        private System.Windows.Forms.Label lb_numequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_pontScore;
        private System.Windows.Forms.Label lb_score;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btn_close;
    }
}