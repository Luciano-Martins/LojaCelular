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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrarfrmLogin_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioModel = new UsuarioModel();
            UsuarioEntity usuarioEntity = new UsuarioEntity();
            usuarioEntity = usuarioModel.ConsultaPorNome(txtUsuario.Text, txtSenha.Text);
            if (usuarioEntity != null)
            {
                txtUsuario.Clear();
                txtSenha.Clear();
                MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
            }
            else 
            {
                MessageBox.Show("Usuario ou Senha incorretos Verifique !!!", "Erro !");
                txtUsuario.Clear();
                txtSenha.Clear();
            }


           
    
        }

        private void btnCadastrarLogin_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frmcadUsu = new frmCadastroUsuario();
            frmcadUsu.Show();
        }

        private void btnSairLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
