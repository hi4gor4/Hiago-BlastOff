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
            Menu(space);
            
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
                    AddCelestialBody(space);
                    break;
                case 2: 
                    ConsultCelestialBody(space);
                    break;
                case 3:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Insira qualquer tecla para constinuar");
            Console.ReadKey();
            Menu(space);

        }
        static void AddCelestialBody(OutherSpace space){  
            Console.WriteLine("Insira a massa do corpo celeste");
            Console.WriteLine("Abstraia os valores ");
            double mass = Solicitor.GetValidpositiveDouble();
            Console.WriteLine("Insira a tamanho do corpo celeste");
            Console.WriteLine("Abstraia os valores ");
            double size = Solicitor.GetValidpositiveDouble();
            Console.WriteLine("Insira o tipo do corpo celeste");
            Console.WriteLine("1 Para Asteroid");
            Console.WriteLine("2 Para Planeta");
            Console.WriteLine("3 Para nebulosa");
            Console.WriteLine("Qualquer outro valor representa um Asteroid");
            ECelestialBodyType type = (ECelestialBodyType) Solicitor.GetValidUint();
            space.AddBody(new CelestialBody(type, mass, size));
        }
        static void ConsultCelestialBody(OutherSpace space)
        {
            Console.Clear();
            Console.WriteLine("1- Para consultar Asteroids");
            Console.WriteLine("2- Para consultar Planetas");
            Console.WriteLine("3- Para consultar nebulosas");
            var type= (ECelestialBodyType) Solicitor.GetShortInterval(1,3);
            short occurrence = 0;
            foreach(CelestialBody celestial in space.Celestials)
            {
                if(type == celestial.Type)
                {
                    occurrence +=1;
                    Console.WriteLine($"{occurrence}   {celestial}");

                }
            }

        }
    }
}