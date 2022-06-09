using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DupCel.View;
using DupCel.Model;
using DupCel.Entity;

using System.Data.SqlClient;


namespace DupCel.View
{
    public partial class frmServico : Form
    {
        public  ServicoEntity ServicoRetorno { get; set; }

        public frmServico()
        {
            InitializeComponent();
        }

        private void btnGravarfrmServico_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidarControles() == true)

                {
                if (txtCodigoServicofrmServico.Text == "" && (MessageBox.Show("Posso Gravar esses Dados no Banco?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {


                    Gravar();
                }
                else

                    if (txtCodigoServicofrmServico.Text != "" && (MessageBox.Show("Posso Atualizar esses Dados no Banco?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        Atualizar();
                    }


                LimpaControles();
                CarregaGrid();

            }
          }
            catch (Exception ex)
            {
                
                throw ex;
            }

          


   
            }

        private void btnLimparfrmServico_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaControles();
                txtDescricaofrmServico.Focus();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
          
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaGrid();
                
                DateTime hoje = DateTime.Now;
                txtDataTerminofrmServico.Text = hoje.AddDays(10).ToShortDateString();
                rad10diasfrmServico.Checked = true;

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        private void dgvfrmServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvfrmServico.Rows[e.RowIndex].Cells[0].ToString() != "")
                {
                    txtCodigoServicofrmServico.Text = dgvfrmServico.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtDescricaofrmServico.Text = dgvfrmServico.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtObservacaofrmServico.Text = dgvfrmServico.Rows[e.RowIndex].Cells[2].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                throw ex ;
            }


        }

        private void dgvfrmServico_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvfrmServico.Rows[e.RowIndex].Cells[0].ToString() != "")
                {
                    txtCodigoServicofrmServico.Text = dgvfrmServico.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtDescricaofrmServico.Text = dgvfrmServico.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtObservacaofrmServico.Text = dgvfrmServico.Rows[e.RowIndex].Cells[2].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnSelecionarfrmServico_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoServicofrmServico.Text != "")
                {

                    if (ValidaValor() == false)
                        return;
                                        
                    ServicoRetorno = new ServicoEntity();
                    ServicoRetorno = ServicoModel.ServicoBuscaCodigo(Convert.ToInt32(txtCodigoServicofrmServico.Text));
                    ServicoRetorno.valor = Convert.ToDecimal(txtValorfrmServico.Text);

                    DateTime tempo = new DateTime();
                    if(!DateTime.TryParse(txtDataTerminofrmServico.Text, out tempo))
                    {
                        MessageBox.Show("Informe uma data válida !");
                        txtDataTerminofrmServico.Focus();
                        return;
                    }
                    ServicoRetorno.Garantia.temposervico = tempo;
                }
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rad10diasfrmServico_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime hoje = DateTime.Now;
                if (rad10diasfrmServico.Checked == true)
                {
                    txtDataTerminofrmServico.Text = hoje.AddDays(10).ToShortDateString();
                }

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void rad20diasfrmServico_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime hoje = DateTime.Now;
                if (rad20diasfrmServico.Checked == true)
                {
                    txtDataTerminofrmServico.Text = hoje.AddDays(20).ToShortDateString();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void rad30diasfrmServico_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime hoje = DateTime.Now;
                if (rad30diasfrmServico.Checked == true)
                {
                    txtDataTerminofrmServico.Text = hoje.AddDays(30).ToShortDateString();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void rad90diasfrmServico_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime hoje = DateTime.Now;
                if (rad90diasfrmServico.Checked == true)
                {
                    txtDataTerminofrmServico.Text = hoje.AddDays(90).ToShortDateString();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void rad180diasfrmServico_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime hoje = DateTime.Now;
                if (rad180diasfrmServico.Checked == true)
                {
                    txtDataTerminofrmServico.Text = hoje.AddDays(180).ToShortDateString();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void LimpaControles()
        {
            try
            {
                txtCodigoServicofrmServico.Clear();
                txtDescricaofrmServico.Clear();
                txtObservacaofrmServico.Clear();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void Gravar()
        {
            try
            {
                ServicoEntity serv = new ServicoEntity();
                serv.descricao = txtDescricaofrmServico.Text;
                serv.observacao = txtObservacaofrmServico.Text;


                int retorno = 0;
                retorno = ServicoModel.ServicoInsere(serv);
                if (retorno <= 0)
                {
                    MessageBox.Show("Houve um erro ao tentar Gravar um novo Serviço ");
                    return;
                }
                else
                {
                    MessageBox.Show("Serviço gravado com sucesso ");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void Atualizar()
        {
            try
            {
                ServicoEntity serv = new ServicoEntity();
                serv.id = Convert.ToInt32(txtCodigoServicofrmServico.Text);
                serv.descricao = txtDescricaofrmServico.Text;
                serv.observacao = txtObservacaofrmServico.Text;


                int retorno = 0;
                retorno = ServicoModel.ServicoAtualiza(serv);
                if (retorno <= 0)
                {
                    MessageBox.Show("Houve um erro ao tentar Atualiza o novo Serviço ");
                    return;
                }
                else
                {
                    MessageBox.Show("Serviço atualizado com sucesso ");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private bool ValidarControles()
        {
            try
            {

                if (txtDescricaofrmServico.Text == "")
                {
                    MessageBox.Show(" Informe a Descrição do Serviço");
                    txtDescricaofrmServico.Focus();
                    return false;
                }
                if (txtObservacaofrmServico.Text == "")
                {
                    MessageBox.Show("Descreva uma observação");
                    txtObservacaofrmServico.Focus();

                    return false;
                }

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidaValor()
        {
            try
            {
                if (txtValorfrmServico.Text == "")
                {
                    MessageBox.Show("Digite um Valor");
                    txtValorfrmServico.Focus();
                    return false;
                }

                decimal valor = 0;
                if (!decimal.TryParse(txtValorfrmServico.Text, out valor))
                {
                    MessageBox.Show("Valor Incorreto");
                    txtValorfrmServico.Focus();
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
                List<ServicoEntity> ServicoLista = new List<ServicoEntity>();
                ServicoLista = ServicoModel.ServicoBuscaTodos();
                dgvfrmServico.DataSource = ServicoLista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }    
}
