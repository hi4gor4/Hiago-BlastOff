namespace FunkoApi.Models
{
    public class Loja
    {
        public int Id { get; set; }
        public string  ?Nome { get; set; }
        public string ?Localizacao { get; set; }

        public IList<FunkoLoja> FunkoLojas { get; set; }

    }
}