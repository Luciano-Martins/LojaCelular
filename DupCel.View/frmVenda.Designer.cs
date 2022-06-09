namespace DupCel.View
{
    partial class frmVenda
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Código Cliente");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Nome");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Endereço");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Telefone");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("E-mail");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.lstProduto = new System.Windows.Forms.ListView();
            this.btnProdutofrmVendas = new System.Windows.Forms.Button();
            this.btnServicofrmVenda = new System.Windows.Forms.Button();
            this.txtValorTotalfrmVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstServico = new System.Windows.Forms.ListView();
            this.btnClientefrmVendas = new System.Windows.Forms.Button();
            this.grpBoxCliente = new System.Windows.Forms.GroupBox();
            this.lstCliente = new System.Windows.Forms.ListView();
            this.btnFinalizarComprafrmVenda = new System.Windows.Forms.Button();
            this.btnExcluiItemfrmVendas = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpBoxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProduto
            // 
            this.lstProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProduto.FullRowSelect = true;
            this.lstProduto.GridLines = true;
            this.lstProduto.Location = new System.Drawing.Point(4, 18);
            this.lstProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstProduto.Name = "lstProduto";
            this.lstProduto.Size = new System.Drawing.Size(918, 150);
            this.lstProduto.TabIndex = 0;
            this.lstProduto.UseCompatibleStateImageBehavior = false;
            this.lstProduto.View = System.Windows.Forms.View.Details;
            this.lstProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstProduto_KeyDown);
            // 
            // btnProdutofrmVendas
            // 
            this.btnProdutofrmVendas.BackColor = System.Drawing.Color.Black;
            this.btnProdutofrmVendas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProdutofrmVendas.Location = new System.Drawing.Point(506, 206);
            this.btnProdutofrmVendas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProdutofrmVendas.Name = "btnProdutofrmVendas";
            this.btnProdutofrmVendas.Size = new System.Drawing.Size(135, 35);
            this.btnProdutofrmVendas.TabIndex = 1;
            this.btnProdutofrmVendas.Text = "Produto";
            this.btnProdutofrmVendas.UseVisualStyleBackColor = false;
            this.btnProdutofrmVendas.Click += new System.EventHandler(this.btnProdutofrmVendas_Click);
            // 
            // btnServicofrmVenda
            // 
            this.btnServicofrmVenda.BackColor = System.Drawing.Color.Black;
            this.btnServicofrmVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnServicofrmVenda.Location = new System.Drawing.Point(668, 206);
            this.btnServicofrmVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnServicofrmVenda.Name = "btnServicofrmVenda";
            this.btnServicofrmVenda.Size = new System.Drawing.Size(135, 35);
            this.btnServicofrmVenda.TabIndex = 2;
            this.btnServicofrmVenda.Text = "Serviço";
            this.btnServicofrmVenda.UseVisualStyleBackColor = false;
            this.btnServicofrmVenda.Click += new System.EventHandler(this.btnServicofrmVenda_Click);
            // 
            // txtValorTotalfrmVenda
            // 
            this.txtValorTotalfrmVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorTotalfrmVenda.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalfrmVenda.Location = new System.Drawing.Point(602, 587);
            this.txtValorTotalfrmVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorTotalfrmVenda.Multiline = true;
            this.txtValorTotalfrmVenda.Name = "txtValorTotalfrmVenda";
            this.txtValorTotalfrmVenda.Size = new System.Drawing.Size(192, 30);
            this.txtValorTotalfrmVenda.TabIndex = 7;
            this.txtValorTotalfrmVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 603);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstProduto);
            this.groupBox2.Location = new System.Drawing.Point(39, 246);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(926, 171);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstServico);
            this.groupBox3.Location = new System.Drawing.Point(39, 421);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(930, 151);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviço";
            // 
            // lstServico
            // 
            this.lstServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstServico.FullRowSelect = true;
            this.lstServico.GridLines = true;
            this.lstServico.Location = new System.Drawing.Point(4, 18);
            this.lstServico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstServico.Name = "lstServico";
            this.lstServico.Size = new System.Drawing.Size(922, 124);
            this.lstServico.TabIndex = 4;
            this.lstServico.UseCompatibleStateImageBehavior = false;
            this.lstServico.View = System.Windows.Forms.View.Details;
            // 
            // btnClientefrmVendas
            // 
            this.btnClientefrmVendas.BackColor = System.Drawing.Color.Black;
            this.btnClientefrmVendas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientefrmVendas.Location = new System.Drawing.Point(826, 206);
            this.btnClientefrmVendas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClientefrmVendas.Name = "btnClientefrmVendas";
            this.btnClientefrmVendas.Size = new System.Drawing.Size(135, 35);
            this.btnClientefrmVendas.TabIndex = 4;
            this.btnClientefrmVendas.Text = "Cliente";
            this.btnClientefrmVendas.UseVisualStyleBackColor = false;
            this.btnClientefrmVendas.Click += new System.EventHandler(this.btnClientefrmVendas_Click);
            // 
            // grpBoxCliente
            // 
            this.grpBoxCliente.Controls.Add(this.lstCliente);
            this.grpBoxCliente.Location = new System.Drawing.Point(43, 29);
            this.grpBoxCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpBoxCliente.Name = "grpBoxCliente";
            this.grpBoxCliente.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpBoxCliente.Size = new System.Drawing.Size(466, 129);
            this.grpBoxCliente.TabIndex = 9;
            this.grpBoxCliente.TabStop = false;
            this.grpBoxCliente.Text = "Cliente";
            // 
            // lstCliente
            // 
            this.lstCliente.FullRowSelect = true;
            this.lstCliente.GridLines = true;
            this.lstCliente.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.lstCliente.Location = new System.Drawing.Point(4, 17);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(455, 103);
            this.lstCliente.TabIndex = 0;
            this.lstCliente.UseCompatibleStateImageBehavior = false;
            this.lstCliente.View = System.Windows.Forms.View.List;
            // 
            // btnFinalizarComprafrmVenda
            // 
            this.btnFinalizarComprafrmVenda.BackColor = System.Drawing.Color.Black;
            this.btnFinalizarComprafrmVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizarComprafrmVenda.Location = new System.Drawing.Point(830, 582);
            this.btnFinalizarComprafrmVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFinalizarComprafrmVenda.Name = "btnFinalizarComprafrmVenda";
            this.btnFinalizarComprafrmVenda.Size = new System.Drawing.Size(135, 35);
            this.btnFinalizarComprafrmVenda.TabIndex = 8;
            this.btnFinalizarComprafrmVenda.Text = "Finalizar Compra";
            this.btnFinalizarComprafrmVenda.UseVisualStyleBackColor = false;
            this.btnFinalizarComprafrmVenda.Click += new System.EventHandler(this.btnFinalizarComprafrmVenda_Click);
            // 
            // btnExcluiItemfrmVendas
            // 
            this.btnExcluiItemfrmVendas.BackColor = System.Drawing.Color.Black;
            this.btnExcluiItemfrmVendas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluiItemfrmVendas.Location = new System.Drawing.Point(352, 205);
            this.btnExcluiItemfrmVendas.Name = "btnExcluiItemfrmVendas";
            this.btnExcluiItemfrmVendas.Size = new System.Drawing.Size(135, 35);
            this.btnExcluiItemfrmVendas.TabIndex = 0;
            this.btnExcluiItemfrmVendas.Text = "Excluir Item";
            this.btnExcluiItemfrmVendas.UseVisualStyleBackColor = false;
            this.btnExcluiItemfrmVendas.Click += new System.EventHandler(this.btnExcluiItemfrmVendas_Click);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1006, 634);
            this.Controls.Add(this.btnExcluiItemfrmVendas);
            this.Controls.Add(this.btnFinalizarComprafrmVenda);
            this.Controls.Add(this.grpBoxCliente);
            this.Controls.Add(this.btnClientefrmVendas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorTotalfrmVenda);
            this.Controls.Add(this.btnServicofrmVenda);
            this.Controls.Add(this.btnProdutofrmVendas);
            this.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grpBoxCliente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstProduto;
        private System.Windows.Forms.Button btnProdutofrmVendas;
        private System.Windows.Forms.Button btnServicofrmVenda;
        private System.Windows.Forms.TextBox txtValorTotalfrmVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstServico;
        private System.Windows.Forms.Button btnClientefrmVendas;
        private System.Windows.Forms.GroupBox grpBoxCliente;
        private System.Windows.Forms.ListView lstCliente;
        private System.Windows.Forms.Button btnFinalizarComprafrmVenda;
        private System.Windows.Forms.Button btnExcluiItemfrmVendas;
    }
}