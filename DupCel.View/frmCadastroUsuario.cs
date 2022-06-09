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
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSairCadastro_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            if (txtSenhaCadastro.Text == txtConfSenhaCadastro.Text)
            {
                int codigoRetorno ;
               
                UsuarioModel usuarioModel = new UsuarioModel();
                 string retorno = usuarioModel.InserirUsuario(
                    txtUsuarioCadastro.Text ,txtSenhaCadastro.Text).ToString();

                if (int.TryParse(retorno, out  codigoRetorno) == true)
                {
                    //Conseguiu é Numero
                    txtUsuarioCadastro.Clear();
                    txtSenhaCadastro.Clear();
                    txtConfSenhaCadastro.Clear();
                    MessageBox.Show("Usuário Cadastrado com Sucesso", "Entrando",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //não conseguiu , é texto
                    MessageBox.Show("NÃO FOI POSSIVEL CADASTRAR ," + retorno);
                    txtUsuarioCadastro.Clear();
                    txtSenhaCadastro.Clear();
                    txtConfSenhaCadastro.Clear();

                }

            }
            else
            {
                MessageBox.Show("Senhas não Conferem :", "Saindo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
               // txtUsuario.Clear();
                txtSenhaCadastro.Clear();
                txtConfSenhaCadastro.Clear();
            }
        }

        

        
        
    }
}
