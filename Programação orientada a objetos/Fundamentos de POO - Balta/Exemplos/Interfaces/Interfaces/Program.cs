//interface define um conjuto de regras, um contrato que define como algo deve ser implementado
public interface IPagamento// Uma classe não deve usar o mesmo nome de uma interface por padrão é cumun usarmos I como prefixo para interface
{
    //cria propriedades metodos e eventos que uma classe deve ter, entretanto não se deve implementa-los na interface, mesmo que seja possivel.
   int valor { get; set; }
   void Pagar(double valor);
}
//diferente da Herança a interface precisa que obrigatoriamente a classe que voce implemente os itens da interface
public class Pagamento : IPagamento
{
    public int valor { get; set; }// ctrl + . para implementar a interface

    public void Pagar(double valor)
    {
        Console.WriteLine(valor.ToString(), "Foi pago");
    }
}
