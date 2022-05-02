using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Settings.API_URL = "ww.dadqf.com";// informação que é estatica em toda a aplicação
        }
    }
}