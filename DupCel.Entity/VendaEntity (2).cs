using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DupCel.Entity
{

    public class VendaEntity
    {
       private int Id;
       private int IdCliente;
       private decimal Valor;
       private DateTime Data;
       private bool Ativo;


       public int id
       {
           get { return Id; }
           set { Id = value; }
       }
       public int idCliente
       {
           get { return IdCliente; }
           set { IdCliente = value; }
       }
       public decimal valor
       {
           get { return Valor; }
           set { Valor = value; }
       }
       public DateTime data
       {
           get { return Data; }
           set { Data = value; }
       }
       public bool ativo
       {
           get { return Ativo; }
           set { Ativo = value; }
       }
    }
}
