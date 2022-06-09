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
    public partial class frmCliente : Form
    {
        public ClienteEntity ClienteRetorno { get; set; }

        public frmCliente()
        {
            InitializeComponent();           
        }

        private void btnSelecionarfrmCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoClientefrmCliente.Text != "")
                {
                    ClienteRetorno = new ClienteEntity();
                    ClienteRetorno = ClienteModel.ClienteBuscaCodigo(Convert.ToInt32(txtCodigoClientefrmCliente.Text));
                }
                this.Hide();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaGrid();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        private void dgvfrmCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvfrmCliente.Rows[e.RowIndex].Cells[0].ToString() != "")
                {
                    txtCodigoClientefrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNomeClientefrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtEnderecofrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtNumerofrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtComplementofrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtBairrofrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtCidadefrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtEstadofrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
                    mskTelefonefrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtEmailfrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[9].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvfrmCliente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvfrmCliente.Rows[e.RowIndex].Cells[0].ToString() != "")
                {
                    txtCodigoClientefrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtNomeClientefrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtEnderecofrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtNumerofrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtComplementofrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtBairrofrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtCidadefrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtEstadofrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
                    mskTelefonefrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtEmailfrmCliente.Text = dgvfrmCliente.Rows[e.RowIndex].Cells[9].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnLimparfrmCliente_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaControles();
                txtNomeClientefrmCliente.Focus();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
          
        }

        private void btnGravarfrmCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarControles() == true)
                {

                    if (txtCodigoClientefrmCliente.Text == "" && (MessageBox.Show("Posso Gravar esses Dados no Banco?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {

                        Gravar();
                    }
                    else

                        if (txtCodigoClientefrmCliente.Text != "" && (MessageBox.Show("Posso Atualizar esses Dados no Banco?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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

        private void LimpaControles()
        {
            try
            {
                txtCodigoClientefrmCliente.Clear();
                txtNomeClientefrmCliente.Clear();
                txtEnderecofrmCliente.Clear();
                txtNumerofrmCliente.Clear();
                txtComplementofrmCliente.Clear();
                txtBairrofrmCliente.Clear();
                txtCidadefrmCliente.Clear();
                txtEstadofrmCliente.Clear();
                mskTelefonefrmCliente.Clear();
                txtEmailfrmCliente.Clear();
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
                ClienteEntity cli = new ClienteEntity();
                cli.nome = txtNomeClientefrmCliente.Text;
                cli.endereco = txtEnderecofrmCliente.Text;
                cli.numero = Convert.ToInt32(txtNumerofrmCliente.Text);
                cli.complemento = txtComplementofrmCliente.Text;
                cli.bairro = txtBairrofrmCliente.Text;
                cli.cidade = txtCidadefrmCliente.Text;
                cli.estado = txtEstadofrmCliente.Text.ToUpper();
                cli.telefone = mskTelefonefrmCliente.Text;
                cli.email = txtEmailfrmCliente.Text;

                int retorno = 0;
                retorno = ClienteModel.ClienteInsere(cli);
                if (retorno <= 0)
                {
                    MessageBox.Show("Houve um erro ao tentar Gravar um novo cliente ");
                    return;
                }
                else
                {
                    MessageBox.Show("cliente gravado com sucesso ");
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
                ClienteEntity cli = new ClienteEntity();
                cli.id = Convert.ToInt32(txtCodigoClientefrmCliente.Text);
                cli.nome = txtNomeClientefrmCliente.Text;
                cli.endereco = txtEnderecofrmCliente.Text;
                cli.numero = Convert.ToInt32(txtNumerofrmCliente.Text);
                cli.complemento = txtComplementofrmCliente.Text;
                cli.bairro = txtBairrofrmCliente.Text;
                cli.cidade = txtCidadefrmCliente.Text;
                cli.estado = txtEstadofrmCliente.Text.ToUpper();
                cli.telefone = mskTelefonefrmCliente.Text;
                cli.email = txtEmailfrmCliente.Text;

                int retorno = 0;
                retorno = ClienteModel.ClienteAtualiza(cli);
                if (retorno <= 0)
                {
                    MessageBox.Show("Houve um erro ao tentar Atualiza o novo cliente ");
                    return;
                }
                else
                {
                    MessageBox.Show("cliente atualizado com sucesso ");
                    return;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        private bool ValidarControles()
        {
            try
            {
                if (txtNomeClientefrmCliente.Text == "")
                {
                    MessageBox.Show("  Digitar um nome a  ser Gravado");
                    txtNomeClientefrmCliente.Focus();
                    return false; 
                }
                if(txtEnderecofrmCliente.Text == "")
                {
                    MessageBox.Show("Favor Digitar o endereço do Cliente:" + txtNomeClientefrmCliente.Text);
                    txtEnderecofrmCliente.Focus();
                    return false;
                }
                if (txtNumerofrmCliente.Text == "")
                {
                    MessageBox.Show(" Favor Digitar o Numero da Residência do Cliente: " + "-" + txtNomeClientefrmCliente.Text);
                    txtNumerofrmCliente.Focus();
                    return false;
                }
                if(txtComplementofrmCliente.Text == "")
                {
                    MessageBox.Show("Digite um complemento para o Endereço do Cliente : " + " - " + txtNomeClientefrmCliente.Text);
                    txtComplementofrmCliente.Focus();

                    return false;
                }
                if(txtBairrofrmCliente.Text == "")
                {
                    MessageBox.Show("Digite o Bairo do Cliente :"   + " - " + txtNomeClientefrmCliente.Text);
                    txtBairrofrmCliente.Focus();
                    return false;
                }
                if(txtCidadefrmCliente.Text == "")
                {
                    MessageBox.Show("Digite a Cidade do Cliente :" + " - " + txtNomeClientefrmCliente.Text);
                    txtCidadefrmCliente.Focus();
                    return false;
                }

                #region [ Estado ]
                if (txtEstadofrmCliente.Text == "")
                {
                    MessageBox.Show("Informe o Estado");
                    txtEstadofrmCliente.Focus();
                    return false;
                }
                if (txtEstadofrmCliente.Text.Length > 2)
                {
                    MessageBox.Show("Informe apenas a sigla do estado !");
                    txtEstadofrmCliente.Focus();
                    return false;
                }
                bool estadoValido = false;


                switch (txtEstadofrmCliente.Text.ToUpper())
                {
                    case "SP":
                        estadoValido = true;
                        break;
                   case "RJ":
                        estadoValido = true;
                        break;
                   case "PR":
                        estadoValido = true;
                        break;
                   case "PE":
                        estadoValido = true;
                        break;
                   case "Go":
                        estadoValido = true;
                        break;
                   case "RR":
                        estadoValido = true;
                        break;
                   case "PA":
                        estadoValido = true;
                        break;
                   case "AM":
                        estadoValido = true;
                        break;
                   case "MG":
                        estadoValido = true;
                        break;
                   case "ES":
                        estadoValido = true;
                        break;
                   case "AC":
                        estadoValido = true;
                        break;
                   case "RO":
                        estadoValido = true;
                        break;
                   case "DF":
                        estadoValido = true;
                        break;
                   case "PI":
                        estadoValido = true;
                        break;
                   case "CE":
                        estadoValido = true;
                        break;
                   case "SC":
                        estadoValido = true;
                        break;
                   case "BA":
                        estadoValido = true;
                        break;
                   case "SE":
                        estadoValido = true;
                        break;
                   case "AL":
                        estadoValido = true;
                        break;
                   case "MT":
                        estadoValido = true;
                        break;
                   case "MS":
                        estadoValido = true;
                        break;
                   case "PB":
                        estadoValido = true;
                        break;
                   case "RN":
                        estadoValido = true;
                        break;
                   case "TO":
                        estadoValido = true;
                        break;
                   case "MA":
                        estadoValido = true;
                        break;
                   case "RS":
                        estadoValido = true;
                        break;
                   case "AP":
                        estadoValido = true;
                        break;

                    default:
                        estadoValido = false;
                        break;
                }
                if (estadoValido == false)
                {
                    MessageBox.Show("Sigla do estado inválida !");
                    txtEstadofrmCliente.Focus();
                    return false;
                }
                #endregion

                string telefone = mskTelefonefrmCliente.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim();
                if (telefone == "")
                {
                    MessageBox.Show("Digite o Telefone do Cliente :" + " - " + txtNomeClientefrmCliente.Text);
                    mskTelefonefrmCliente.Focus();
                    return false;                    
                }
                if(txtEmailfrmCliente.Text == "")
                {
                    MessageBox.Show("Digite o Email do Cliente :" + " - " + txtNomeClientefrmCliente.Text);
                    txtEmailfrmCliente.Focus();
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
                List<ClienteEntity> clienteLista = new List<ClienteEntity>();
                clienteLista = ClienteModel.ClienteBuscaTodos();
                dgvfrmCliente.DataSource = clienteLista; 
            }
            catch (Exception ex) 
            {                
                throw ex;
            }
        }     
    }
}
