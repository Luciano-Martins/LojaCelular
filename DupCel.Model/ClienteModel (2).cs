using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DupCel.Entity;
using System.Data.SqlClient;
using System.Data;

namespace DupCel.Model
{
    public  class ClienteModel
    {
        public static  ClienteEntity ClienteBuscaCodigo(int Id)
        {
            try
            {
                ClienteEntity cliente = new ClienteEntity();
                SqlCommand cmm = new SqlCommand();
                cmm.Connection = DadosModel.ConectaBanco();
                cmm.CommandText = "ProcClienteBuscaPorId";
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.Add(new SqlParameter("@Id", Id));

                SqlDataReader dr = cmm.ExecuteReader();

                if (dr.Read())
                {
                    cliente.id = dr.GetInt32(0);
                    cliente.nome = dr.GetString(1);
                    cliente.endereco = dr.GetString(2);
                    cliente.numero = dr.GetInt32(3);
                    cliente.complemento = dr.GetString(4);
                    cliente.bairro = dr.GetString(5);
                    cliente.cidade = dr.GetString(6);
                    cliente.estado = dr.GetString(7);
                    cliente.telefone = dr.GetString(8);
                    cliente.email = dr.GetString(9);
                }
                else
                {
                    cliente = null;
                }

                return cliente;
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

         public static List<ClienteEntity>ClienteBuscaTodos()
             {    
                

               try
                 {
                     List<ClienteEntity> clienteLista = new List<ClienteEntity>();                  
                     SqlCommand cmm = new SqlCommand();
                     cmm.CommandText = "ProcClienteBuscaTodos";
                     cmm.CommandType = CommandType.StoredProcedure;
                     cmm.Connection = DadosModel.ConectaBanco(); 


                     SqlDataReader dataReader = cmm.ExecuteReader();
                        

                    DataTable dt = new DataTable();
                    dt.Load(dataReader);

                    foreach (DataRow dr in dt.Rows)
                    {
                        ClienteEntity cliente = new ClienteEntity();
                        cliente.id = GetInt(dr["Id"]);
                        cliente.nome = GetString(dr["Nome"]);
                        cliente.endereco = GetString(dr["Endereco"]);
                        cliente.numero = GetInt(dr["Numero"]);
                        cliente.complemento = GetString(dr["Complemento"]);
                        cliente.bairro =GetString( dr["Bairro"]);
                        cliente.cidade = GetString(dr["Cidade"]);
                        cliente.estado = GetString(dr["Estado"]);
                        cliente.telefone = GetString(dr["Telefone"]);
                        cliente.email = GetString(dr["Email"]);
                        clienteLista.Add(cliente);
                    }

                if (clienteLista.Count < 1)
                    clienteLista = null;
                  
                  return clienteLista;

                 }
                 catch (Exception ex)
                 {                   
                     throw ex ;
                 }
               finally
               {
                   DadosModel.FechaBanco();
               }
             }

         public static int ClienteAtualiza(ClienteEntity cliente)
             {
                 try
                 {

                     SqlCommand cmm = new SqlCommand();
                     cmm.Connection = DadosModel.ConectaBanco();
                     cmm.CommandText = "ProcClienteAtualizaPorId";
                     cmm.CommandType = CommandType.StoredProcedure;
                     cmm.Parameters.Add(new SqlParameter("@Id", cliente.id));
                     cmm.Parameters.Add(new SqlParameter("@Nome", cliente.nome));
                     cmm.Parameters.Add(new SqlParameter("@Endereco", cliente.endereco));
                     cmm.Parameters.Add(new SqlParameter("@Numero", cliente.numero));
                     cmm.Parameters.Add(new SqlParameter("@Complemento", cliente.complemento));
                     cmm.Parameters.Add(new SqlParameter("@Bairro", cliente.bairro));
                     cmm.Parameters.Add(new SqlParameter("@Cidade", cliente.cidade));
                     cmm.Parameters.Add(new SqlParameter("@Estado", cliente.estado));
                     cmm.Parameters.Add(new SqlParameter("@Telefone", cliente.telefone));
                     cmm.Parameters.Add(new SqlParameter("@Email", cliente.email));


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

         public static int ClienteInsere(ClienteEntity cliente)
         {
             try
             {
                 SqlCommand cmm = new SqlCommand();
                 cmm.Connection = DadosModel.ConectaBanco();
                 cmm.CommandText = "ProcClienteInsere";
                 cmm.CommandType = CommandType.StoredProcedure;
                 cmm.Parameters.Add(new SqlParameter("@Nome", cliente.nome));
                 cmm.Parameters.Add(new SqlParameter("@Endereco", cliente.endereco));
                 cmm.Parameters.Add(new SqlParameter("@Numero", cliente.numero));
                 cmm.Parameters.Add(new SqlParameter("@Complemento", cliente.complemento));
                 cmm.Parameters.Add(new SqlParameter("@Bairro", cliente.bairro));
                 cmm.Parameters.Add(new SqlParameter("@Cidade", cliente.cidade));
                 cmm.Parameters.Add(new SqlParameter("@Estado", cliente.estado));
                 cmm.Parameters.Add(new SqlParameter("@Telefone", cliente.telefone));
                 cmm.Parameters.Add(new SqlParameter("@Email", cliente.email));


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

         public static Guid GetGuid(object value)
         {
             try { return new Guid(ReplaceDbNull(value)); }
             catch { return Guid.Empty; }
         }
         public static string ReplaceDbNull(object value)
         {
             if (value == DBNull.Value)
                 return string.Empty;
             else
                 return value.ToString().Trim();
         }
         public static bool GetBool(object value)
         {
             return ReplaceDbNull(value) == "0" || ReplaceDbNull(value).ToLower() == "false" || ReplaceDbNull(value).ToLower() == string.Empty ? false : true;
         }
         public static decimal GetDecimal(object value)
         {
             return ReplaceDbNull(value) != string.Empty ? Convert.ToDecimal(ReplaceDbNull(value)) : -1;
         }
         public static int GetInt(object value)
         {
             return ReplaceDbNull(value) != string.Empty ? Convert.ToInt32(ReplaceDbNull(value)) : -1;
         }

         public static string GetString(object value)
         {
             return ReplaceDbNull(value);
         }

         public static DateTime? GetDate(object value)
         {
             DateTime d = GetString(value) != string.Empty ? Convert.ToDateTime(value) : DateTime.MinValue;
             if (d == Convert.ToDateTime("1/1/0001 00:00:00"))
                 d = DateTime.MinValue;
             return d;
         }
     }

}

    
        
         


    

