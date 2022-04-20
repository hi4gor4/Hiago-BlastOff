using System.Globalization;
using System.Timers;
namespace Myapp{
    class Program{
        static void Main(){
            Console.Clear();
            //var data = new DateTime();// definindo uma nova data atribuida por padrão
            var data2 = DateTime.Now;//pegando a data e hora atuais
            //var data = new DateTime(2022, 04,20);//definindo um data em uma das sobrecargas 
            //Console.WriteLine(data.Year);// ano
            //Console.WriteLine(data.DayOfWeek);//dia da semana
            //Console.WriteLine((int)data.DayOfWeek); //Verificando dia da semana pelo enum 
            //Console.WriteLine(data.DayOfYear);// dia do ano
            //Console.WriteLine(data);
            //Console.WriteLine(data);
            //{Formatando Datas}
            /*
            var formatada = String.Format("{0}",data2);
            Console.WriteLine(formatada);
            Console.WriteLine(String.Format("{0:y} formatacao de ano", data2));// formatando data para um formato desejado para ano Y mes h hora ...
            Console.WriteLine(String.Format("{0: z}", data2));
            */
            //{Padroes de formatacao}
            /*
            Console.WriteLine(String.Format("{0:d}", data2));
            Console.WriteLine(String.Format("{0:T}", data2));
            Console.WriteLine(String.Format("{0:D}", data2));
            Console.WriteLine(String.Format("{0:F}", data2));
            */
            //{Adicionando Valores}
            /*
            Console.WriteLine(data2);
            Console.WriteLine(data2.AddDays(2));
            Console.WriteLine(data2.AddMonths(2));
            Console.WriteLine(data2.AddYears(2000));
            */
            //{Comparando datas}
            /*if(data2.Day == DateTime.Now.Day)
                Console.WriteLine("são o mesmo dia");//comparacao de fato entre os dados
            */
            //{CultureInfo}
            /*
            var pt = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            */
            var timeSpam = new TimeSpan();
            Console.WriteLine(timeSpam);
            var timeSpamNanoSeg = new TimeSpan(1);
            var timeSpamSeg = new TimeSpan(1,1,1);
            Console.WriteLine(timeSpamSeg.Add(new TimeSpan(1,1,1, 1)));
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            

        }

    }
}
