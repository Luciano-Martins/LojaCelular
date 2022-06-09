using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using DupCel.Entity;

namespace DupCel.Model
{
    public  class UsuarioModel
    {
        public  int InserirUsuario(string usuario, string senha)
        {
            try
            {
                    SqlCommand cmm = new SqlCommand();
                    cmm.Connection = DadosModel.ConectaBanco();
                    cmm.CommandText = "uspUsuarioSenhaInserir";
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.Parameters.Add(new SqlParameter("@Usuario", usuario));
                    cmm.Parameters.Add(new SqlParameter("@Senha", senha));
                    int retornaAtualizacao = 0;
                    
                    SqlDataReader dr = cmm.ExecuteReader();
                    if (dr.Read())
                    {
                      retornaAtualizacao = dr.GetInt32(0);
                    }

                    return retornaAtualizacao;     
            }
            catch (Exception ex)
            {
                throw ex;
            }
           finally 
           {   
               DadosModel.FechaBanco();          
           }
        }

        public   UsuarioEntity ConsultaPorNome(string nome ,string senha)
        {
            try
            {
                UsuarioEntity usuario = new UsuarioEntity();
                SqlCommand cmm = new SqlCommand();
                cmm.CommandText = "uspUsuarioConsulta";
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Connection = DadosModel.ConectaBanco();
                cmm.Parameters.Add(new SqlParameter("@Usuario", nome ));
                cmm.Parameters.Add(new SqlParameter("@Senha", senha));

                SqlDataReader sqlDataReder = cmm.ExecuteReader();
             
                

                if (sqlDataReder.Read())
                {
                    usuario.Codigo = sqlDataReder.GetInt32(0);
                    usuario.Usuario = sqlDataReder.GetString(1);
                    usuario.Senha = sqlDataReder.GetString(2);
                }
                else 
                {
                    usuario = null;
                }
                return usuario;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DadosModel.FechaBanco();
            }
 
        }
        
    }
}
