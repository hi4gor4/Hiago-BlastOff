namespace FunkoApi.Models
{
    public class Colecao
    {
        public int Id { get; set; }
        public string  ?Nome { get; set; }
        public string  ?Tipo { get; set; }
        public IList<Funko> ?Funkos { get; set; }
    }
}