using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DupCel.Entity;

namespace DupCel.Model
{
   public  class ServicoModel
    {
      

       public static ServicoEntity ServicoBuscaCodigo(int Id)
       {
           try
           {
               ServicoEntity servico = new ServicoEntity();
               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcServicoBuscaPorId";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@Id", Id));

               SqlDataReader dr = cmm.ExecuteReader();
               if (dr.Read())
               {
                   servico.id = dr.GetInt32(0);
                   servico.descricao = dr.GetString(1);
                   servico.observacao = dr.GetString(2);

               }
               else
               {
                   servico = null;
               }


               return servico;
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

       public static List<ServicoEntity> ServicoBuscaTodos()
       {
           

           try
           {
               List<ServicoEntity> servicoLista = new List<ServicoEntity>();
               SqlCommand cmm = new SqlCommand();
               cmm.CommandText = "ProcServicoBuscaTodos";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Connection = DadosModel.ConectaBanco();
               SqlDataReader dataReader = cmm.ExecuteReader();


               DataTable dt = new DataTable();
               dt.Load(dataReader);

               foreach (DataRow dr in dt.Rows)
               {
                   ServicoEntity servico = new ServicoEntity();

                   servico.id = GetInt(dr["Id"]);
                   servico.descricao = GetString(dr["Descricao"]);
                   servico.observacao = GetString(dr["Observacao"]);
                 
                   servicoLista.Add(servico);
               }

               if (servicoLista.Count < 1)
                   servicoLista = null;

               return servicoLista;

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

       public static int ServicoAtualiza(ServicoEntity servico)
       {

           try
           {

               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcServicoAtualizaPorId";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@Id", servico.id));
               cmm.Parameters.Add(new SqlParameter("@Descricao", servico.descricao));
               cmm.Parameters.Add(new SqlParameter("@Observacao", servico.observacao));



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

       public static int ServicoInsere(ServicoEntity servico)
       {
           try
           {

               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcServicoInsere";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@Descricao", servico.descricao));
               cmm.Parameters.Add(new SqlParameter("@Observacao", servico.observacao));

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

       public static int ProdutoInsere(ProdutoEntity produto)
       {
           try
           {


               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcProdutoInsere";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@Descricao", produto.descricao));
               cmm.Parameters.Add(new SqlParameter("@Codigo", produto.codigo));
               cmm.Parameters.Add(new SqlParameter("@Modelo", produto.modelo));
               cmm.Parameters.Add(new SqlParameter("@Fabricante", produto.fabricante));
               cmm.Parameters.Add(new SqlParameter("@Cor", produto.cor));
               cmm.Parameters.Add(new SqlParameter("@Imen", produto.imen));
               cmm.Parameters.Add(new SqlParameter("@ValorCompra", produto.valorcompra));
               cmm.Parameters.Add(new SqlParameter("@ValorComercio", produto.valorcomercio));
               cmm.Parameters.Add(new SqlParameter("@Quantidade", produto.quantidade));
               cmm.Parameters.Add(new SqlParameter("@EstoqueMinimo", produto.estoqueminimo));
               cmm.Parameters.Add(new SqlParameter("@Ativo", produto.ativo));


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
