using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var meuArray = new int[5]{1,1,1,1,1}; // usando new para valores de referencia
            var arrayb = meuArray;// apenas aponta na memoria o dado do array
            meuArray[0] = 12;//atribuição de valor 
            for(var item = 0; item < meuArray.Length; item++)//iterabdo um vetor
                Console.WriteLine(meuArray[item]);
            Console.WriteLine("Agora vamos ver com foreach");
            foreach(var item in meuArray)//iterando com foreach
                Console.WriteLine(item);
            Console.WriteLine("Referencia array");
            Console.WriteLine(arrayb[0]);
        }
    }
}