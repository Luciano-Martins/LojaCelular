namespace DupCel.View
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.dgvfrmCliente = new System.Windows.Forms.DataGridView();
            this.txtBairrofrmCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomeClientefrmCliente = new System.Windows.Forms.TextBox();
            this.mskTelefonefrmCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecofrmCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoClientefrmCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstadofrmCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidadefrmCliente = new System.Windows.Forms.TextBox();
            this.txtEmailfrmCliente = new System.Windows.Forms.TextBox();
            this.txtComplementofrmCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelecionarfrmCliente = new System.Windows.Forms.Button();
            this.btnGravarfrmCliente = new System.Windows.Forms.Button();
            this.btnLimparfrmCliente = new System.Windows.Forms.Button();
            this.txtNumerofrmCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvfrmCliente
            // 
            this.dgvfrmCliente.AllowUserToAddRows = false;
            this.dgvfrmCliente.AllowUserToDeleteRows = false;
            this.dgvfrmCliente.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvfrmCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfrmCliente.Location = new System.Drawing.Point(13, 382);
            this.dgvfrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvfrmCliente.Name = "dgvfrmCliente";
            this.dgvfrmCliente.ReadOnly = true;
            this.dgvfrmCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfrmCliente.Size = new System.Drawing.Size(978, 220);
            this.dgvfrmCliente.TabIndex = 14;
            this.dgvfrmCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfrmCliente_CellContentClick);
            this.dgvfrmCliente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfrmCliente_CellEnter);
            // 
            // txtBairrofrmCliente
            // 
            this.txtBairrofrmCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairrofrmCliente.Location = new System.Drawing.Point(153, 164);
            this.txtBairrofrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBairrofrmCliente.Name = "txtBairrofrmCliente";
            this.txtBairrofrmCliente.Size = new System.Drawing.Size(275, 22);
            this.txtBairrofrmCliente.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 294);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 14);
            this.label11.TabIndex = 53;
            this.label11.Text = "E-mail";
            // 
            // txtNomeClientefrmCliente
            // 
            this.txtNomeClientefrmCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeClientefrmCliente.Location = new System.Drawing.Point(153, 74);
            this.txtNomeClientefrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeClientefrmCliente.Name = "txtNomeClientefrmCliente";
            this.txtNomeClientefrmCliente.Size = new System.Drawing.Size(454, 22);
            this.txtNomeClientefrmCliente.TabIndex = 2;
            // 
            // mskTelefonefrmCliente
            // 
            this.mskTelefonefrmCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskTelefonefrmCliente.Location = new System.Drawing.Point(153, 255);
            this.mskTelefonefrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mskTelefonefrmCliente.Mask = "(999) 000-0000";
            this.mskTelefonefrmCliente.Name = "mskTelefonefrmCliente";
            this.mskTelefonefrmCliente.Size = new System.Drawing.Size(275, 22);
            this.mskTelefonefrmCliente.TabIndex = 9;
            // 
            // txtEnderecofrmCliente
            // 
            this.txtEnderecofrmCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnderecofrmCliente.Location = new System.Drawing.Point(153, 104);
            this.txtEnderecofrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEnderecofrmCliente.Name = "txtEnderecofrmCliente";
            this.txtEnderecofrmCliente.Size = new System.Drawing.Size(275, 22);
            this.txtEnderecofrmCliente.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 233);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 51;
            this.label8.Text = "Estado";
            // 
            // txtCodigoClientefrmCliente
            // 
            this.txtCodigoClientefrmCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoClientefrmCliente.Location = new System.Drawing.Point(153, 44);
            this.txtCodigoClientefrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoClientefrmCliente.Name = "txtCodigoClientefrmCliente";
            this.txtCodigoClientefrmCliente.ReadOnly = true;
            this.txtCodigoClientefrmCliente.Size = new System.Drawing.Size(107, 22);
            this.txtCodigoClientefrmCliente.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nome";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 263);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 14);
            this.label10.TabIndex = 50;
            this.label10.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 40;
            this.label2.Text = "Endereço";
            // 
            // txtEstadofrmCliente
            // 
            this.txtEstadofrmCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstadofrmCliente.Location = new System.Drawing.Point(153, 225);
            this.txtEstadofrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEstadofrmCliente.Name = "txtEstadofrmCliente";
            this.txtEstadofrmCliente.Size = new System.Drawing.Size(275, 22);
            this.txtEstadofrmCliente.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 41;
            this.label1.Text = "Código Cliente";
            // 
            // txtCidadefrmCliente
            // 
            this.txtCidadefrmCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidadefrmCliente.Location = new System.Drawing.Point(153, 195);
            this.txtCidadefrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCidadefrmCliente.Name = "txtCidadefrmCliente";
            this.txtCidadefrmCliente.Size = new System.Drawing.Size(275, 22);
            this.txtCidadefrmCliente.TabIndex = 7;
            // 
            // txtEmailfrmCliente
            // 
            this.txtEmailfrmCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailfrmCliente.Location = new System.Drawing.Point(153, 285);
            this.txtEmailfrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmailfrmCliente.Name = "txtEmailfrmCliente";
            this.txtEmailfrmCliente.Size = new System.Drawing.Size(454, 22);
            this.txtEmailfrmCliente.TabIndex = 10;
            // 
            // txtComplementofrmCliente
            // 
            this.txtComplementofrmCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplementofrmCliente.Location = new System.Drawing.Point(153, 134);
            this.txtComplementofrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtComplementofrmCliente.Name = "txtComplementofrmCliente";
            this.txtComplementofrmCliente.Size = new System.Drawing.Size(275, 22);
            this.txtComplementofrmCliente.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 14);
            this.label5.TabIndex = 47;
            this.label5.Text = "Complemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 14);
            this.label7.TabIndex = 45;
            this.label7.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 46;
            this.label6.Text = "Cidade";
            // 
            // btnSelecionarfrmCliente
            // 
            this.btnSelecionarfrmCliente.BackColor = System.Drawing.Color.Black;
            this.btnSelecionarfrmCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelecionarfrmCliente.Location = new System.Drawing.Point(238, 330);
            this.btnSelecionarfrmCliente.Name = "btnSelecionarfrmCliente";
            this.btnSelecionarfrmCliente.Size = new System.Drawing.Size(135, 35);
            this.btnSelecionarfrmCliente.TabIndex = 12;
            this.btnSelecionarfrmCliente.Text = "Selecionar";
            this.btnSelecionarfrmCliente.UseVisualStyleBackColor = false;
            this.btnSelecionarfrmCliente.Click += new System.EventHandler(this.btnSelecionarfrmCliente_Click);
            // 
            // btnGravarfrmCliente
            // 
            this.btnGravarfrmCliente.BackColor = System.Drawing.Color.Black;
            this.btnGravarfrmCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGravarfrmCliente.Location = new System.Drawing.Point(14, 330);
            this.btnGravarfrmCliente.Name = "btnGravarfrmCliente";
            this.btnGravarfrmCliente.Size = new System.Drawing.Size(135, 35);
            this.btnGravarfrmCliente.TabIndex = 11;
            this.btnGravarfrmCliente.Text = "Gravar";
            this.btnGravarfrmCliente.UseVisualStyleBackColor = false;
            this.btnGravarfrmCliente.Click += new System.EventHandler(this.btnGravarfrmCliente_Click);
            // 
            // btnLimparfrmCliente
            // 
            this.btnLimparfrmCliente.BackColor = System.Drawing.Color.Black;
            this.btnLimparfrmCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimparfrmCliente.Location = new System.Drawing.Point(472, 330);
            this.btnLimparfrmCliente.Name = "btnLimparfrmCliente";
            this.btnLimparfrmCliente.Size = new System.Drawing.Size(135, 35);
            this.btnLimparfrmCliente.TabIndex = 13;
            this.btnLimparfrmCliente.Text = "Limpar";
            this.btnLimparfrmCliente.UseVisualStyleBackColor = false;
            this.btnLimparfrmCliente.Click += new System.EventHandler(this.btnLimparfrmCliente_Click);
            // 
            // txtNumerofrmCliente
            // 
            this.txtNumerofrmCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumerofrmCliente.Location = new System.Drawing.Point(554, 102);
            this.txtNumerofrmCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumerofrmCliente.Name = "txtNumerofrmCliente";
            this.txtNumerofrmCliente.Size = new System.Drawing.Size(53, 22);
            this.txtNumerofrmCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 14);
            this.label3.TabIndex = 59;
            this.label3.Text = "Nº";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DupCel.View.Properties.Resources.DupCell1;
            this.pictureBox1.Location = new System.Drawing.Point(645, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1006, 634);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumerofrmCliente);
            this.Controls.Add(this.btnLimparfrmCliente);
            this.Controls.Add(this.btnGravarfrmCliente);
            this.Controls.Add(this.btnSelecionarfrmCliente);
            this.Controls.Add(this.txtBairrofrmCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNomeClientefrmCliente);
            this.Controls.Add(this.mskTelefonefrmCliente);
            this.Controls.Add(this.txtEnderecofrmCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigoClientefrmCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstadofrmCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidadefrmCliente);
            this.Controls.Add(this.txtEmailfrmCliente);
            this.Controls.Add(this.txtComplementofrmCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvfrmCliente);
            this.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfrmCliente;
        private System.Windows.Forms.TextBox txtBairrofrmCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomeClientefrmCliente;
        private System.Windows.Forms.MaskedTextBox mskTelefonefrmCliente;
        private System.Windows.Forms.TextBox txtEnderecofrmCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoClientefrmCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstadofrmCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCidadefrmCliente;
        private System.Windows.Forms.TextBox txtEmailfrmCliente;
        private System.Windows.Forms.TextBox txtComplementofrmCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelecionarfrmCliente;
        private System.Windows.Forms.Button btnGravarfrmCliente;
        private System.Windows.Forms.Button btnLimparfrmCliente;
        private System.Windows.Forms.TextBox txtNumerofrmCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}