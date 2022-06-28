namespace FunkoApi.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        public string  ?Url { get; set; }
        public Funko ?Funko { get; set; }
        public int IdFunko { get; set; }
    }
}