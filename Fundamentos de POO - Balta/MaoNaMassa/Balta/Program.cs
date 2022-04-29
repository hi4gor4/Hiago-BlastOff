using System;
using Balta.ContentContext;
using SubscriptionContext;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre .NET", "orientacao-objetos"));

            // Console.Clear();
            // foreach(var artticle in articles){
            //     Console.WriteLine(artticle.Title);
            // }
            var course = new List<Course>();

            course.Add(new Course("Artigo sobre OOP", "orientacao-objetos"));
            course.Add(new Course("Artigo sobre C#", "orientacao-objetos"));
            course.Add(new Course("Artigo sobre .NET", "orientacao-objetos"));
            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .Net", "especialista-dotnet");
            var careerItem = new CareerItem(1,"Comece por aqui", "", course[0]);
            var careerItem2 = new CareerItem(2,"Em seguida", "", course[1]);

            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem2);
            careers.Add(careerDotNet);
            foreach(var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderBy(x => x.Order)){
                    Console.WriteLine($"{item.Title} {item.Order}");
                }
                 var payPalSubscription = new Subscription();
                var student = new Student();

            }
        }
    }
}
