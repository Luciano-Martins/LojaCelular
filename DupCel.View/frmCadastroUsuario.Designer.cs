namespace DupCel.View
{
    partial class frmCadastroUsuario
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
            this.btnSairCadastro = new System.Windows.Forms.Button();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.txtUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.txtConfSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.labSenhaCadastro = new System.Windows.Forms.Label();
            this.labUsuarioCadastro = new System.Windows.Forms.Label();
            this.labConfSenhaCadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSairCadastro
            // 
            this.btnSairCadastro.Location = new System.Drawing.Point(258, 131);
            this.btnSairCadastro.Name = "btnSairCadastro";
            this.btnSairCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnSairCadastro.TabIndex = 4;
            this.btnSairCadastro.Text = "Sair";
            this.btnSairCadastro.UseVisualStyleBackColor = true;
            this.btnSairCadastro.Click += new System.EventHandler(this.btnSairCadastro_Click);
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Location = new System.Drawing.Point(101, 131);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarUsuario.TabIndex = 3;
            this.btnSalvarUsuario.Text = "Salvar";
            this.btnSalvarUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // txtUsuarioCadastro
            // 
            this.txtUsuarioCadastro.Location = new System.Drawing.Point(101, 30);
            this.txtUsuarioCadastro.Name = "txtUsuarioCadastro";
            this.txtUsuarioCadastro.Size = new System.Drawing.Size(232, 20);
            this.txtUsuarioCadastro.TabIndex = 0;
            // 
            // txtConfSenhaCadastro
            // 
            this.txtConfSenhaCadastro.Location = new System.Drawing.Point(101, 82);
            this.txtConfSenhaCadastro.Name = "txtConfSenhaCadastro";
            this.txtConfSenhaCadastro.Size = new System.Drawing.Size(232, 20);
            this.txtConfSenhaCadastro.TabIndex = 2;
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Location = new System.Drawing.Point(101, 56);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(232, 20);
            this.txtSenhaCadastro.TabIndex = 1;
            // 
            // labSenhaCadastro
            // 
            this.labSenhaCadastro.AutoSize = true;
            this.labSenhaCadastro.Location = new System.Drawing.Point(27, 63);
            this.labSenhaCadastro.Name = "labSenhaCadastro";
            this.labSenhaCadastro.Size = new System.Drawing.Size(38, 13);
            this.labSenhaCadastro.TabIndex = 5;
            this.labSenhaCadastro.Text = "Senha";
            // 
            // labUsuarioCadastro
            // 
            this.labUsuarioCadastro.AutoSize = true;
            this.labUsuarioCadastro.Location = new System.Drawing.Point(27, 37);
            this.labUsuarioCadastro.Name = "labUsuarioCadastro";
            this.labUsuarioCadastro.Size = new System.Drawing.Size(43, 13);
            this.labUsuarioCadastro.TabIndex = 6;
            this.labUsuarioCadastro.Text = "Usuario";
            // 
            // labConfSenhaCadastro
            // 
            this.labConfSenhaCadastro.AutoSize = true;
            this.labConfSenhaCadastro.Location = new System.Drawing.Point(27, 89);
            this.labConfSenhaCadastro.Name = "labConfSenhaCadastro";
            this.labConfSenhaCadastro.Size = new System.Drawing.Size(48, 13);
            this.labConfSenhaCadastro.TabIndex = 7;
            this.labConfSenhaCadastro.Text = "Confirma";
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 211);
            this.Controls.Add(this.labConfSenhaCadastro);
            this.Controls.Add(this.labUsuarioCadastro);
            this.Controls.Add(this.labSenhaCadastro);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.txtConfSenhaCadastro);
            this.Controls.Add(this.txtUsuarioCadastro);
            this.Controls.Add(this.btnSalvarUsuario);
            this.Controls.Add(this.btnSairCadastro);
            this.Name = "frmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairCadastro;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.TextBox txtUsuarioCadastro;
        private System.Windows.Forms.TextBox txtConfSenhaCadastro;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.Label labSenhaCadastro;
        private System.Windows.Forms.Label labUsuarioCadastro;
        private System.Windows.Forms.Label labConfSenhaCadastro;
    }
}