
namespace DupCel.Entity
{
   public  class ProdutoEntity
    {
       public ProdutoEntity()
        {
            Garantia = new GarantiaEntity();
        }


       private int Id;
       private string Descricao;
       private string Codigo;
       private string Modelo;
       private string Fabricante;
       private string Cor;
       private string Imen;
       private decimal ValorCompra;
       private decimal ValorComercio;
       private int Quantidade;
       private int EstoqueMinimo;
       private bool Ativo;

       public int id
       {
           get { return Id; }
           set { Id = value;}

       }
       public string descricao
       {
           get { return Descricao; }
           set { Descricao = value; }
       }
       public string codigo
       {
           get { return Codigo; }
           set { Codigo = value; }

       }
       public string modelo
       {
           get { return Modelo; }
           set { Modelo = value; }
       }
       public string fabricante
       {
           get { return Fabricante; }
           set { Fabricante = value; }
       }
       public string cor
       {
           get { return Cor; }
           set { Cor = value; }
       }
       public string imen
       {
           get { return Imen; }
           set { Imen = value; }
       }
       public decimal valorcompra
       {
           get { return ValorCompra; }
           set { ValorCompra = value; }
       }
       public decimal valorcomercio
       {
           get { return ValorComercio; }
           set { ValorComercio = value; }
       }
       public int  quantidade
       {
           get { return Quantidade; }
           set { Quantidade = value; }
       }
       public int estoqueminimo
       {
           get { return EstoqueMinimo; }
           set { EstoqueMinimo = value; }
       }
       public bool ativo
       {
           get { return Ativo; }
           set { Ativo = value; }
       }
       public GarantiaEntity Garantia
       {
           get;
           set;
       }
    }
}
