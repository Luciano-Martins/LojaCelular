using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using DupCel.Entity;


namespace DupCel.Model
{
   public  class GarantiaModel
    {

       public static GarantiaEntity GarantiaBuscaCodigo(int Id)
       {
           try
           {
               GarantiaEntity garantia = new GarantiaEntity();


               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcGarantiaBuscaPorId";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@Id", Id));

               SqlDataReader dr = cmm.ExecuteReader();
               if (dr.Read())
               {
                   garantia.id = dr.GetInt32(0);
                   garantia.tempoproduto = dr.GetDateTime(1);
                   garantia.temposervico = dr.GetDateTime(2);
                   
                   
               }
               else
               {
                   garantia = null;
               }

               
               return garantia;
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

       public static List<GarantiaEntity> GarantiaBuscaTodos()
       {
       try
           {
               List<GarantiaEntity> garantiaLista = new List<GarantiaEntity>();
               SqlCommand cmm = new SqlCommand();
               cmm.CommandText = "ProcGarantiaBuscaTodos";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Connection = DadosModel.ConectaBanco();
               SqlDataReader dataReader = cmm.ExecuteReader();


               DataTable dt = new DataTable();
               dt.Load(dataReader);

               foreach (DataRow dr in dt.Rows)
               {
                   GarantiaEntity garantia = new GarantiaEntity();

                   garantia.id = GetInt(dr["Id"]);
                   garantia.tempoproduto = Convert.ToDateTime(dr["TempoProduto"]);
                   garantia.temposervico = Convert.ToDateTime(dr["TempoServico"]);
                   garantiaLista.Add(garantia);
               }

               if (garantiaLista.Count < 1)
                   garantiaLista = null;

               return garantiaLista;

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

       public static int GarantiaAtualiza(GarantiaEntity garantiaEntity)
       {
           GarantiaEntity garantia = new GarantiaEntity();
           try
           {
               
               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcGarantiaAtualizaPorId";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@Id", garantia.id));
               cmm.Parameters.Add(new SqlParameter("@TempoProduto", garantia.tempoproduto));
               cmm.Parameters.Add(new SqlParameter("@TempoServico", garantia.temposervico));
            

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

       public static int GarantiaInsere(GarantiaEntity garantiaEntity)
       {
           try
           {
               GarantiaEntity garantia = new GarantiaEntity();

               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcGarantiaInsere";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@TempoProduto", garantia.tempoproduto));
               cmm.Parameters.Add(new SqlParameter("@TempoServico", garantia.temposervico));
           

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
