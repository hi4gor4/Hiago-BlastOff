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
                    GenerateVector();
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
        static void GenerateVector()
        {
            Console.Clear();
            Console.WriteLine("Para prosseguir insira o tamanho do vetor");
            var tamanho = Solicitor.GetValidUint();
            if(tamanho==0)
            {
                Console.WriteLine("Não é possivel criar um vetor de 0 possições");
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                GenerateVector();
            }else{
                StrutureVector sv = new StrutureVector(tamanho);
                for(int i =0; i< tamanho; i++){
                    Console.WriteLine($"Insira o valor para a posição {i}");
                    sv.AddValue(Solicitor.GetValidFloat());
                }
                MenuVetor(sv);
            }
        }
        static void MenuVetor(StrutureVector sv)
        {
            Console.Clear();
            Console.WriteLine("1- Para consultar a parte inteira de um valor");
            Console.WriteLine("2- Para multiplicar o vetor por um inteiro");
            Console.WriteLine("3- Para voltar ao menu");
            Console.WriteLine("4- Para consultar um valor");
            Console.WriteLine("5- Para sair");
            byte option = Solicitor.GetByteInterval(1,5);
            switch(option)
            {
                case 1:
                    GetInt(sv);
                    break;
                case 2:
                    MultiplyBy(sv);
                    break;
                case 3:
                    Menu();
                    break;
                case 4:
                    GetValue(sv);
                    break;
                case 5:
                    Console.Clear();
                    Environment.Exit(0);
                    break;

            }
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
            MenuVetor(sv);
        }
        static void MultiplyBy(StrutureVector sv)
        {
            Console.WriteLine("Insira o valor pelo qual quer multiplicar");
            int value = Solicitor.GetValidInt();
            sv.Multiply(value);
        }
        static void GetInt(StrutureVector sv)
        {
            Console.WriteLine("Insira o valor que  quer consultar");
            uint value = Solicitor.GetValidUint();
            if(value < sv.SizeVector)
            {
                Console.WriteLine(sv.IntValue(value));
            } else
            {
                Console.WriteLine("Impossivel consultar essa posição");
            }
        }
        static void GetValue(StrutureVector sv)
        {
            Console.WriteLine("Insira o valor que  quer consultar");
            uint value = Solicitor.GetValidUint();
            if(value < sv.SizeVector)
            {
                Console.WriteLine(sv.Vector[value]);
            } else
            {
                Console.WriteLine("Impossivel consultar essa posição");
            }
        }
    }
}