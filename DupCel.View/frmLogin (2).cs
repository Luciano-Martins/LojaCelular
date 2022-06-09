using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DupCel.Model;

namespace DupCel.View
{
    public partial class frmLogin : Form
    {
        
        public bool logado = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        public void Logar()
        {

            string nome, senha;
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = DadosModel.ConectaBanco();
            cmm.CommandText = "SELECT COUNT (IdUsuario) From TabLogin where Nome = @Nome AND Senha = @Senha";
            cmm.CommandType = CommandType.Text;
            try
            {
                nome = txtUsuariofrmLogin.Text;
                senha = txtSenhafrmLogin.Text;

                cmm.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nome;
                cmm.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;


                int v = (int)cmm.ExecuteScalar();
                if (v > 0)
                {

                    logado = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Nome ou Senha está Errado!");
                    txtUsuariofrmLogin.Clear();
                    txtSenhafrmLogin.Clear();
                    txtUsuariofrmLogin.Focus();

                    logado = false;
                }

            }
            catch (SqlException error)
            {

                MessageBox.Show(error + "erro no banco");
            }
            DadosModel.FechaBanco();

        }

        private void btnEntrarfrmLogin_Click(object sender, EventArgs e)
        {
            Logar();  
        }

        private void btnCancelarfrmLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
