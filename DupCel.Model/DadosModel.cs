using System;
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
               cn.ConnectionString = @"Data Source=LAPTOP-J8IGC1CM;Initial Catalog=DupCel_new;Integrated Security=True";          
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
           cn.ConnectionString = @"Data Source=LAPTOP-J8IGC1CM;Initial Catalog=DupCel_new;Integrated Security=True";
           cn.Close();

           return cn;
       }
    }
}
