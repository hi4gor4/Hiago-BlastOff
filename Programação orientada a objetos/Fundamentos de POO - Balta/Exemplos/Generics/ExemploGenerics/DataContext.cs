namespace MyApp
{
    public class DataContext<P>// <> permite a implementação de uma classe ao model ogenerico // pode receber mais que um genrics 
    where P : Person// diz que P só pode ser um Person
    {
        public void Save(P entity){//quando recebendo uma entidade valida com a declaração pode ser usado
            Console.WriteLine("Salvo com sucesso");
        }

    }
}