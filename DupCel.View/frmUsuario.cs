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

namespace DupCel.View
{
    public partial class frmUsuario : Form
    {
        string nome, senha, tipoAcesso;
       
        public frmUsuario()
        {
            InitializeComponent();
        }
      
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregaControles();
        }

        private void btnConfirmarfrmUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                tipoAcesso = cmbTipoAcesso.SelectedItem.ToString();
                int teste = string.Compare(txtSenhafrmUsuario.Text, txtConfirmacaoSenhafrmUsuario.Text);
                nome = txtNomefrmUsuario.Text;
                senha = Convert.ToString(teste);
                Gravar();
               
              
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void CarregaControles()
        {
            cmbTipoAcesso.Items.Add("");
            cmbTipoAcesso.Items.Add("Usuário");
            cmbTipoAcesso.Items.Add("Administrador");

            //cmbTipoAcesso.Items.Add(
        }


        private void Gravar()
        {
            try
            {
            UsuarioEntity Usuario = new UsuarioEntity();

            Usuario.nome = nome;
            Usuario.senha = senha;
            Usuario.admin = tipoAcesso;
          
      
            int retorno = 0;
            retorno = UsuarioModel.UsuarioInsere(Usuario);
            if (retorno <= 0)
            {
                MessageBox.Show("Houve um erro ao tentar Gravar um novo Produto ");
                return;
            }
            else
            {
                MessageBox.Show("Usuario gravado com sucesso ");
                return;
            }
     

            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
    }
}
