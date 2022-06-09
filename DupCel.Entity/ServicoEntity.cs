using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DupCel.Entity
{
    public class ServicoEntity
    {
        public ServicoEntity()
        {
            Garantia = new GarantiaEntity();
        }


        private int Id;
        private string Descricao;
        private string Observacao;
        private decimal Valor;
        

        public int id
        {
            get { return Id; }
            set { Id = value; }

        }
        public string descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }
        public string observacao
        {
            get { return Observacao; }
            set {Observacao = value;}
        }
        public GarantiaEntity Garantia
        {
            get;
            set;
        }
        public decimal valor
        {
            get { return Valor; }
            set { Valor = value; }
        }
    }
}
