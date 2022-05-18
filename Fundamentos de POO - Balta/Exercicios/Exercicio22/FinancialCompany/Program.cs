using FinancialCompanyEntities;
using UserSolicitor;
using System.Runtime.InteropServices;


namespace ProgramApp
{
    public class Program{
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            Menu(emp);

        }
        static void Menu(List<Employee> list)
        {
            Console.Clear();
            Console.WriteLine("Lista de funcionarios");
            Console.WriteLine($"Funcionarios cadastrados {list.Count()}");
            Console.WriteLine("0- Para sair");
            Console.WriteLine("1- Cadastrar gerente");
            Console.WriteLine("2- Cadastrar engenheiro");
            Console.WriteLine("3- Cadastrar empregado");
            byte option = 0;
            if(list.Count()> 0)
            {
                Console.WriteLine("4- Consultar funcionario");
                option = Solicitor.GetByteInterval(0,4);
            }else{
                option = Solicitor.GetByteInterval(0,3);
            }
            switch(option)
            {
                case 0:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                case 1:
                    list.Add(addManager());
                    break;
                case 2:
                    list.Add(addEngineer());
                    break;
                case 3:
                    list.Add(addEmploye());
                    break;
                case 4:
                    MenuCadastrado(list);
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
            Menu(list);

            
        }

        static void MenuCadastrado(List<Employee> list)
        {
            Console.Clear();
            int count = 0;
            foreach(Employee employee in list){
                Console.WriteLine($"{count} {employee.Name}");
                count ++;
            }
            Console.WriteLine("Escolha um funcionario pelo seu numero para ter mais informações sobre ele");
            int index = Solicitor.GetIntInterval(0, list.Count()-1);
            Employee emp = list[index];         
            byte tp = GetFuncao(ref emp);
            Console.Write($"{emp.Name} de cpf {emp.Cpf} recebe {emp.Salary} funcão ");
            if(tp ==1 || tp == 2)
            {
                if(tp == 1){
                    Console.WriteLine("Engenheiro");
                }else{
                    Console.WriteLine("Gerente");
                }
                Console.WriteLine("0- Para bonificalo");
            }else{
                Console.WriteLine("Empregado");
            }
            Console.WriteLine("1- Para removelo");
            Console.WriteLine("2- Para Sair do sistema");
            byte option = 0;
            if(tp ==1 || tp == 2)
            {
                option = Solicitor.GetByteInterval(0,2);
            }else{
                option = Solicitor.GetByteInterval(1,2);
            }
            switch(option)
            {
                case 0:
                    if(tp==1){
                        var eng = (Engineer) emp;
                        eng.AddBonus();
                    }else{
                        var manager = (Manager) emp;
                        manager.AddBonus();
                    }
                    break;
                case 1:
                    list.Remove(emp);
                    break;
                case 2:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
            Menu(list);
        }

        static Manager addManager()
        {
            Console.Clear();
            Console.WriteLine("Insira o nome do gerente  da empresa");
            string name = Solicitor.GetValidName();
            Console.WriteLine("Insira o cpf do gerente");
            string cpf = Solicitor.GetValidString();//ANCHOR criar função get valid cpf
            Console.WriteLine("Insira o salario no gerente ");
            double salary = Solicitor.GetValidpositiveDouble();
            Console.WriteLine("Insira uma senha: ");
            Console.WriteLine("A senha deve ser um numero em ponto flutuante");
            float specialPassword = Solicitor.GetValidFloat();
            Console.WriteLine("Insira o numero de funcionarios dele");
            int numEmployees = (int) Solicitor.GetValidUint();
            return new Manager(name, cpf, salary, specialPassword, numEmployees);
        }
        static Engineer addEngineer()
        {
            Console.Clear();
            Console.WriteLine("Insira o nome do gerente  da empresa");
            string name = Solicitor.GetValidName();
            Console.WriteLine("Insira o cpf do gerente");
            string cpf = Solicitor.GetValidString();//ANCHOR criar função get valid cpf
            Console.WriteLine("Insira o salario no gerente ");
            double salary = Solicitor.GetValidpositiveDouble();
            Console.WriteLine("Insira seu crea");
            string crea = Solicitor.GetValidString();
            Console.WriteLine("Insira sua categoria");
            string category = Solicitor.GetValidString();
            Console.WriteLine("Insira  seu projeto Atual");
            string currentProject = Solicitor.GetValidString();
            return new Engineer(name, cpf, salary,crea,category, currentProject);
        }
        static Employee addEmploye()
        {
            Console.Clear();
            Console.WriteLine("Insira o nome do funcionario da empresa");
            string name = Solicitor.GetValidName();
            Console.WriteLine("Insira o cpf do funcionario");
            string cpf = Solicitor.GetValidString();//ANCHOR criar função get valid cpf
            Console.WriteLine("Insira o salario no funcionario ");
            double salary = Solicitor.GetValidpositiveDouble();
            return new Employee(name, cpf, salary);
        }

        static byte GetFuncao<T> (ref T x)
        {
            Engineer engineer = new Engineer();
            Manager manager = new Manager();
            if(x.GetType() == engineer.GetType())
            {
                return 1;
            }else if(x.GetType() == manager.GetType()){
                return 2;
            }else{
                return 3;
            }
        }
        
    }
}