namespace DupCel.View
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.dgvfrmProduto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorComercio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpProdutofrmProduto = new System.Windows.Forms.GroupBox();
            this.btnEditor = new System.Windows.Forms.Button();
            this.chkAtivofrmProduto = new System.Windows.Forms.CheckBox();
            this.rad90diasfrmProduto = new System.Windows.Forms.RadioButton();
            this.rad60diasfrmProduto = new System.Windows.Forms.RadioButton();
            this.rad30diasfrmProduto = new System.Windows.Forms.RadioButton();
            this.rad20diasfrmProduto = new System.Windows.Forms.RadioButton();
            this.rad10diasfrmProduto = new System.Windows.Forms.RadioButton();
            this.DataTerminofrmProduto = new System.Windows.Forms.Label();
            this.txtDataTerminofrmProduto = new System.Windows.Forms.TextBox();
            this.txtImenfrmProduto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLimparfrmProduto = new System.Windows.Forms.Button();
            this.btnGravarfrmProduto = new System.Windows.Forms.Button();
            this.txtCodigoProdutofrmProduto = new System.Windows.Forms.TextBox();
            this.btnSelecionarfrmProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProdutofrmProduto = new System.Windows.Forms.TextBox();
            this.txtEstoqueMinimofrmProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigofrmProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadefrmProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelofrmProduto = new System.Windows.Forms.TextBox();
            this.txtValorComprafrmProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorfrmProduto = new System.Windows.Forms.TextBox();
            this.txtValorComerciofrmProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFabricantefrmProduto = new System.Windows.Forms.TextBox();
            this.txtBuscarProdutofrmProduto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarfrmProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmProduto)).BeginInit();
            this.grpProdutofrmProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvfrmProduto
            // 
            this.dgvfrmProduto.AllowUserToAddRows = false;
            this.dgvfrmProduto.AllowUserToDeleteRows = false;
            this.dgvfrmProduto.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvfrmProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfrmProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Codigo,
            this.Modelo,
            this.Fabricante,
            this.Cor,
            this.Imen,
            this.ValorCompra,
            this.ValorComercio,
            this.Quantidade,
            this.EstoqueMinimo,
            this.Ativo});
            this.dgvfrmProduto.Location = new System.Drawing.Point(13, 368);
            this.dgvfrmProduto.Name = "dgvfrmProduto";
            this.dgvfrmProduto.ReadOnly = true;
            this.dgvfrmProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfrmProduto.Size = new System.Drawing.Size(981, 254);
            this.dgvfrmProduto.TabIndex = 23;
            this.dgvfrmProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfrmProduto_CellClick);
            this.dgvfrmProduto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfrmProduto_CellEnter_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Fabricante
            // 
            this.Fabricante.DataPropertyName = "Fabricante";
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.ReadOnly = true;
            // 
            // Cor
            // 
            this.Cor.DataPropertyName = "Cor";
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // Imen
            // 
            this.Imen.DataPropertyName = "Imen";
            this.Imen.HeaderText = "Imen";
            this.Imen.Name = "Imen";
            this.Imen.ReadOnly = true;
            // 
            // ValorCompra
            // 
            this.ValorCompra.DataPropertyName = "ValorCompra";
            this.ValorCompra.HeaderText = "ValorCompra";
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.ReadOnly = true;
            // 
            // ValorComercio
            // 
            this.ValorComercio.DataPropertyName = "ValorComercio";
            this.ValorComercio.HeaderText = "ValorComercio";
            this.ValorComercio.Name = "ValorComercio";
            this.ValorComercio.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // EstoqueMinimo
            // 
            this.EstoqueMinimo.DataPropertyName = "EstoqueMinimo";
            this.EstoqueMinimo.HeaderText = "EstoqueMinimo";
            this.EstoqueMinimo.Name = "EstoqueMinimo";
            this.EstoqueMinimo.ReadOnly = true;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            // 
            // grpProdutofrmProduto
            // 
            this.grpProdutofrmProduto.BackColor = System.Drawing.Color.Red;
            this.grpProdutofrmProduto.Controls.Add(this.btnBuscarfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.label11);
            this.grpProdutofrmProduto.Controls.Add(this.txtBuscarProdutofrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.btnEditor);
            this.grpProdutofrmProduto.Controls.Add(this.chkAtivofrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.rad90diasfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.rad60diasfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.rad30diasfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.rad20diasfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.rad10diasfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.DataTerminofrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.txtDataTerminofrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.txtImenfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.label12);
            this.grpProdutofrmProduto.Controls.Add(this.btnLimparfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.btnGravarfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.txtCodigoProdutofrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.btnSelecionarfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.label1);
            this.grpProdutofrmProduto.Controls.Add(this.txtNomeProdutofrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.txtEstoqueMinimofrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.label10);
            this.grpProdutofrmProduto.Controls.Add(this.label2);
            this.grpProdutofrmProduto.Controls.Add(this.txtCodigofrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.txtQuantidadefrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.label9);
            this.grpProdutofrmProduto.Controls.Add(this.label4);
            this.grpProdutofrmProduto.Controls.Add(this.txtModelofrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.txtValorComprafrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.label8);
            this.grpProdutofrmProduto.Controls.Add(this.label5);
            this.grpProdutofrmProduto.Controls.Add(this.label6);
            this.grpProdutofrmProduto.Controls.Add(this.txtCorfrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.txtValorComerciofrmProduto);
            this.grpProdutofrmProduto.Controls.Add(this.label3);
            this.grpProdutofrmProduto.Controls.Add(this.label7);
            this.grpProdutofrmProduto.Controls.Add(this.txtFabricantefrmProduto);
            this.grpProdutofrmProduto.Location = new System.Drawing.Point(12, 12);
            this.grpProdutofrmProduto.Name = "grpProdutofrmProduto";
            this.grpProdutofrmProduto.Size = new System.Drawing.Size(981, 337);
            this.grpProdutofrmProduto.TabIndex = 0;
            this.grpProdutofrmProduto.TabStop = false;
            this.grpProdutofrmProduto.Text = "Cadastro Produto";
            // 
            // btnEditor
            // 
            this.btnEditor.BackColor = System.Drawing.Color.Black;
            this.btnEditor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditor.Location = new System.Drawing.Point(807, 42);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(149, 23);
            this.btnEditor.TabIndex = 22;
            this.btnEditor.Text = "Editor Texto";
            this.btnEditor.UseVisualStyleBackColor = false;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // chkAtivofrmProduto
            // 
            this.chkAtivofrmProduto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAtivofrmProduto.Location = new System.Drawing.Point(412, 176);
            this.chkAtivofrmProduto.Name = "chkAtivofrmProduto";
            this.chkAtivofrmProduto.Size = new System.Drawing.Size(61, 18);
            this.chkAtivofrmProduto.TabIndex = 12;
            this.chkAtivofrmProduto.Text = "Ativo";
            this.chkAtivofrmProduto.UseVisualStyleBackColor = true;
            // 
            // rad90diasfrmProduto
            // 
            this.rad90diasfrmProduto.AutoSize = true;
            this.rad90diasfrmProduto.Location = new System.Drawing.Point(713, 176);
            this.rad90diasfrmProduto.Name = "rad90diasfrmProduto";
            this.rad90diasfrmProduto.Size = new System.Drawing.Size(97, 18);
            this.rad90diasfrmProduto.TabIndex = 18;
            this.rad90diasfrmProduto.TabStop = true;
            this.rad90diasfrmProduto.Text = "Seis Meses";
            this.rad90diasfrmProduto.UseVisualStyleBackColor = true;
            this.rad90diasfrmProduto.CheckedChanged += new System.EventHandler(this.rad90diasfrmProduto_CheckedChanged);
            // 
            // rad60diasfrmProduto
            // 
            this.rad60diasfrmProduto.AutoSize = true;
            this.rad60diasfrmProduto.Location = new System.Drawing.Point(848, 152);
            this.rad60diasfrmProduto.Name = "rad60diasfrmProduto";
            this.rad60diasfrmProduto.Size = new System.Drawing.Size(99, 18);
            this.rad60diasfrmProduto.TabIndex = 17;
            this.rad60diasfrmProduto.TabStop = true;
            this.rad60diasfrmProduto.Text = "Três Meses";
            this.rad60diasfrmProduto.UseVisualStyleBackColor = true;
            this.rad60diasfrmProduto.CheckedChanged += new System.EventHandler(this.rad60diasfrmProduto_CheckedChanged);
            // 
            // rad30diasfrmProduto
            // 
            this.rad30diasfrmProduto.AutoSize = true;
            this.rad30diasfrmProduto.Location = new System.Drawing.Point(713, 152);
            this.rad30diasfrmProduto.Name = "rad30diasfrmProduto";
            this.rad30diasfrmProduto.Size = new System.Drawing.Size(79, 18);
            this.rad30diasfrmProduto.TabIndex = 16;
            this.rad30diasfrmProduto.TabStop = true;
            this.rad30diasfrmProduto.Text = "Um Mes";
            this.rad30diasfrmProduto.UseVisualStyleBackColor = true;
            this.rad30diasfrmProduto.CheckedChanged += new System.EventHandler(this.rad30diasfrmProduto_CheckedChanged);
            // 
            // rad20diasfrmProduto
            // 
            this.rad20diasfrmProduto.AutoSize = true;
            this.rad20diasfrmProduto.Location = new System.Drawing.Point(848, 128);
            this.rad20diasfrmProduto.Name = "rad20diasfrmProduto";
            this.rad20diasfrmProduto.Size = new System.Drawing.Size(93, 18);
            this.rad20diasfrmProduto.TabIndex = 15;
            this.rad20diasfrmProduto.TabStop = true;
            this.rad20diasfrmProduto.Text = "Vinte Dias";
            this.rad20diasfrmProduto.UseVisualStyleBackColor = true;
            this.rad20diasfrmProduto.CheckedChanged += new System.EventHandler(this.rad20diasfrmProduto_CheckedChanged);
            // 
            // rad10diasfrmProduto
            // 
            this.rad10diasfrmProduto.AutoSize = true;
            this.rad10diasfrmProduto.Location = new System.Drawing.Point(713, 128);
            this.rad10diasfrmProduto.Name = "rad10diasfrmProduto";
            this.rad10diasfrmProduto.Size = new System.Drawing.Size(83, 18);
            this.rad10diasfrmProduto.TabIndex = 14;
            this.rad10diasfrmProduto.TabStop = true;
            this.rad10diasfrmProduto.Text = "Dez Dias";
            this.rad10diasfrmProduto.UseVisualStyleBackColor = true;
            this.rad10diasfrmProduto.CheckedChanged += new System.EventHandler(this.rad10diasfrmProduto_CheckedChanged);
            // 
            // DataTerminofrmProduto
            // 
            this.DataTerminofrmProduto.AutoSize = true;
            this.DataTerminofrmProduto.Location = new System.Drawing.Point(359, 203);
            this.DataTerminofrmProduto.Name = "DataTerminofrmProduto";
            this.DataTerminofrmProduto.Size = new System.Drawing.Size(99, 14);
            this.DataTerminofrmProduto.TabIndex = 67;
            this.DataTerminofrmProduto.Text = "Data Término";
            // 
            // txtDataTerminofrmProduto
            // 
            this.txtDataTerminofrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataTerminofrmProduto.Location = new System.Drawing.Point(459, 195);
            this.txtDataTerminofrmProduto.Name = "txtDataTerminofrmProduto";
            this.txtDataTerminofrmProduto.Size = new System.Drawing.Size(198, 22);
            this.txtDataTerminofrmProduto.TabIndex = 13;
            // 
            // txtImenfrmProduto
            // 
            this.txtImenfrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImenfrmProduto.Location = new System.Drawing.Point(460, 42);
            this.txtImenfrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtImenfrmProduto.Multiline = true;
            this.txtImenfrmProduto.Name = "txtImenfrmProduto";
            this.txtImenfrmProduto.Size = new System.Drawing.Size(197, 23);
            this.txtImenfrmProduto.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 14);
            this.label12.TabIndex = 65;
            this.label12.Text = "Imen";
            // 
            // btnLimparfrmProduto
            // 
            this.btnLimparfrmProduto.BackColor = System.Drawing.Color.Black;
            this.btnLimparfrmProduto.ForeColor = System.Drawing.Color.White;
            this.btnLimparfrmProduto.Location = new System.Drawing.Point(496, 276);
            this.btnLimparfrmProduto.Name = "btnLimparfrmProduto";
            this.btnLimparfrmProduto.Size = new System.Drawing.Size(135, 35);
            this.btnLimparfrmProduto.TabIndex = 21;
            this.btnLimparfrmProduto.Text = "Limpar";
            this.btnLimparfrmProduto.UseVisualStyleBackColor = false;
            this.btnLimparfrmProduto.Click += new System.EventHandler(this.btnLimparfrmProduto_Click);
            // 
            // btnGravarfrmProduto
            // 
            this.btnGravarfrmProduto.BackColor = System.Drawing.Color.Black;
            this.btnGravarfrmProduto.ForeColor = System.Drawing.Color.White;
            this.btnGravarfrmProduto.Location = new System.Drawing.Point(14, 276);
            this.btnGravarfrmProduto.Name = "btnGravarfrmProduto";
            this.btnGravarfrmProduto.Size = new System.Drawing.Size(135, 35);
            this.btnGravarfrmProduto.TabIndex = 19;
            this.btnGravarfrmProduto.Text = "Gravar";
            this.btnGravarfrmProduto.UseVisualStyleBackColor = false;
            this.btnGravarfrmProduto.Click += new System.EventHandler(this.btnGravarfrmProduto_Click);
            // 
            // txtCodigoProdutofrmProduto
            // 
            this.txtCodigoProdutofrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoProdutofrmProduto.Location = new System.Drawing.Point(115, 38);
            this.txtCodigoProdutofrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProdutofrmProduto.Name = "txtCodigoProdutofrmProduto";
            this.txtCodigoProdutofrmProduto.ReadOnly = true;
            this.txtCodigoProdutofrmProduto.Size = new System.Drawing.Size(119, 22);
            this.txtCodigoProdutofrmProduto.TabIndex = 1;
            // 
            // btnSelecionarfrmProduto
            // 
            this.btnSelecionarfrmProduto.BackColor = System.Drawing.Color.Black;
            this.btnSelecionarfrmProduto.ForeColor = System.Drawing.Color.White;
            this.btnSelecionarfrmProduto.Location = new System.Drawing.Point(253, 276);
            this.btnSelecionarfrmProduto.Name = "btnSelecionarfrmProduto";
            this.btnSelecionarfrmProduto.Size = new System.Drawing.Size(135, 35);
            this.btnSelecionarfrmProduto.TabIndex = 20;
            this.btnSelecionarfrmProduto.Text = "Selecionar";
            this.btnSelecionarfrmProduto.UseVisualStyleBackColor = false;
            this.btnSelecionarfrmProduto.Click += new System.EventHandler(this.btnSelecionarfrmProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 14);
            this.label1.TabIndex = 40;
            this.label1.Text = "Código Produto";
            // 
            // txtNomeProdutofrmProduto
            // 
            this.txtNomeProdutofrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProdutofrmProduto.Location = new System.Drawing.Point(115, 63);
            this.txtNomeProdutofrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeProdutofrmProduto.Multiline = true;
            this.txtNomeProdutofrmProduto.Name = "txtNomeProdutofrmProduto";
            this.txtNomeProdutofrmProduto.Size = new System.Drawing.Size(206, 23);
            this.txtNomeProdutofrmProduto.TabIndex = 2;
            // 
            // txtEstoqueMinimofrmProduto
            // 
            this.txtEstoqueMinimofrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoqueMinimofrmProduto.Location = new System.Drawing.Point(460, 146);
            this.txtEstoqueMinimofrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoqueMinimofrmProduto.Name = "txtEstoqueMinimofrmProduto";
            this.txtEstoqueMinimofrmProduto.Size = new System.Drawing.Size(197, 22);
            this.txtEstoqueMinimofrmProduto.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 155);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 14);
            this.label10.TabIndex = 62;
            this.label10.Text = "Estoque Minimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 14);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nome Produto";
            // 
            // txtCodigofrmProduto
            // 
            this.txtCodigofrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigofrmProduto.Location = new System.Drawing.Point(115, 89);
            this.txtCodigofrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigofrmProduto.Multiline = true;
            this.txtCodigofrmProduto.Name = "txtCodigofrmProduto";
            this.txtCodigofrmProduto.Size = new System.Drawing.Size(206, 23);
            this.txtCodigofrmProduto.TabIndex = 3;
            // 
            // txtQuantidadefrmProduto
            // 
            this.txtQuantidadefrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadefrmProduto.Location = new System.Drawing.Point(460, 120);
            this.txtQuantidadefrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidadefrmProduto.Name = "txtQuantidadefrmProduto";
            this.txtQuantidadefrmProduto.Size = new System.Drawing.Size(197, 22);
            this.txtQuantidadefrmProduto.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 14);
            this.label9.TabIndex = 61;
            this.label9.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 56;
            this.label4.Text = "Código";
            // 
            // txtModelofrmProduto
            // 
            this.txtModelofrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelofrmProduto.Location = new System.Drawing.Point(115, 115);
            this.txtModelofrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtModelofrmProduto.Multiline = true;
            this.txtModelofrmProduto.Name = "txtModelofrmProduto";
            this.txtModelofrmProduto.Size = new System.Drawing.Size(206, 23);
            this.txtModelofrmProduto.TabIndex = 4;
            // 
            // txtValorComprafrmProduto
            // 
            this.txtValorComprafrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorComprafrmProduto.Location = new System.Drawing.Point(460, 68);
            this.txtValorComprafrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorComprafrmProduto.Name = "txtValorComprafrmProduto";
            this.txtValorComprafrmProduto.Size = new System.Drawing.Size(197, 22);
            this.txtValorComprafrmProduto.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 14);
            this.label8.TabIndex = 60;
            this.label8.Text = "Valor Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 57;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 14);
            this.label6.TabIndex = 58;
            this.label6.Text = "Fabricante";
            // 
            // txtCorfrmProduto
            // 
            this.txtCorfrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorfrmProduto.Location = new System.Drawing.Point(115, 166);
            this.txtCorfrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorfrmProduto.Multiline = true;
            this.txtCorfrmProduto.Name = "txtCorfrmProduto";
            this.txtCorfrmProduto.Size = new System.Drawing.Size(206, 23);
            this.txtCorfrmProduto.TabIndex = 6;
            // 
            // txtValorComerciofrmProduto
            // 
            this.txtValorComerciofrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorComerciofrmProduto.Location = new System.Drawing.Point(460, 94);
            this.txtValorComerciofrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorComerciofrmProduto.Name = "txtValorComerciofrmProduto";
            this.txtValorComerciofrmProduto.Size = new System.Drawing.Size(197, 22);
            this.txtValorComerciofrmProduto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 14);
            this.label3.TabIndex = 46;
            this.label3.Text = "Valor Comércio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 14);
            this.label7.TabIndex = 59;
            this.label7.Text = "Cor";
            // 
            // txtFabricantefrmProduto
            // 
            this.txtFabricantefrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFabricantefrmProduto.Location = new System.Drawing.Point(115, 140);
            this.txtFabricantefrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtFabricantefrmProduto.Multiline = true;
            this.txtFabricantefrmProduto.Name = "txtFabricantefrmProduto";
            this.txtFabricantefrmProduto.Size = new System.Drawing.Size(206, 23);
            this.txtFabricantefrmProduto.TabIndex = 5;
            // 
            // txtBuscarProdutofrmProduto
            // 
            this.txtBuscarProdutofrmProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProdutofrmProduto.Location = new System.Drawing.Point(802, 228);
            this.txtBuscarProdutofrmProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProdutofrmProduto.Multiline = true;
            this.txtBuscarProdutofrmProduto.Name = "txtBuscarProdutofrmProduto";
            this.txtBuscarProdutofrmProduto.Size = new System.Drawing.Size(152, 23);
            this.txtBuscarProdutofrmProduto.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(689, 237);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 14);
            this.label11.TabIndex = 69;
            this.label11.Text = "Buscar Produto";
            // 
            // btnBuscarfrmProduto
            // 
            this.btnBuscarfrmProduto.BackColor = System.Drawing.Color.Black;
            this.btnBuscarfrmProduto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarfrmProduto.Location = new System.Drawing.Point(821, 276);
            this.btnBuscarfrmProduto.Name = "btnBuscarfrmProduto";
            this.btnBuscarfrmProduto.Size = new System.Drawing.Size(135, 35);
            this.btnBuscarfrmProduto.TabIndex = 70;
            this.btnBuscarfrmProduto.Text = "Buscar";
            this.btnBuscarfrmProduto.UseVisualStyleBackColor = false;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1006, 634);
            this.Controls.Add(this.grpProdutofrmProduto);
            this.Controls.Add(this.dgvfrmProduto);
            this.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrmProduto)).EndInit();
            this.grpProdutofrmProduto.ResumeLayout(false);
            this.grpProdutofrmProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfrmProduto;
        private System.Windows.Forms.GroupBox grpProdutofrmProduto;
        private System.Windows.Forms.TextBox txtImenfrmProduto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLimparfrmProduto;
        private System.Windows.Forms.Button btnGravarfrmProduto;
        private System.Windows.Forms.TextBox txtCodigoProdutofrmProduto;
        private System.Windows.Forms.Button btnSelecionarfrmProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProdutofrmProduto;
        private System.Windows.Forms.TextBox txtEstoqueMinimofrmProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigofrmProduto;
        private System.Windows.Forms.TextBox txtQuantidadefrmProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelofrmProduto;
        private System.Windows.Forms.TextBox txtValorComprafrmProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorfrmProduto;
        private System.Windows.Forms.TextBox txtValorComerciofrmProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFabricantefrmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorComercio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ativo;
        private System.Windows.Forms.CheckBox chkAtivofrmProduto;
        private System.Windows.Forms.RadioButton rad90diasfrmProduto;
        private System.Windows.Forms.RadioButton rad60diasfrmProduto;
        private System.Windows.Forms.RadioButton rad30diasfrmProduto;
        private System.Windows.Forms.RadioButton rad20diasfrmProduto;
        private System.Windows.Forms.RadioButton rad10diasfrmProduto;
        private System.Windows.Forms.Label DataTerminofrmProduto;
        private System.Windows.Forms.TextBox txtDataTerminofrmProduto;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.Button btnBuscarfrmProduto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscarProdutofrmProduto;
    }
}

