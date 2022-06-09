using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DupCel.Entity
{
    public class VendaProdServEntity
    {
        public VendaProdServEntity()
        {
            Venda = new VendaEntity();
            
            ServicoList = new List<ServicoEntity>();
            ProdutoList = new List<ProdutoEntity>();
            Cliente = new ClienteEntity();
        }

        public VendaEntity Venda { get; set; }
        public List<ServicoEntity> ServicoList { get; set; }      
        public List<ProdutoEntity> ProdutoList { get; set; }
        public ClienteEntity Cliente { get; set; }

        private int Id;
        private decimal ValorProduto;
        private decimal ValorServico;


        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public decimal valorproduto
        {
            get { return ValorProduto; }
            set { ValorProduto = value; }
        }
        public decimal valorservico
        {
            get { return ValorServico; }
            set { ValorServico = value; }
        }

    }
}
