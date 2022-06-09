using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DupCel.Model
{
   public  class DadosModel
    {
       public static SqlConnection ConectaBanco()
       {
          
           try
           {
               SqlConnection cn = new SqlConnection();
            //  cn.ConnectionString = //@"Data Source=MANDIOCA-PC;Initial Catalog=DupCel_new;Integrated Security=True";
            //  @"Data Source=DUPCELL-PC;Initial Catalog=DupCel_new;Integrated Security=True";


               cn.ConnectionString = ConfigurationManager.AppSettings["StringConexao"];

               cn.Open();
               return cn;
           }
           catch (Exception ex)
           {
               throw ex;
           }

       }
       public static SqlConnection FechaBanco()
       {
           SqlConnection cn = new SqlConnection();
         //  cn.ConnectionString =// @"Data Source=MANDIOCA-PC;Initial Catalog=DupCel_new;Integrated Security=True";
        //   @"Data Source=DUPCELL-PC;Initial Catalog=DupCel_new;Integrated Security=True";

           cn.ConnectionString = ConfigurationManager.AppSettings["StringConexao"];
           cn.Close();
           return cn;
       }
    }
}
