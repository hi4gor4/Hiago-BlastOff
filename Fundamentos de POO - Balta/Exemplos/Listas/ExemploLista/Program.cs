// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();// cria uma nova lista do tipo person que implementa as interface de um enumerable
            persons.Add(new Person("Hiago"));//usa metodos de uma lista // ienumerable tbm funciona de maneira parecida
            persons.Add(new Person("Hiago"));
            persons.Add(new Person("julio"));

            foreach(var pe in persons){
                Console.WriteLine(pe.Nome);
            }
            var pes = persons.Where(x=> x.Nome == "Hiago");
            Console.WriteLine(pes);// retorna um tipo lista com os filtros usados
            var pes2 = persons.First(x=> x.Nome== "Hiago");
            Console.WriteLine(pes2.Nome);
        }
    }
}