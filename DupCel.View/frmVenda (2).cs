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
    public partial class frmVenda :  Form 
    {
        private int id { get; set; }

        public VendaProdServEntity Venda { get; set; }
           
        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            lstProduto.Clear();
            lstProduto.Columns.Add("Código", 300, HorizontalAlignment.Center);
            lstProduto.Columns.Add("Modelo", 300, HorizontalAlignment.Center);
            lstProduto.Columns.Add("Valor", 300, HorizontalAlignment.Center);

            lstServico.Clear();
            lstServico.Columns.Add("Código", 100, HorizontalAlignment.Center);
            lstServico.Columns.Add("Descrição", 300, HorizontalAlignment.Center);
            lstServico.Columns.Add("Observação", 300, HorizontalAlignment.Center);
            lstServico.Columns.Add("Valor", 100, HorizontalAlignment.Center);

            txtValorTotalfrmVenda.Text = "0,00";
            Venda = new VendaProdServEntity();

            ClienteEntity clienteEntity = new ClienteEntity();
            clienteEntity = ClienteModel.ClienteBuscaCodigo(1);
            if (clienteEntity != null)
            {
                lstCliente.Clear();
                lstCliente.Items.Add(clienteEntity.id.ToString());
                lstCliente.Items.Add(clienteEntity.nome);
                lstCliente.Items.Add(clienteEntity.endereco);
                lstCliente.Items.Add(clienteEntity.telefone);
                lstCliente.Items.Add(clienteEntity.email);
                Venda.Cliente = clienteEntity;
            }  
        }

        private void btnProdutofrmVendas_Click(object sender, EventArgs e)
        {
            VendaProduto();
           
        }

        private void btnServicofrmVenda_Click(object sender, EventArgs e)
        {
            VendaServico();
        }
    
        private void btnClientefrmVendas_Click(object sender, EventArgs e)
        {
            frmCliente fc = new frmCliente();
            fc.ShowDialog();

            lstCliente.Clear();
            Venda.Cliente = new ClienteEntity();
            ClienteEntity Cliente = new ClienteEntity();
            Cliente = fc.ClienteRetorno;

                if (Cliente != null)
                {

                    lstCliente.Items.Add(Cliente.id.ToString());
                    lstCliente.Items.Add(Cliente.nome);
                    lstCliente.Items.Add(Cliente.endereco);
                    lstCliente.Items.Add(Cliente.telefone);
                    lstCliente.Items.Add(Cliente.email);
                    Venda.Cliente = Cliente;
                }           
            }

        private void btnFinalizarComprafrmVenda_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valorpagocliente = 0;
                if (!decimal.TryParse(txtValorPagofrmVendas.Text, out  valorpagocliente))
                {
                    MessageBox.Show("NÃO POSSO FINALIZAR A COMPRA ! INFORME O VALOR PAGO!");
                
                    return;

                }
                decimal valor = 0;
                if (!decimal.TryParse(txtValorTotalfrmVenda.Text, out valor))
                {
                    MessageBox.Show("VALOR INCORRETO");
                    txtValorTotalfrmVenda.Focus();
                    return;
                }

                if (lstProduto.Items.Count <= 0 && lstServico.Items.Count <= 0)
                {
                    MessageBox.Show("NÃO POSSO FINALIZAR A COMPRA ! NÃO A NADA SELECIONADO! ");
                    return;
                }

                if (lstProduto.Items.Count >= 1)
                {

                    Venda.Venda.data = DateTime.Now;
                    Venda.Venda.valor = valor;
                    Venda.Venda.ativo = true;
                    Venda.Venda.idCliente = 1;
                }
                if ( lstServico.Items.Count >=1)
                  {                 
                    Venda.Venda.data = DateTime.Now;
                    Venda.Venda.valor = valor;
                    Venda.Venda.ativo = true;
                    Venda.Venda.idCliente = Venda.Cliente.id;
                  }
           


                int idVendaRetorno = 0;
                    idVendaRetorno = VendaModel.VendaInsere(Venda.Venda);

                
                if (idVendaRetorno >= 1)
                {
                   
                    ConfirmacaoVenda();
                    MessageBox.Show("VENDA EFETIVADA COM SUCESSO !");
                }

                else
                {
                    MessageBox.Show("VENDA NÃO EFETIVADA");
                  
                    return;
                }

             
                int quantidadeProduto = 0;
                int quantidadeServico = 0;
                bool produtoMaior = false;
                bool servicoMaior = false;


                if (Venda.ProdutoList.Count > 0)
                {
                    quantidadeProduto = Venda.ProdutoList.Count;
                }
                if (Venda.ServicoList.Count > 0)
                {
                    quantidadeServico = Venda.ServicoList.Count;
                }

                if (quantidadeProduto >= quantidadeServico)
                {
                    produtoMaior = true;
                }
                if (quantidadeProduto < quantidadeServico)
                {
                    servicoMaior = true;
                }

                if (produtoMaior == true)
                {
                    if (quantidadeServico < 1)
                    {
                        for (int i = 0; i < Venda.ProdutoList.Count; i++)
                        {
                            VendaProdServModel.VendaInsere(idVendaRetorno, Venda.ProdutoList[i].id ,Venda.ProdutoList[i].valorcomercio, 0, 0);
                           
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Venda.ProdutoList.Count; i++)
                        {
                            VendaProdServModel.VendaInsere(idVendaRetorno, Venda.ProdutoList[i].id, Venda.ProdutoList[i].valorcomercio, Venda.ServicoList[i].id, Venda.ServicoList[i].valor);
                           
                        }
                    }
                }

                if (servicoMaior == true)
                {
                    if (quantidadeProduto < 1)
                    {
                        for (int i = 0; i < Venda.ServicoList.Count; i++)
                        {
                            VendaProdServModel.VendaInsere(idVendaRetorno,  0,  0, Venda.ServicoList[i].id,Venda.ServicoList[i].valor);
                        
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Venda.ServicoList.Count; i++)
                        {
                            VendaProdServModel.VendaInsere(idVendaRetorno, Venda.ProdutoList[i].id, Venda.ProdutoList[i].valorcomercio, Venda.ServicoList[i].id, Venda.ServicoList[i].valor);
                           
                        }
                    }
                }

                lstProduto.Items.Clear();
                lstServico.Items.Clear();
                txtValorTotalfrmVenda.Text = "0,00";
                txtValorPagofrmVendas.Clear();
                txtValorTrocofrmVendas.Clear();
                Venda = new VendaProdServEntity();
            }
            catch (Exception ex)
            {

                throw ex;
            }
    }
 
        private void lstProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete )
            {


                int selecionado = Convert.ToInt32(lstProduto.SelectedItems.Count);
                if (selecionado != 1)
                {
                    MessageBox.Show("Selecione  no um linha ");
                    return;
                }

                int idProduto = 0;
                if (!int.TryParse(lstProduto.SelectedItems[0].Text, out idProduto))
                {
                    MessageBox.Show("Houve um erro do Sistema chame o Luciano!");
                    return;
                }

                foreach (ProdutoEntity produto in Venda.ProdutoList)
                {
                    if (produto.id == idProduto)
                    {
                        Venda.ProdutoList.Remove(produto);
                        break;
                    }


                }
            }

        }

        private void btnExcluiItemfrmVendas_Click(object sender, EventArgs e)
        {
            if (lstProduto.SelectedItems.Count != 0)
            {
                    ExcluirProduto();
                    MessageBox.Show("EXCLUSÃO FEITA COM SUCESSO !");
                    return;
            }
          if (lstServico.SelectedItems.Count != 0)
            {
                    ExcluirServico();
                    MessageBox.Show("EXCLUSÃO FEITA COM SUCESSO !");
               
                    return;
            }
          if (   lstProduto.SelectedItems.Count <= 0  &&  lstServico.SelectedItems.Count <= 0 )
            {
                
                MessageBox.Show("Não a Nenhum Ìtem selecionado para Excluir !"); 
                     return;
            }

        }

        private void txtValorPagofrmVendas_TextChanged(object sender, EventArgs e)
        {

            decimal valorpagocliente = 0;
            if (!decimal.TryParse(txtValorPagofrmVendas.Text, out  valorpagocliente))
            {

                txtValorPagofrmVendas.Focus();
                txtValorTrocofrmVendas.Clear();
                return;

            }
            else
            {
                decimal total = Convert.ToDecimal(txtValorTotalfrmVenda.Text);
                decimal valorpago = Convert.ToDecimal(txtValorPagofrmVendas.Text);
                string troco = Convert.ToString(valorpago - total);

                txtValorTrocofrmVendas.Text = troco;
                return;
            }
               

            
        }

        private void CalculaTotal()
        {
            decimal total = 0;
            for (int i = 0; i < Venda.ProdutoList.Count; i++)
            {
                total += Venda.ProdutoList[i].valorcomercio;

            }

            for (int i = 0; i < Venda.ServicoList.Count; i++)
            {
                total += Venda.ServicoList[i].valor;
            }
            txtValorTotalfrmVenda.Text = total.ToString();
        }

        private void ExcluirProduto()
        {
            try
            {
                int selecionado = Convert.ToInt32(lstProduto.SelectedItems.Count);
                if (selecionado != 1)
                {
                    MessageBox.Show("Selecione a Linha a ser Excluida");
                    return;
                }

                int idProduto = 0;
                if (!int.TryParse(lstProduto.SelectedItems[0].Text, out idProduto))
                {
                    MessageBox.Show("Houve um Erro de Sistema Chame o Luciano");
                    return;
                }

                foreach (ProdutoEntity produto in Venda.ProdutoList)
                {
                    if (produto.id == idProduto)
                    {
                        Venda.ProdutoList.Remove(produto);
                   
                       
                        break;
                    }
                }

                if (Venda.ProdutoList.Count >= 0)
                {
                    lstProduto.Clear();
                    lstProduto.Columns.Add("Código", 200, HorizontalAlignment.Center);
                    lstProduto.Columns.Add("Modelo", 200, HorizontalAlignment.Center);
                    lstProduto.Columns.Add("Valor", 200, HorizontalAlignment.Center);

                    //foreach (ProdutoEntity prod in Venda.ProdutoList)
                    //{
                    //    ListViewItem item = new ListViewItem(prod.id.ToString());
                    //    item.SubItems.Add(prod.modelo.ToString());
                    //    item.SubItems.Add(prod.valorcomercio.ToString());
                    //    lstProduto.Items.Add(item);
                    //}

                    for (int i = 0; i < Venda.ProdutoList.Count; i++)
                    {

                        ListViewItem item = new ListViewItem(Venda.ProdutoList[i].id.ToString());
                        item.SubItems.Add(Venda.ProdutoList[i].modelo.ToString());
                        item.SubItems.Add(Venda.ProdutoList[i].valorcomercio.ToString());
                        lstProduto.Items.Add(item);
                    }
                    CalculaTotal();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
           
        }

        private void ExcluirServico()
        {
            try
            {
                int selecionado = Convert.ToInt32(lstServico.SelectedItems.Count);
                if (selecionado != 1)
                {
                    MessageBox.Show("Selecione a linha de Serviço  a ser Excluida");
                    return;
                }

                int idServico = 0;
                if (!int.TryParse(lstServico.SelectedItems[0].Text, out idServico))
                {
                    MessageBox.Show(" Houve um Erro de Sistema Chame o Luciano");
                    return;
                }

                foreach (ServicoEntity servico in Venda.ServicoList)
                {
                    if (servico.id == idServico)
                    {
                        Venda.ServicoList.Remove(servico);
                      
                        break;
                    }
                }

                if (Venda.ServicoList.Count >= 0)
                {
                    lstServico.Clear();
                    lstServico.Columns.Add("Código", 200, HorizontalAlignment.Center);
                    lstServico.Columns.Add("Descrição", 200, HorizontalAlignment.Center);
                    lstServico.Columns.Add("Observação", 200, HorizontalAlignment.Center);



                    //foreach (ServicoEntity serv in Venda.ServicoList)
                    //{
                    //    ListViewItem item = new ListViewItem(serv.id.ToString());
                    //    item.SubItems.Add(serv.descricao.ToString());
                    //    item.SubItems.Add(serv.observacao.ToString());
                    //    ServicoList.Items.Add(item);
                    //}

                    for (int i = 0; i < Venda.ServicoList.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(Venda.ServicoList[i].id.ToString());
                        item.SubItems.Add(Venda.ServicoList[i].descricao.ToString());
                        item.SubItems.Add(Venda.ServicoList[i].observacao.ToString());
                        lstServico.Items.Add(item);
                    }
                }

            }
            catch (Exception)
            {
                
                throw;
            }
            
            CalculaTotal();
        }
              
        private void VendaProduto()
        {
            try
            {
                frmProduto fc = new frmProduto();
                fc.ShowDialog();

                ProdutoEntity Produto = new ProdutoEntity();
                Produto = fc.ProdutoRetorno;

                if (Produto != null)
                {
                    Venda.ProdutoList.Add(Produto);
                }

                if (Venda.ProdutoList.Count > 0)
                {
                    lstProduto.Clear();
                    lstProduto.Columns.Add("Código", 200, HorizontalAlignment.Left);
                    lstProduto.Columns.Add("Nome", 200, HorizontalAlignment.Left);
                    lstProduto.Columns.Add("Modelo", 200, HorizontalAlignment.Left);
                    lstProduto.Columns.Add("Valor", 200, HorizontalAlignment.Left);

                    //foreach (ProdutoEntity prod in Venda.ProdutoList)
                    //{
                    //    ListViewItem item = new ListViewItem(prod.id.ToString());
                    //    item.SubItems.Add(prod.modelo.ToString());
                    //    item.SubItems.Add(prod.valorcomercio.ToString());
                    //    lstProduto.Items.Add(item);
                    //}

                    for (int i = 0; i < Venda.ProdutoList.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(Venda.ProdutoList[i].id.ToString());
                        item.SubItems.Add(Venda.ProdutoList[i].descricao.ToString());
                        item.SubItems.Add(Venda.ProdutoList[i].modelo.ToString());
                        item.SubItems.Add(Venda.ProdutoList[i].valorcomercio.ToString());
                        lstProduto.Items.Add(item);
                    }
                }

                CalculaTotal();
        
            
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
         
        }

        private void VendaServico()
        {
            try
            {
                ServicoEntity Servico = new ServicoEntity();
                frmServico fs = new frmServico();
                fs.ShowDialog();
                Servico = fs.ServicoRetorno;

                if (Servico != null)
                {
                    Venda.ServicoList.Add(Servico);
                }

                if (Venda.ServicoList.Count > 0)
                {
                    lstServico.Clear();
                    lstServico.Columns.Add("Código", 150, HorizontalAlignment.Left);
                    lstServico.Columns.Add("Descrição", 150, HorizontalAlignment.Left);
                    lstServico.Columns.Add("Observação", 150, HorizontalAlignment.Left);
                    lstServico.Columns.Add("Valor", 150, HorizontalAlignment.Left);


                    foreach (ServicoEntity serv in Venda.ServicoList)
                    {
                        ListViewItem item = new ListViewItem(serv.id.ToString());
                        item.SubItems.Add(serv.descricao.ToString());
                        item.SubItems.Add(serv.observacao.ToString());
                        item.SubItems.Add(serv.valor.ToString());
                        lstServico.Items.Add(item);
                    }

                    //for (int i = 0; i < Venda.ServicoList.Count; i++)
                    //{
                    //    ListViewItem item = new ListViewItem(Venda.ServicoList[i].id.ToString());
                    //    item.SubItems.Add(Venda.ServicoList[i].descricao.ToString());
                    //    item.SubItems.Add(Venda.ServicoList[i].observacao.ToString());
                    //    item.SubItems.Add(Venda.ServicoList[i].valor.ToString());

                    //    lstServico.Items.Add(item);
                    //}

                }
                CalculaTotal();

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
           
        }

        private bool ConfirmacaoVenda()
        {
            if ( lstProduto.Items.Count <= 0   &&  lstServico.Items.Count >= 1 )
            {

                if (MessageBox.Show(" Posso Gravar Venda? ", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    
                    return true;

                }
             if ( lstProduto.Items.Count >= 1   &&  lstServico.Items.Count >= 1 )
            {

                if (MessageBox.Show(" Posso Gravar Venda? ", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    
                    return true;

                }
             if ( lstProduto.Items.Count >= 1  &&  lstServico.Items.Count <= 0 )
            {

                if (MessageBox.Show(" Posso Gravar Venda? ", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    
                    return true;

                }
     
            return true;
        
     }
           
    }
 }


