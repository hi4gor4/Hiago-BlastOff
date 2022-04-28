namespace MyApp
{
    public class DataContext<T>// <> permite a implementação de uma classe ao model ogenerico
    {
        public void Save(T entity){//quando recebendo uma entidade valida com a declaração pode ser usado
            Console.WriteLine("Salvo com sucesso");
        }

    }
}