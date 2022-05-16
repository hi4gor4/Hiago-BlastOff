using OuterSpaceEntities;
using OutherSpaceEnum;
using UserSolicitor;
namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var space = new OutherSpace();
            
        }
        static void Menu(OutherSpace space)
        {
            Console.Clear();

            Console.WriteLine("Bem vindo ao espcaço sideral");
            Console.WriteLine($"Asteroids cadastrados: {space.Count(ECelestialBodyType.Asteroid)} ");
            Console.WriteLine($"Planetas cadastrados : {space.Count(ECelestialBodyType.Planet)}   ");
            Console.WriteLine($"Nebulosas cadastrados: {space.Count(ECelestialBodyType.Nebulae)}");
            Console.WriteLine("1- Para cadastrar um novo corpo celeste");
            Console.WriteLine("2- Para consular informações sobre os corpos cadastrados");
            Console.WriteLine("3- Para Sair");
            byte option = Solicitor.GetByteInterval(1,3);
            switch(option)
            {
                case 1:
                    //ANCHOR fazer função de cadastro
                    break;
                case 2: 
                    //ANCHOR fazer função de consulta
                    break;
                case 3:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }

        }
    }
}