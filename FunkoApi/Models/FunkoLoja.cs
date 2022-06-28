namespace FunkoApi.Models
{
    public class FunkoLoja
    {
        public Funko ?Funko { get; set; }
        public int idFunko { get; set; }
        public Loja ?Loja { get; set; }
        public int idLoja { get; set; }
        public int Id { get; set; }
        public int Quantidade { get; set; }
    }
}