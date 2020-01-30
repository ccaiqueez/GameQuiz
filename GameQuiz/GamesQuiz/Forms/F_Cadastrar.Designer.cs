namespace GamesQuiz.Forms
{
    partial class F_Cadastrar
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
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pic_UserLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_senha
            // 
            this.tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_senha.Location = new System.Drawing.Point(38, 345);
            this.tb_senha.Margin = new System.Windows.Forms.Padding(4, 9, 5, 9);
            this.tb_senha.Multiline = true;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(389, 47);
            this.tb_senha.TabIndex = 15;
            this.tb_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_usuario
            // 
            this.tb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_usuario.Location = new System.Drawing.Point(37, 266);
            this.tb_usuario.Margin = new System.Windows.Forms.Padding(4, 9, 5, 9);
            this.tb_usuario.Multiline = true;
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(389, 47);
            this.tb_usuario.TabIndex = 14;
            this.tb_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Red;
            this.btn_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(37, 420);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(390, 46);
            this.btn_cadastrar.TabIndex = 16;
            this.btn_cadastrar.TabStop = false;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Maroon;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(37, 474);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(390, 46);
            this.btn_sair.TabIndex = 17;
            this.btn_sair.TabStop = false;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI Semilight", 26F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(139, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 47);
            this.label8.TabIndex = 51;
            this.label8.Text = "CADASTRO";
            // 
            // pic_UserLogin
            // 
            this.pic_UserLogin.Image = global::GamesQuiz.Properties.Resources.user_menu1;
            this.pic_UserLogin.Location = new System.Drawing.Point(172, 86);
            this.pic_UserLogin.Name = "pic_UserLogin";
            this.pic_UserLogin.Size = new System.Drawing.Size(128, 128);
            this.pic_UserLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_UserLogin.TabIndex = 18;
            this.pic_UserLogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Usuário:";
            // 
            // F_Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(474, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pic_UserLogin);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "F_Cadastrar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.PictureBox pic_UserLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}