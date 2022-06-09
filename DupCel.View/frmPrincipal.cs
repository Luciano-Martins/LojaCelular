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

       

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cli = new frmCliente();
            cli.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto prod = new frmProduto();
            prod.ShowDialog();
        }

        private void serviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda vend = new frmVenda();
            vend.ShowDialog();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServico serv = new frmServico();
            serv.ShowDialog();
        }

        private void relatórioVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelacaoVendas relvendas = new frmRelacaoVendas();
            relvendas.ShowDialog();
        }

        private void cadastroUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario USU = new frmCadastroUsuario();
            USU.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            labBemVindo.Text = "Bem vindo !";
        }

       
    }
}
