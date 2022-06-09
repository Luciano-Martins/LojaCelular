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
            this.txtUsuariofrmLogin = new System.Windows.Forms.TextBox();
            this.txtSenhafrmLogin = new System.Windows.Forms.TextBox();
            this.btnCancelarfrmLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrarfrmLogin
            // 
            this.btnEntrarfrmLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEntrarfrmLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEntrarfrmLogin.Location = new System.Drawing.Point(174, 357);
            this.btnEntrarfrmLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEntrarfrmLogin.Name = "btnEntrarfrmLogin";
            this.btnEntrarfrmLogin.Size = new System.Drawing.Size(100, 27);
            this.btnEntrarfrmLogin.TabIndex = 3;
            this.btnEntrarfrmLogin.Text = "Entrar";
            this.btnEntrarfrmLogin.UseVisualStyleBackColor = false;
            this.btnEntrarfrmLogin.Click += new System.EventHandler(this.btnEntrarfrmLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // txtUsuariofrmLogin
            // 
            this.txtUsuariofrmLogin.Location = new System.Drawing.Point(174, 258);
            this.txtUsuariofrmLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuariofrmLogin.Name = "txtUsuariofrmLogin";
            this.txtUsuariofrmLogin.Size = new System.Drawing.Size(215, 22);
            this.txtUsuariofrmLogin.TabIndex = 1;
            // 
            // txtSenhafrmLogin
            // 
            this.txtSenhafrmLogin.Location = new System.Drawing.Point(174, 318);
            this.txtSenhafrmLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSenhafrmLogin.Name = "txtSenhafrmLogin";
            this.txtSenhafrmLogin.PasswordChar = '*';
            this.txtSenhafrmLogin.Size = new System.Drawing.Size(215, 22);
            this.txtSenhafrmLogin.TabIndex = 2;
            // 
            // btnCancelarfrmLogin
            // 
            this.btnCancelarfrmLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarfrmLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarfrmLogin.Location = new System.Drawing.Point(289, 357);
            this.btnCancelarfrmLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarfrmLogin.Name = "btnCancelarfrmLogin";
            this.btnCancelarfrmLogin.Size = new System.Drawing.Size(100, 27);
            this.btnCancelarfrmLogin.TabIndex = 4;
            this.btnCancelarfrmLogin.Text = "Cancelar";
            this.btnCancelarfrmLogin.UseVisualStyleBackColor = false;
            this.btnCancelarfrmLogin.Click += new System.EventHandler(this.btnCancelarfrmLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DupCel.View.Properties.Resources.DupCell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 416);
            this.Controls.Add(this.btnCancelarfrmLogin);
            this.Controls.Add(this.txtSenhafrmLogin);
            this.Controls.Add(this.txtUsuariofrmLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrarfrmLogin);
            this.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrarfrmLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuariofrmLogin;
        private System.Windows.Forms.TextBox txtSenhafrmLogin;
        private System.Windows.Forms.Button btnCancelarfrmLogin;
    }
}