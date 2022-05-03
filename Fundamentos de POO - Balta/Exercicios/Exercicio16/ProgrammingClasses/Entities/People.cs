namespace ProgrammingClassEntities
{
    public class People
    {
        public People(string name, string telephone, int age, double height)
        {
            Name = name;
            Telephone = telephone;
            Age = age;
            Height = height;
        }

        public string Name { get; set; }
        public string Telephone { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        
        public void PrintMessage()
        {
            Console.WriteLine($"Bom dia {Name}");
        }

    }
}