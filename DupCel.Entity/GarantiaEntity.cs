using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DupCel.Entity
{
    public class GarantiaEntity
    {
        private int Id;
        private DateTime TempoProduto;
        private DateTime TempoServico;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public DateTime tempoproduto
        {
            get { return TempoProduto; }
            set { TempoProduto = value; }
        }
        public DateTime temposervico
        {
            get { return TempoServico; }
            set { TempoServico = value; }
        }
        
    }
}
