namespace FunkoApi.Models
{
    public class Funko
    {
        public int Id { get; set; }
        public string  ?Nome { get; set; }
        public DateTime Lancamento { get; set; }
        public string ?Descricao { get; set; }
        public int  Numero { get; set; }
        public Colecao ?Colecao { get; set; }
        public int IdColecao { get; set; }
        public IList<Imagem> ?Imagens  { get; set; }
        public IList<FunkoLoja> ?FunkoLojas { get; set; }

    }
}