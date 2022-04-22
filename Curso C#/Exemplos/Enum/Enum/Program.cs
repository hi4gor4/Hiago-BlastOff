namespace Enums
{
    public class Program
    {
        struct Product{
            public Product(int id, string name, double price, EProductType type)
            {
                Id = id;
                Name = name;
                Price = price;
                Type = type;
                
            }
            public int Id;
            public string Name;
            public Double Price;
            public EProductType Type;

        }
        static void Main(string[] args){
               // var cliente = new ClientCertificateOption("HIAGO", EEstadoCivil.Solteiro);
               // USA CONVERSOR EXPLICITO PARA MOSTRAR O REAL VALOR DA VARIAVEL
               var mouse = new Product(1,"mouse", 90.0,EProductType.Product);
               Console.WriteLine(mouse.Type);

               
        }
        enum EEstadoCivil
        {
            Solteiro = 1,
            Casado = 2,
            Divorciado = 3
        }
        enum EProductType{
            Product = 1,
            Service = 2
        }

    }
}