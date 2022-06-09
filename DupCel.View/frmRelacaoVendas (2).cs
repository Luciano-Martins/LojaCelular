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
        public VendaProdServEntity ObjetosVenda { get; set; }

        public frmRelacaoVendas()
        {
            InitializeComponent();
        }

        private void frmRelacaoVendas_Load(object sender, EventArgs e)
        {

            CarregaGrid();

        }

        private void dgvfrmRelacaoVendas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Código", 100, HorizontalAlignment.Left);
                lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Nome", 200, HorizontalAlignment.Left);
                lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Modelo", 200, HorizontalAlignment.Left);
                lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Valor", 100, HorizontalAlignment.Left);

                lstRelacaoServicofrmRelacaoVendas.Clear();
                lstRelacaoServicofrmRelacaoVendas.Columns.Add("Código", 100, HorizontalAlignment.Center);
                lstRelacaoServicofrmRelacaoVendas.Columns.Add("Descrição", 200, HorizontalAlignment.Center);
                lstRelacaoServicofrmRelacaoVendas.Columns.Add("Observação", 200, HorizontalAlignment.Center);
                lstRelacaoServicofrmRelacaoVendas.Columns.Add("Valor", 100, HorizontalAlignment.Center);

                for (int i = 0; i < vendaProdServEntity.ProdutoList.Count; i++)
                {

                    ListViewItem itemProd = new ListViewItem(vendaProdServEntity.ProdutoList[i].id.ToString());
                    itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].descricao.ToString());
                    itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].modelo.ToString());
                    itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].valorcomercio.ToString());
                    lstRelacaoProdutofrmRelacaoVendas.Items.Add(itemProd);
                


                    for (int a = 0; a < vendaProdServEntity.ServicoList.Count; a++)
                    {
                        ListViewItem itemServ = new ListViewItem(vendaProdServEntity.ServicoList[i].id.ToString());
                        itemServ.SubItems.Add(vendaProdServEntity.ServicoList[a].descricao.ToString());
                        itemServ.SubItems.Add(vendaProdServEntity.ServicoList[a].observacao.ToString());
                        itemServ.SubItems.Add(vendaProdServEntity.ServicoList[a].valor.ToString());
                        lstRelacaoServicofrmRelacaoVendas.Items.Add(itemServ);

                    

                        if (lstRelacaoProdutofrmRelacaoVendas.Items.Count == 1 && lstRelacaoServicofrmRelacaoVendas.Items.Count == 0)
                        {
                            txtCodigoVendafrmRelacaoVendas.Text = vendaProdServEntity.Venda.id.ToString();
                            txtClientefrmRelaçãoVendas.Text = vendaProdServEntity.Venda.idCliente.ToString();
                            txtDatafrmRelacaoVendas.Text = vendaProdServEntity.Venda.data.ToString();
                            txtValorfrmRelacaoVendas.Text = vendaProdServEntity.Venda.valor.ToString();
                            chkAtivofrmRelaçãoVendas.Checked = true;

                            txtCodigoProdutofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].id.ToString();
                            txtNomeProdutofrmRelaçãoVendas.Text = vendaProdServEntity.ProdutoList[i].descricao.ToString();
                            txtModelofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].modelo.ToString();
                            txtValorProdutofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].valorcomercio.ToString();
                            LimpaTxtServico();

                            return;
                        }


                        if (lstRelacaoProdutofrmRelacaoVendas.Items.Count == 0 && lstRelacaoServicofrmRelacaoVendas.Items.Count == 1)
                        {
                            txtCodigoVendafrmRelacaoVendas.Text = vendaProdServEntity.Venda.id.ToString();
                            txtClientefrmRelaçãoVendas.Text = vendaProdServEntity.Venda.idCliente.ToString();
                            txtDatafrmRelacaoVendas.Text = vendaProdServEntity.Venda.data.ToString();
                            txtValorfrmRelacaoVendas.Text = vendaProdServEntity.Venda.valor.ToString();
                            chkAtivofrmRelaçãoVendas.Checked = true;

                            txtCodigoVendafrmRelacaoVendas.Text = vendaProdServEntity.Venda.id.ToString();
                            txtCodigoServicofrmRelacaoVendas.Text = vendaProdServEntity.ServicoList[a].id.ToString();
                            txtDescricaofrmRelacaoServico.Text = vendaProdServEntity.ServicoList[a].descricao.ToString();
                            txtObservacaofrmRelacaoServico.Text = vendaProdServEntity.ServicoList[a].observacao.ToString();
                            txtValorServicofrmRelacaoVendas.Text = vendaProdServEntity.ServicoList[a].valor.ToString();

                            LimpaTxtProduto();
                            return;
                        }
                        if (lstRelacaoProdutofrmRelacaoVendas.Items.Count == 1 && lstRelacaoServicofrmRelacaoVendas.Items.Count == 1)
                        {
                            txtCodigoVendafrmRelacaoVendas.Text = vendaProdServEntity.Venda.id.ToString();
                            txtClientefrmRelaçãoVendas.Text = vendaProdServEntity.Venda.idCliente.ToString();
                            txtDatafrmRelacaoVendas.Text = vendaProdServEntity.Venda.data.ToString();
                            txtValorfrmRelacaoVendas.Text = vendaProdServEntity.Venda.valor.ToString();
                            chkAtivofrmRelaçãoVendas.Checked = true;

                            txtCodigoProdutofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].id.ToString();
                            txtNomeProdutofrmRelaçãoVendas.Text = vendaProdServEntity.ProdutoList[i].descricao.ToString();
                            txtModelofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].modelo.ToString();
                            txtValorProdutofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].valorcomercio.ToString();


                            txtCodigoVendafrmRelacaoVendas.Text = vendaProdServEntity.Venda.id.ToString();
                            txtCodigoServicofrmRelacaoVendas.Text = vendaProdServEntity.ServicoList[a].id.ToString();
                            txtDescricaofrmRelacaoServico.Text = vendaProdServEntity.ServicoList[a].descricao.ToString();
                            txtObservacaofrmRelacaoServico.Text = vendaProdServEntity.ServicoList[a].observacao.ToString();
                            txtValorServicofrmRelacaoVendas.Text = vendaProdServEntity.ServicoList[a].valor.ToString();

                        }

                    }
        }} 
            
            catch (Exception ex)
            {

                throw ex;
            }
        }
     
        private void dgvfrmRelacaoVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Código", 100, HorizontalAlignment.Left);
                lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Nome", 200, HorizontalAlignment.Left);
                lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Modelo", 200, HorizontalAlignment.Left);
                lstRelacaoProdutofrmRelacaoVendas.Columns.Add("Valor", 100, HorizontalAlignment.Left);
                for (int i = 0; i < vendaProdServEntity.ProdutoList.Count; i++)
                {

                    ListViewItem itemProd = new ListViewItem(vendaProdServEntity.ProdutoList[i].id.ToString());
                    itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].descricao.ToString());
                    itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].modelo.ToString());
                    itemProd.SubItems.Add(vendaProdServEntity.ProdutoList[i].valorcomercio.ToString());
                    lstRelacaoProdutofrmRelacaoVendas.Items.Add(itemProd);


                    lstRelacaoServicofrmRelacaoVendas.Clear();
                    lstRelacaoServicofrmRelacaoVendas.Columns.Add("Código", 100, HorizontalAlignment.Center);
                    lstRelacaoServicofrmRelacaoVendas.Columns.Add("Descrição", 200, HorizontalAlignment.Center);
                    lstRelacaoServicofrmRelacaoVendas.Columns.Add("Observação", 200, HorizontalAlignment.Center);
                    lstRelacaoServicofrmRelacaoVendas.Columns.Add("Valor", 100, HorizontalAlignment.Center);


                    for (int a = 0; a < vendaProdServEntity.ServicoList.Count; a++)
                    {
                        ListViewItem itemServ = new ListViewItem(vendaProdServEntity.ServicoList[a].id.ToString());
                        itemServ.SubItems.Add(vendaProdServEntity.ServicoList[a].descricao.ToString());
                        itemServ.SubItems.Add(vendaProdServEntity.ServicoList[a].observacao.ToString());
                        itemServ.SubItems.Add(vendaProdServEntity.ServicoList[a].valor.ToString());
                        lstRelacaoServicofrmRelacaoVendas.Items.Add(itemServ);


                        if (lstRelacaoProdutofrmRelacaoVendas.Items.Count == 1 && lstRelacaoServicofrmRelacaoVendas.Items.Count == 0)
                        {
                            txtCodigoVendafrmRelacaoVendas.Text = vendaProdServEntity.Venda.id.ToString();
                            txtClientefrmRelaçãoVendas.Text = vendaProdServEntity.Venda.idCliente.ToString();
                            txtDatafrmRelacaoVendas.Text = vendaProdServEntity.Venda.data.ToString();
                            txtValorfrmRelacaoVendas.Text = vendaProdServEntity.Venda.valor.ToString();
                            chkAtivofrmRelaçãoVendas.Checked = true;

                            txtCodigoProdutofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].id.ToString();
                            txtNomeProdutofrmRelaçãoVendas.Text = vendaProdServEntity.ProdutoList[i].descricao.ToString();
                            txtModelofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].modelo.ToString();
                            txtValorProdutofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].valorcomercio.ToString();

                            LimpaTxtServico();
                            return;
                        }
                        if (lstRelacaoProdutofrmRelacaoVendas.Items.Count == 0 && lstRelacaoServicofrmRelacaoVendas.Items.Count == 1)
                        {
                            txtCodigoVendafrmRelacaoVendas.Text = vendaProdServEntity.Venda.id.ToString();
                            txtClientefrmRelaçãoVendas.Text = vendaProdServEntity.Venda.idCliente.ToString();
                            txtDatafrmRelacaoVendas.Text = vendaProdServEntity.Venda.data.ToString();
                            txtValorfrmRelacaoVendas.Text = vendaProdServEntity.Venda.valor.ToString();
                            chkAtivofrmRelaçãoVendas.Checked = true;

                            txtCodigoServicofrmRelacaoVendas.Text = vendaProdServEntity.ServicoList[i].id.ToString();
                            txtDescricaofrmRelacaoServico.Text = vendaProdServEntity.ServicoList[i].descricao.ToString();
                            txtObservacaofrmRelacaoServico.Text = vendaProdServEntity.ServicoList[i].observacao.ToString();

                            LimpaTxtProduto();
                            return;
                        }
                        if (lstRelacaoProdutofrmRelacaoVendas.Items.Count == 1 && lstRelacaoServicofrmRelacaoVendas.Items.Count == 1)
                        {
                            txtCodigoVendafrmRelacaoVendas.Text = vendaProdServEntity.Venda.id.ToString();
                            txtClientefrmRelaçãoVendas.Text = vendaProdServEntity.Venda.idCliente.ToString();
                            txtDatafrmRelacaoVendas.Text = vendaProdServEntity.Venda.data.ToString();
                            txtValorfrmRelacaoVendas.Text = vendaProdServEntity.Venda.valor.ToString();
                            chkAtivofrmRelaçãoVendas.Checked = true;

                            txtCodigoProdutofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].id.ToString();
                            txtNomeProdutofrmRelaçãoVendas.Text = vendaProdServEntity.ProdutoList[i].descricao.ToString();
                            txtModelofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].modelo.ToString();
                            txtValorProdutofrmRelacaoVendas.Text = vendaProdServEntity.ProdutoList[i].valorcomercio.ToString();


                            txtCodigoVendafrmRelacaoVendas.Text = vendaProdServEntity.Venda.id.ToString();
                            txtCodigoServicofrmRelacaoVendas.Text = vendaProdServEntity.ServicoList[a].id.ToString();
                            txtDescricaofrmRelacaoServico.Text = vendaProdServEntity.ServicoList[a].descricao.ToString();
                            txtObservacaofrmRelacaoServico.Text = vendaProdServEntity.ServicoList[a].observacao.ToString();
                            txtValorServicofrmRelacaoVendas.Text = vendaProdServEntity.ServicoList[a].valor.ToString();

                        }


                    }
                }
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

        public void LimpaTxtProduto()
        {
            txtCodigoProdutofrmRelacaoVendas.Clear();
            txtNomeProdutofrmRelaçãoVendas.Clear();
            txtModelofrmRelacaoVendas.Clear();
            txtValorProdutofrmRelacaoVendas.Clear();
 
        }

        public void LimpaTxtServico()
        {
            txtCodigoServicofrmRelacaoVendas.Clear();
            txtDescricaofrmRelacaoServico.Clear();
            txtObservacaofrmRelacaoServico.Clear();
 
        }
   
    }
}