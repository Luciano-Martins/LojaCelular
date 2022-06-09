using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DupCel.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnVendasfrmPrincipal_Click(object sender, EventArgs e)
        {
            frmVenda frv = new frmVenda();
            frv.ShowDialog();
        }

        private void btnProdutofrmPrincipal_Click(object sender, EventArgs e)
        {
            frmProduto frP = new frmProduto();
            frP.ShowDialog();
        }

        private void btnServicofrmPrincipal_Click(object sender, EventArgs e)
        {
            frmServico frS = new frmServico();
            frS.ShowDialog();
        }

        private void btnClientefrmPrincipal_Click(object sender, EventArgs e)
        {
            frmCliente frC = new frmCliente();
            frC.ShowDialog();
            return;
        }

        private void btnRelacoesVendasfrmPrincipal_Click(object sender, EventArgs e)
        {
            frmRelacaoVendas frmv = new frmRelacaoVendas();
            frmv.ShowDialog();
            
        }
  
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginfrmPrincipal_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

       
    }
}
