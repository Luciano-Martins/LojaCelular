namespace DupCel.Entity
{
    public class ClienteEntity
    {
        public ClienteEntity()
        {
        
        }
       private int Id;
       private string Nome;
       private string Endereco;
       private int Numero;
       private string Complemento;
       private string Bairro;
       private string Cidade;
       private string Estado;
       private string Telefone;
       private string Email;


       public int id
       {
           get { return Id; }
           set { Id = value; }
       }
       public string nome
       {
           get {return  Nome; }
           set { Nome = value; }
       }
       public string endereco
       {
           get { return Endereco; }
           set { Endereco = value; }
       }
       public int numero
       {
           get { return Numero; }
           set { Numero = value; }
       }
       public string complemento
       {
           get { return Complemento; }
           set { Complemento = value; }
       }
       public string bairro
       {
           get { return Bairro; }
           set { Bairro = value; }
       }
       public string cidade
       {
           get { return Cidade; }
           set { Cidade = value; }
       }
       public string estado
       {
           get { return Estado; }
           set { Estado = value; }
       }
       public string telefone
       {
           get { return Telefone; }
           set { Telefone = value; }
       }
       public string email
       {
           get { return Email; }
           set { Email = value; }
       }



    }
}
