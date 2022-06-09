using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DupCel.Entity;


namespace DupCel.Model
{
   public class VendaModel
    {

       public static VendaEntity VendaBuscaCodigo(int Id)
       {
           try
           {
               VendaEntity venda = new VendaEntity();

               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcVendaBuscaPorId";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@Id", Id));

               SqlDataReader dr = cmm.ExecuteReader();
               if (dr.Read())
               {
                   venda.id = dr.GetInt32(0);
                   venda.valor = dr.GetDecimal(1);
                   venda.data = dr.GetDateTime(2);
                   venda.ativo = dr.GetBoolean(3);

               }
               else
               {
                   venda = null;
               }

               return venda;
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

       public static List<VendaEntity> VendaBuscaTodos()
       {
          

           try
           {
               List<VendaEntity> vendaLista = new List<VendaEntity>();
               SqlCommand cmm = new SqlCommand();
               cmm.CommandText = "ProcVendaBuscaTodos";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Connection = DadosModel.ConectaBanco();
               SqlDataReader dataReader = cmm.ExecuteReader();


               DataTable dt = new DataTable();
               dt.Load(dataReader);

               foreach (DataRow dr in dt.Rows)
               {
                   VendaEntity venda = new VendaEntity();

                   venda.id = GetInt(dr["Id"]);
                   venda.valor = GetDecimal(dr["Valor"]);
                   venda.data =Convert.ToDateTime(GetDate(dr["Data"]));
                   venda.ativo = GetBool(dr["Ativo"]);

                   vendaLista.Add(venda);
               }

               if (vendaLista.Count < 1)
                   vendaLista = null;

               return vendaLista;

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

       public static int VendaAtualiza(VendaEntity venda)
       {
           try
           {

               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcVendaAtualizaPorId";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@Id", venda.id));
               cmm.Parameters.Add(new SqlParameter("@Valor", venda.valor));
               cmm.Parameters.Add(new SqlParameter("@Data", venda.data));
               cmm.Parameters.Add(new SqlParameter("@Ativo", venda.ativo));



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

       public static int VendaInsere(VendaEntity venda)
       {
           try
           {

               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcVendaInsere";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@IdCliente", venda.idCliente));
               cmm.Parameters.Add(new SqlParameter("@Valor", venda.valor));
               cmm.Parameters.Add(new SqlParameter("@Data", venda.data));
               cmm.Parameters.Add(new SqlParameter("@Ativo", venda.ativo));

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
