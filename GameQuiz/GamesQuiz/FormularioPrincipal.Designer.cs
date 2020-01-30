namespace GamesQuiz
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.link_cadastrar = new System.Windows.Forms.LinkLabel();
            this.pic_UserLogin = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_usuario
            // 
            this.tb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_usuario.Location = new System.Drawing.Point(13, 189);
            this.tb_usuario.Margin = new System.Windows.Forms.Padding(4, 9, 5, 9);
            this.tb_usuario.Multiline = true;
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(389, 47);
            this.tb_usuario.TabIndex = 3;
            this.tb_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.White;
            this.btn_entrar.Location = new System.Drawing.Point(12, 374);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(185, 46);
            this.btn_entrar.TabIndex = 11;
            this.btn_entrar.TabStop = false;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(216, 374);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(185, 46);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.TabStop = false;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tb_senha
            // 
            this.tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_senha.Location = new System.Drawing.Point(12, 275);
            this.tb_senha.Margin = new System.Windows.Forms.Padding(4, 9, 5, 9);
            this.tb_senha.Multiline = true;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(389, 47);
            this.tb_senha.TabIndex = 13;
            this.tb_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // link_cadastrar
            // 
            this.link_cadastrar.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.link_cadastrar.AutoSize = true;
            this.link_cadastrar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.link_cadastrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_cadastrar.LinkColor = System.Drawing.Color.White;
            this.link_cadastrar.Location = new System.Drawing.Point(315, 339);
            this.link_cadastrar.Name = "link_cadastrar";
            this.link_cadastrar.Size = new System.Drawing.Size(86, 18);
            this.link_cadastrar.TabIndex = 14;
            this.link_cadastrar.TabStop = true;
            this.link_cadastrar.Text = "Cadastrar-se";
            this.link_cadastrar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.link_cadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_cadastrar_LinkClicked);
            // 
            // pic_UserLogin
            // 
            this.pic_UserLogin.Image = global::GamesQuiz.Properties.Resources.user_menu;
            this.pic_UserLogin.Location = new System.Drawing.Point(147, 18);
            this.pic_UserLogin.Name = "pic_UserLogin";
            this.pic_UserLogin.Size = new System.Drawing.Size(128, 128);
            this.pic_UserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_UserLogin.TabIndex = 7;
            this.pic_UserLogin.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 52;
            this.label8.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "Senha:";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(413, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.link_cadastrar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.pic_UserLogin);
            this.Controls.Add(this.tb_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormularioPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_UserLogin;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.LinkLabel link_cadastrar;
        public System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}

