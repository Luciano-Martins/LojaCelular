using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using DupCel.Entity;

namespace DupCel.Model
{
   public  class ProdutoModel
    {
      
       public static List<ProdutoEntity> ProdutoBuscaTodos()
       {
           
          try
           {
               List<ProdutoEntity> produtoLista = new List<ProdutoEntity>();

               SqlCommand cmm = new SqlCommand();
              
               cmm.CommandText = "ProcProdutoBuscaTodos";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Connection = DadosModel.ConectaBanco();
              
               SqlDataReader dataReader = cmm.ExecuteReader();


               DataTable dt = new DataTable();
               dt.Load(dataReader);

               foreach (DataRow dr in dt.Rows)
               {
                   ProdutoEntity produto = new ProdutoEntity();
                   produto.id = GetInt(dr["Id"]);
                   produto.descricao = GetString(dr["Descricao"]);
                   produto.codigo = GetString(dr["Codigo"]);
                   produto.modelo = GetString(dr["Modelo"]);
                   produto.fabricante = GetString(dr["Fabricante"]);
                   produto.cor = GetString(dr["Cor"]);
                   produto.imen = GetString(dr["Imen"]);
                   produto.valorcompra = GetDecimal(dr["ValorCompra"]);
                   produto.valorcomercio = GetDecimal(dr["ValorComercio"]);
                   produto.quantidade = GetInt(dr["Quantidade"]);
                   produto.estoqueminimo = GetInt(dr["EstoqueMinimo"]);
                   produto.ativo= GetBool(dr["Ativo"]);
                   produtoLista.Add(produto);
               }

               if (produtoLista.Count < 1)
                   produtoLista = null;

               return produtoLista;

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
       public static ProdutoEntity ProdutoBuscaCodigo(int Id)
       {
           try
           {
               ProdutoEntity produto = new ProdutoEntity(); 
               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcProdutoBuscaPorId";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@Id", Id));



               SqlDataReader dr = cmm.ExecuteReader();

               if (dr.Read())
               {
                   produto.id = dr.GetInt32(0);
                   produto.descricao = dr.GetString(1);
                   produto.codigo = dr.GetString(2);
                   produto.modelo = dr.GetString(3);
                   produto.fabricante = dr.GetString(4);
                   produto.cor = dr.GetString(5);
                   produto.imen = dr.GetString(6);
                   produto.valorcompra = dr.GetDecimal(7);
                   produto.valorcomercio = dr.GetDecimal(8);
                   produto.quantidade = dr.GetInt32(9);
                   produto.estoqueminimo = dr.GetInt32(10);
                   produto.ativo = dr.GetBoolean(11);
               }
               else
               {
                   produto = null;
               }
             
               return produto;
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
       public static int ProdutoAtualiza(ProdutoEntity produto)
       {
          
           try
           {
               
               SqlCommand cmm = new SqlCommand();
               cmm.Connection = DadosModel.ConectaBanco();
               cmm.CommandText = "ProcProdutoAtualizaPorId";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Parameters.Add(new SqlParameter("@Id", produto.id));
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



       public static List<ProdutoEntity> ProdutoBuscaPorNomes()
       {

           try
           {
               List<ProdutoEntity>ProList = new List<ProdutoEntity>();

               SqlCommand cmm = new SqlCommand();

               cmm.CommandText = "ProcProdutoBuscaPorNome";
               cmm.CommandType = CommandType.StoredProcedure;
               cmm.Connection = DadosModel.ConectaBanco();

               SqlDataReader dataReader = cmm.ExecuteReader();


               DataTable dt = new DataTable();
               dt.Load(dataReader);

               foreach (DataRow dr in dt.Rows)
               {
                   ProdutoEntity produto = new ProdutoEntity();
                   produto.id = GetInt(dr["Id"]);
                   produto.descricao = GetString(dr["Descricao"]);
                   produto.codigo = GetString(dr["Codigo"]);
                   produto.modelo = GetString(dr["Modelo"]);
                   produto.fabricante = GetString(dr["Fabricante"]);
                   produto.cor = GetString(dr["Cor"]);
                   produto.imen = GetString(dr["Imen"]);
                   produto.valorcompra = GetDecimal(dr["ValorCompra"]);
                   produto.valorcomercio = GetDecimal(dr["ValorComercio"]);
                   produto.quantidade = GetInt(dr["Quantidade"]);
                   produto.estoqueminimo = GetInt(dr["EstoqueMinimo"]);
                   produto.ativo = GetBool(dr["Ativo"]);
                   ProList.Add(produto);
               }

               if (ProList.Count < 1)
                   ProList = null;

               return ProList;

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
