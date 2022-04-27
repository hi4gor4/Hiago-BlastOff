using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pag = new Pagamento();
            pag.Dispose();//dispose manual
            using(var pag2 = new Pagamento()){
                //O bloco de using permite o auto dispose em classes que implementam o IDisposable
            }
        }
    }
}