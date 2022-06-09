namespace DupCel.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnEntrarfrmLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarLogin = new System.Windows.Forms.Button();
            this.btnSairLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrarfrmLogin
            // 
            this.btnEntrarfrmLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnEntrarfrmLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEntrarfrmLogin.Location = new System.Drawing.Point(25, 134);
            this.btnEntrarfrmLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEntrarfrmLogin.Name = "btnEntrarfrmLogin";
            this.btnEntrarfrmLogin.Size = new System.Drawing.Size(100, 25);
            this.btnEntrarfrmLogin.TabIndex = 2;
            this.btnEntrarfrmLogin.Text = "Entrar";
            this.btnEntrarfrmLogin.UseVisualStyleBackColor = false;
            this.btnEntrarfrmLogin.Click += new System.EventHandler(this.btnEntrarfrmLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(25, 38);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(215, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(25, 98);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(215, 22);
            this.txtSenha.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(266, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarLogin
            // 
            this.btnCadastrarLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrarLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrarLogin.Location = new System.Drawing.Point(25, 174);
            this.btnCadastrarLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrarLogin.Name = "btnCadastrarLogin";
            this.btnCadastrarLogin.Size = new System.Drawing.Size(100, 25);
            this.btnCadastrarLogin.TabIndex = 4;
            this.btnCadastrarLogin.Text = "Cadastrar";
            this.btnCadastrarLogin.UseVisualStyleBackColor = false;
            this.btnCadastrarLogin.Click += new System.EventHandler(this.btnCadastrarLogin_Click);
            // 
            // btnSairLogin
            // 
            this.btnSairLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSairLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSairLogin.Location = new System.Drawing.Point(140, 134);
            this.btnSairLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSairLogin.Name = "btnSairLogin";
            this.btnSairLogin.Size = new System.Drawing.Size(100, 25);
            this.btnSairLogin.TabIndex = 5;
            this.btnSairLogin.Text = "Sair";
            this.btnSairLogin.UseVisualStyleBackColor = false;
            this.btnSairLogin.Click += new System.EventHandler(this.btnSairLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 211);
            this.Controls.Add(this.btnSairLogin);
            this.Controls.Add(this.btnCadastrarLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrarfrmLogin);
            this.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso as Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrarfrmLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrarLogin;
        private System.Windows.Forms.Button btnSairLogin;
    }
}