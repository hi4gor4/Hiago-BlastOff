using UserSolicitor;
using ProgrammingClassEntities;
namespace ProgramStructureds
{
    public class ProgrammingClassEntities
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1- Para cadastrar uma Matrix");
            Console.WriteLine("2- Para cadastrar um vetor");
            Console.WriteLine("3- Para sair");
            short option = Solicitor.GetShortInterval(1,3);
            switch(option)
            {
                case 1:
                    StrutureMatrix st = new StrutureMatrix(3,4);
                    st.Populates();
                    GenerateMatrix(st);
                    break;
                case 2:
                    //ANCHOR Cadastro de vetor
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            }
        }

        static void GenerateMatrix(StrutureMatrix st)
        {
            Console.Clear();
            Console.WriteLine("Oi, criei uma matriz pra você de 3x4");
            Console.WriteLine("Veja só");
            Console.WriteLine("1- Para ver os dados da matriz ");
            Console.WriteLine("2- Para ver o valor maximo");
            Console.WriteLine("3- Para ver o valor Minimo");
            Console.WriteLine("4- Para ver o valor Medio");
            Console.WriteLine("5- Para voltar ao Menu");
            Console.WriteLine("6- Para sair");
            var option = Solicitor.GetByteInterval(1,6);
            switch(option)
            {
                case 1:
                    st.Print();
                    break;
                case 2:
                    Console.WriteLine($"O valor maximo é de : {st.MaxValue()}");
                    break;
                case 3:
                    Console.WriteLine($"O valor minimo é de : {st.MinValue()} ");
                    break;
                case 4:
                    Console.WriteLine($"O valor Minimo é de : {st.Average()}");
                    break;
                case 5:
                    Menu();
                    break;
                case 6:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
            GenerateMatrix(st);
        }
    }

}