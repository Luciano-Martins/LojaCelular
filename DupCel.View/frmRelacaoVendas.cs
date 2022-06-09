using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DupCel.Entity;
using DupCel.Model;

namespace DupCel.View
{
    public partial class frmRelacaoVendas : Form
    {
        //public VendaProdServEntity ObjetosVenda { get; set; }

        public frmRelacaoVendas()
        {
            InitializeComponent();
        }

        private void frmRelacaoVendas_Load(object sender, EventArgs e)
        {

            CarregaGrid();

        }

        private void CarregaGrid()
        {
            try
            {

                List<VendaEntity> venda = new List<VendaEntity>();
                venda = VendaModel.VendaBuscaTodos();
                dgvfrmRelacaoVendas.DataSource = venda;
                dgvfrmRelacaoVendas.Refresh();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvfrmRelacaoVendas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvfrmRelacaoVendas.Rows[e.RowIndex].Cells[0].ToString() == "")
            {
                return;
            }

            int idVenda = 0;
            if (!int.TryParse(dgvfrmRelacaoVendas.Rows[e.RowIndex].Cells[0].Value.ToString(), out idVenda))
            {
                return;
            }

            VendaProdServEntity vendaProdServEntity = new VendaProdServEntity();
            //vendaProdServEntity = VendaProdServModel.VendaProdServBuscaCodigo(idVenda);
            vendaProdServEntity = VendaProdServModel.ProcVendaServProdPorIdVenda(idVenda);

            if (vendaProdServEntity == null)
            {
                return;
            }

             lstRelacaoProdutofrmRelacaoVendas.Clear();
             lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Código", 200, HorizontalAlignment.Left);
             lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Nome", 200, HorizontalAlignment.Left);
             lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Modelo", 200, HorizontalAlignment.Left);
             lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Valor", 200, HorizontalAlignment.Left);
             for (int i = 0; i < vendaProdServEntity.ProdutoList.Count; i++)
             {

                 ListViewItem itemProd = new ListViewItem(vendaProdServEntity.ProdutoList[i].id.ToString());
                 itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].descricao.ToString());
                 itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].modelo.ToString());
                 itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].valorcomercio.ToString());
                 lstRelacaoProdutofrmRelacaoVendas.Items.Add(itemProd);
             }

             lstRelacaoServicofrmRelacaoVendas.Clear();
             lstRelacaoServicofrmRelacaoVendas.Columns.Add("Código", 200, HorizontalAlignment.Center);
             lstRelacaoServicofrmRelacaoVendas.Columns.Add("Descrição", 200, HorizontalAlignment.Center);
             lstRelacaoServicofrmRelacaoVendas.Columns.Add("Observação", 200, HorizontalAlignment.Center);
             for (int i = 0; i < vendaProdServEntity.ServicoList.Count; i++)
            {
                ListViewItem itemServ = new ListViewItem(vendaProdServEntity.ServicoList[i].id.ToString());
                itemServ.SubItems.Add(vendaProdServEntity.ServicoList[i].descricao.ToString());
                itemServ.SubItems.Add(vendaProdServEntity.ServicoList[i].observacao.ToString());
                itemServ.SubItems.Add(vendaProdServEntity.ServicoList[i].valor.ToString());
                lstRelacaoServicofrmRelacaoVendas.Items.Add(itemServ);
            }
        }

        private void dgvfrmRelacaoVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvfrmRelacaoVendas.Rows[e.RowIndex].Cells[0].ToString() == "")
            {
                return;
            }

            int idVenda = 0;
            if (!int.TryParse(dgvfrmRelacaoVendas.Rows[e.RowIndex].Cells[0].Value.ToString(), out idVenda))
            {
                return;
            }

            VendaProdServEntity vendaProdServEntity = new VendaProdServEntity();
            //vendaProdServEntity = VendaProdServModel.VendaProdServBuscaCodigo(idVenda);
            vendaProdServEntity = VendaProdServModel.ProcVendaServProdPorIdVenda(idVenda);

            if (vendaProdServEntity == null)
            {
                return;
            }

            lstRelacaoProdutofrmRelacaoVendas.Clear();
            lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Código", 200, HorizontalAlignment.Left);
            lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Modelo", 200, HorizontalAlignment.Left);
            lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Valor", 200, HorizontalAlignment.Left);
            for (int i = 0; i < vendaProdServEntity.ProdutoList.Count; i++)
            {
                ListViewItem itemProd = new ListViewItem(vendaProdServEntity.ProdutoList[i].id.ToString());
                itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].descricao.ToString());
                itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].modelo.ToString());
                itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].valorcomercio.ToString());
                lstRelacaoProdutofrmRelacaoVendas.Items.Add(itemProd);
            }


            lstRelacaoServicofrmRelacaoVendas.Clear();
            lstRelacaoServicofrmRelacaoVendas.Columns.Add("Código", 200, HorizontalAlignment.Center);
            lstRelacaoServicofrmRelacaoVendas.Columns.Add("Descrição", 200, HorizontalAlignment.Center);
            lstRelacaoServicofrmRelacaoVendas.Columns.Add("Observação", 200, HorizontalAlignment.Center);
            for (int i = 0; i < vendaProdServEntity.ServicoList.Count; i++)
            {
                ListViewItem itemServ = new ListViewItem(vendaProdServEntity.ServicoList[i].id.ToString());
                itemServ.SubItems.Add(vendaProdServEntity.ServicoList[i].descricao.ToString());
                itemServ.SubItems.Add(vendaProdServEntity.ServicoList[i].observacao.ToString());
                itemServ.SubItems.Add(vendaProdServEntity.ServicoList[i].valor.ToString());
                lstRelacaoServicofrmRelacaoVendas.Items.Add(itemServ);
            }
        }

        private void lstRelacaoProdutofrmRelacaoVendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoVendafrmRelacaoVendas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}