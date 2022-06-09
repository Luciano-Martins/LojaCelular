using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using DupCel.Entity;



namespace DupCel.Model
{
       public class VendaProdServModel

         {
              public static int VendaInsere(int idVenda, int idProduto, decimal valorProduto, int idServico,decimal valorServico)
              {
                  try
                  {
                      SqlCommand cmm = new SqlCommand();
                      cmm.Connection = DadosModel.ConectaBanco();
                      cmm.CommandText = "ProcVendaProdServInsere";
                      cmm.CommandType = CommandType.StoredProcedure;
                      cmm.Parameters.Add(new SqlParameter("@IdVenda", idVenda));
                      cmm.Parameters.Add(new SqlParameter("@IdProduto", idProduto));
                      cmm.Parameters.Add(new SqlParameter("@ValorProduto", valorProduto));
                      cmm.Parameters.Add(new SqlParameter("@IdServico", idServico));
                      cmm.Parameters.Add(new SqlParameter("@ValorServico", valorServico));                   

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

              public static VendaProdServEntity ProcVendaServProdPorIdVenda(int idVenda)
              {
                  try
                  {
                      VendaProdServEntity vendaprodserv = new VendaProdServEntity();

                      SqlCommand cmm = new SqlCommand();
                      cmm.Connection = DadosModel.ConectaBanco();
                      cmm.CommandText = "ProcVendaServProdPorIdVenda";
                      cmm.CommandType = CommandType.StoredProcedure;
                      cmm.Parameters.Add(new SqlParameter("@IdVenda", idVenda));

                      SqlDataReader dr = cmm.ExecuteReader();
                      if (dr.Read())
                      {
                          vendaprodserv.id = dr.GetInt32(0);
                          vendaprodserv.Venda.id = dr.GetInt32(1);

                          ProdutoEntity prod = new ProdutoEntity();
                          if (dr[2].ToString() != "")
                          {
                              prod = ProdutoModel.ProdutoBuscaCodigo(dr.GetInt32(2));
                              vendaprodserv.ProdutoList.Add(prod);
                              vendaprodserv.valorproduto = dr.GetDecimal(3);
                          }

                          if (dr[4].ToString() != "")
                          {
                              ServicoEntity serv = new ServicoEntity();
                              serv = ServicoModel.ServicoBuscaCodigo(dr.GetInt32(4));
                              vendaprodserv.ServicoList.Add(serv);
                              vendaprodserv.valorservico = dr.GetDecimal(5);
                          }
                      }
                      else
                      {
                          vendaprodserv = null;
                      }

                      return vendaprodserv;
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

              public static VendaProdServEntity VendaProdServBuscaCodigo(int Id)
              {
                  try
                  {
                      VendaProdServEntity vendaprodserv =  new VendaProdServEntity() ;

                      SqlCommand cmm = new SqlCommand();
                      cmm.Connection = DadosModel.ConectaBanco();
                      cmm.CommandText = "ProcVendaServProdPorId";
                      cmm.CommandType = CommandType.StoredProcedure;
                      cmm.Parameters.Add(new SqlParameter("@Id", Id));

                      SqlDataReader dr = cmm.ExecuteReader();
                      if (dr.Read())
                      {
                          vendaprodserv.id = dr.GetInt32(0);
                          vendaprodserv.Venda.id = dr.GetInt32(1);

                          ProdutoEntity prod = new ProdutoEntity();
                          prod = ProdutoModel.ProdutoBuscaCodigo(dr.GetInt32(2));
                          vendaprodserv.ProdutoList.Add(prod);                        
                          vendaprodserv.valorproduto = dr.GetDecimal(3);

                          ServicoEntity serv = new ServicoEntity();
                          serv = ServicoModel.ServicoBuscaCodigo(dr.GetInt32(4));
                          vendaprodserv.ServicoList.Add(serv);
                          vendaprodserv.valorservico = dr.GetDecimal(5);                          

                      }
                      else
                      {
                          vendaprodserv = null;
                      }

                      return vendaprodserv;
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

              public static List<VendaProdServEntity> VendaServProdBuscaTodos()
              {


                  try
                  {
                      List<VendaProdServEntity> vendaprodservLista = new List<VendaProdServEntity>();
                      SqlCommand cmm = new SqlCommand();
                      cmm.CommandText = "ProcVendaServProdBuscaTodos";
                      cmm.CommandType = CommandType.StoredProcedure;
                      cmm.Connection = DadosModel.ConectaBanco();
                      SqlDataReader dataReader = cmm.ExecuteReader();


                      DataTable dt = new DataTable();
                      dt.Load(dataReader);

                      foreach (DataRow dr in dt.Rows)
                      {
                          VendaProdServEntity vendaservprod = new VendaProdServEntity();

                          vendaservprod.id = Convert.ToInt32(dr["Id"]);
                          vendaservprod.Venda.id = Convert.ToInt32(dr["IdVenda"]);
                          vendaservprod.ProdutoList[0].id = Convert.ToInt32(dr["IdProduto"]);
                          vendaservprod.valorproduto = Convert.ToDecimal(dr["ValorProduto"]);
                          vendaservprod.ServicoList[0].id = Convert.ToInt32(dr["IdServico"]);
                          vendaservprod.valorservico = Convert.ToDecimal(dr["ValorServico"]);

                          vendaprodservLista.Add(vendaservprod);
                      }

                      if (vendaprodservLista.Count < 1)
                          vendaprodservLista = null;

                      return vendaprodservLista;

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
