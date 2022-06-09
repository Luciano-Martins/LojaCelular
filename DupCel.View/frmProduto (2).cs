using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DupCel.Model;
using DupCel.Entity;
using System.Data.SqlClient;

using System.Diagnostics;

namespace DupCel.View
{
    public partial class frmProduto : Form
    {
        public ProdutoEntity ProdutoRetorno { get; set; }

        public frmProduto()
        {
            InitializeComponent();
        }


        private void btnSelecionarfrmProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoProdutofrmProduto.Text != "")
                {
                    ProdutoRetorno = new ProdutoEntity();
                    ProdutoRetorno = ProdutoModel.ProdutoBuscaCodigo(Convert.ToInt32(txtCodigoProdutofrmProduto.Text));
                }

                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }       

        private void btnLimparfrmProduto_Click(object sender, EventArgs e)
        {
            LimpaControles();
            txtNomeProdutofrmProduto.Focus();
        }

        private void btnGravarfrmProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarControles() == true)
                {

                    if (txtCodigoProdutofrmProduto.Text == "" && (MessageBox.Show("Posso Gravar esses Dados no Banco?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        Gravar();
                    }
                    else

                        if (txtCodigoProdutofrmProduto.Text != "" && (MessageBox.Show("Posso Atualizar esses Dados no Banco?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            Atualizar();
                        }


                    LimpaControles();
                    CarregaGrid();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }        

        private void frmProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dgvfrmProduto_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvfrmProduto.Rows[e.RowIndex].Cells[0].ToString() != "")
                {
                    txtCodigoProdutofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNomeProdutofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtCodigofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtModelofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtFabricantefrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtCorfrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtImenfrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtValorComprafrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtValorComerciofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtQuantidadefrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtEstoqueMinimofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[10].Value.ToString();
                   chkAtivofrmProduto.Checked = Convert.ToBoolean( dgvfrmProduto.Rows[e.RowIndex].Cells[11].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void dgvfrmProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvfrmProduto.Rows[e.RowIndex].Cells[0].ToString() != "")
                {
                    txtCodigoProdutofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNomeProdutofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtCodigofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtModelofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtFabricantefrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtCorfrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtImenfrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtValorComprafrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtValorComerciofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtQuantidadefrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtEstoqueMinimofrmProduto.Text = dgvfrmProduto.Rows[e.RowIndex].Cells[10].Value.ToString();
                    chkAtivofrmProduto.Checked = Convert.ToBoolean(dgvfrmProduto.Rows[e.RowIndex].Cells[11].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Process[] processos = Process.GetProcessesByName("notepad.exe");

            if (processos.Length == 0)
            {
                Process.Start("notepad.exe");
            }
            else
            {
                MessageBox.Show("O Editor já esta Aberto!", "Alerta ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void rad10diasfrmProduto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime hoje = DateTime.Now;
                if (rad10diasfrmProduto.Checked == true)
                {
                    txtDataTerminofrmProduto.Text = hoje.AddDays(10).ToShortDateString();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void rad20diasfrmProduto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime hoje = DateTime.Now;
                if (rad20diasfrmProduto.Checked == true)
                {
                    txtDataTerminofrmProduto.Text = hoje.AddDays(20).ToShortDateString();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void rad30diasfrmProduto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime hoje = DateTime.Now;
                if (rad30diasfrmProduto.Checked == true)
                {
                    txtDataTerminofrmProduto.Text = hoje.AddDays(30).ToShortDateString();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void rad60diasfrmProduto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime hoje = DateTime.Now;
                if (rad60diasfrmProduto.Checked == true)
                {
                    txtDataTerminofrmProduto.Text = hoje.AddDays(90).ToShortDateString();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void rad90diasfrmProduto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime hoje = DateTime.Now;
                if (rad90diasfrmProduto.Checked == true)
                {
                    txtDataTerminofrmProduto.Text = hoje.AddDays(180).ToShortDateString();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LimpaControles()
        {
            txtCodigoProdutofrmProduto.Clear();
            txtNomeProdutofrmProduto.Clear();
            txtCodigofrmProduto.Clear();
            txtModelofrmProduto.Clear();
            txtFabricantefrmProduto.Clear();
            txtCorfrmProduto.Clear();
            txtImenfrmProduto.Clear();
            txtValorComprafrmProduto.Clear();
            txtValorComerciofrmProduto.Clear();
            txtQuantidadefrmProduto.Clear();
            txtEstoqueMinimofrmProduto.Clear();
            chkAtivofrmProduto.Checked = false;
           
            
        }

        private void Gravar()
        {
            ProdutoEntity Prod = new ProdutoEntity();
           
            Prod.descricao = txtNomeProdutofrmProduto.Text;
            Prod.codigo = txtCodigofrmProduto.Text;
            Prod.modelo = txtModelofrmProduto.Text;
            Prod.fabricante = txtFabricantefrmProduto.Text;
            Prod.cor = txtCorfrmProduto.Text;
            Prod.imen = txtImenfrmProduto.Text;
            Prod.valorcompra =  Convert.ToDecimal (txtValorComprafrmProduto.Text);
            Prod.valorcomercio = Convert.ToDecimal (txtValorComerciofrmProduto.Text);
            Prod.quantidade = Convert.ToInt32 (txtQuantidadefrmProduto.Text);
            Prod.estoqueminimo = Convert.ToInt32(txtEstoqueMinimofrmProduto.Text);
            Prod.ativo = chkAtivofrmProduto.Checked;
            int retorno = 0;
            retorno = ProdutoModel.ProdutoInsere(Prod);
            if (retorno <= 0)
            {
                MessageBox.Show("Houve um erro ao tentar Gravar um novo Produto ");
                return;
            }
            else
            {
                MessageBox.Show("Produto gravado com sucesso ");
                return;
            }
        }

        private void Atualizar()
        {
            ProdutoEntity Prod = new ProdutoEntity();
            Prod.id =  Convert.ToInt32( txtCodigoProdutofrmProduto.Text);
            Prod.descricao = txtNomeProdutofrmProduto.Text;
            Prod.codigo = txtCodigofrmProduto.Text;
            Prod.modelo = txtModelofrmProduto.Text;
            Prod.fabricante = txtFabricantefrmProduto.Text;
            Prod.cor = txtCorfrmProduto.Text;
            Prod.imen = txtImenfrmProduto.Text;
            Prod.valorcompra = Convert.ToDecimal(txtValorComprafrmProduto.Text);
            Prod.valorcomercio = Convert.ToDecimal(txtValorComerciofrmProduto.Text);
            Prod.quantidade = Convert.ToInt32(txtQuantidadefrmProduto.Text);
            Prod.estoqueminimo = Convert.ToInt32(txtEstoqueMinimofrmProduto.Text);
            Prod.ativo = chkAtivofrmProduto.Checked;

            int retorno = 0;

            retorno = ProdutoModel.ProdutoAtualiza(Prod);


            if (retorno <= 0)
            {
                MessageBox.Show("Houve um erro ao tentar Atualizar um novo Produto ");
                return;
            }
            else
            {
                MessageBox.Show("Produto Atualizado com sucesso ");
                return;
            }
        }

        private bool ValidarControles()
        {
            try
            {
                if (txtNomeProdutofrmProduto.Text == "")
                {
                    MessageBox.Show("Digite o Nome do Produto");
                    txtNomeProdutofrmProduto.Focus();
                    return false ;
                }
                if (txtCodigofrmProduto.Text == "")
                {
                    MessageBox.Show("Digite o Código ");
                    txtCodigofrmProduto.Focus();
                    return false;
                }
                if (txtModelofrmProduto.Text == "")
                {
                    MessageBox.Show("Digite o Modelo do Produto");
                    txtModelofrmProduto.Focus();
                    return false;
                }
                if (txtFabricantefrmProduto.Text == "")
                {
                    MessageBox.Show(" Digite o Nome do Fabricante");
                    txtFabricantefrmProduto.Focus();

                    return false;
                }
                if (txtCorfrmProduto.Text == "")
                {
                    MessageBox.Show("Digite a Cor");
                    txtCorfrmProduto.Focus();
                    return false;
                }
                if (txtImenfrmProduto.Text == "")
                {
                    MessageBox.Show("Digite o Imen do Aparelho");
                    txtImenfrmProduto.Focus();
                    return false;
                }


                if (txtValorComprafrmProduto.Text == "")
                {
                    MessageBox.Show(" Digite o Valor de Compra ");
                    txtValorComprafrmProduto.Focus();
                    return false;
                }
                if (txtValorComerciofrmProduto.Text == "")
                {
                    MessageBox.Show("Digite o Valor de Comércio");
                    txtValorComerciofrmProduto.Focus();
                    return false;
                }
                if (txtQuantidadefrmProduto.Text == "")
                {
                    MessageBox.Show("Digite a Quantidade");
                    txtQuantidadefrmProduto.Focus();
                    return false;
                }
                if (txtEstoqueMinimofrmProduto.Text == "")
                {
                    MessageBox.Show("Digite o Estoque Minimo");
                    txtEstoqueMinimofrmProduto.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CarregaGrid()
        {
            try
            {
                List<ProdutoEntity> produtoLista = new List<ProdutoEntity>();
                produtoLista = ProdutoModel.ProdutoBuscaTodos();
                dgvfrmProduto.DataSource = produtoLista;
                dgvfrmProduto.Refresh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
      
    }
}