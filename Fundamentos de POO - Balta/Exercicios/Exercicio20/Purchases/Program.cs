using System.Runtime.InteropServices;
using PurchasesEntities;
using UserSolicitor;
namespace AppView
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1- Pessoa Fisica ");
            Console.WriteLine("2- Estudante");
            Console.WriteLine("3-Sair");
            byte option = Solicitor.GetByteInterval(1,3);
            switch(option)
            {
                case 1:
                    List<Purchase> purchases = new List<Purchase>();
                    MenuCompra(purchases);       
                    break;
                case 2: 
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            } 
        }
        static void MenuCompraEstudante(List<Student> purchases)
        {
            Console.Clear();
            Console.WriteLine("Lista de compras");
            Console.WriteLine($"Compras cadastradas {purchases.Count()}");
            Console.WriteLine("0- Para sair");
            Console.WriteLine("1- Cadastrar uma compra nova");
            byte option = 0;
            if(purchases.Count()>0)
            {
                Console.WriteLine("2- Consultar uma  compra");
                option = Solicitor.GetByteInterval(0,2);
            }else{
                option = Solicitor.GetByteInterval(0,1);
            }
            switch(option)
            {
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case 1:
                    purchases.Add(CadastrarCompraEstudante());
                    break;
                case 2:
                    ContaEstudanteOptions(purchases);
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para proceguir");
            Console.ReadKey();
            MenuCompraEstudante(purchases);
        }
        static void MenuCompra(List<Purchase> purchases)
        {
            Console.Clear();
            Console.WriteLine("Lista de compras");
            Console.WriteLine($"Compras cadastradas {purchases.Count()}");
            Console.WriteLine("0- Para sair");
            Console.WriteLine("1- Cadastrar uma compra nova");
            byte option = 0;
            if(purchases.Count()>0)
            {
                Console.WriteLine("2- Consultar uma  compra");
                option = Solicitor.GetByteInterval(0,2);
            }else{
                option = Solicitor.GetByteInterval(0,1);
            }
            switch(option)
            {
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case 1:
                    purchases.Add(CadastrarCompra());
                    break;
                case 2:
                    ContaOptions(purchases);
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para proceguir");
            Console.ReadKey();
            MenuCompra(purchases);
        }
        static Purchase CadastrarCompra()
        {
            Console.WriteLine("Insira o preço da compra");
            double price = Solicitor.GetValidpositiveDouble();//ANCHOR limitar acima de 0
            Console.WriteLine("Insira o numero de parcelas");
            short installment = (short)Solicitor.GetValidUint();//ANCHOR limitar acima de 0
            Console.WriteLine("Insira o tipo da compra");
            string type = Solicitor.GetValidName();
            return new Purchase(price, installment, type);
        }
        static Student CadastrarCompraEstudante()
        {
            Console.WriteLine("Insira o preço da compra");
            double price = Solicitor.GetValidpositiveDouble();//ANCHOR limitar acima de 0
            Console.WriteLine("Insira o numero de parcelas");
            short installment = (short)Solicitor.GetValidUint();//ANCHOR limitar acima de 0
            Console.WriteLine("Insira o tipo da compra");
            string type = Solicitor.GetValidName();
            return new Student(price, installment, type);
        }

        static void ContaOptions(List<Purchase> purchases)
        {
            int count = 0;
            foreach(Purchase purchase in purchases)
            {
                Console.WriteLine($"{count}: {purchase}");
            }
            Console.WriteLine("Escolha uma compra pelo seu numero");
            int selectPurchaseindex = Solicitor.GetIntInterval(0, purchases.Count()-1);
            var selectPurchase = purchases[selectPurchaseindex];
            Console.WriteLine("0- Sair para o Menu");
            Console.WriteLine("1- Remover Compra");
            Console.WriteLine("2- Renegociar Compra");
            Console.WriteLine("3- Quitar compra");
            Console.WriteLine("4- Metodo especial");
            int option= 0;
            if(purchases[selectPurchaseindex].Installment>0){
                Console.WriteLine("5- Pagar Parcelas");
                option = Solicitor.GetIntInterval(0, 5);
            }else{
                option = Solicitor.GetIntInterval(0,4);
            }

            switch(option){
                case 1:
                    purchases.Remove(selectPurchase);
                    break;
                case 2:
                    Console.WriteLine("Insira a taxa de juros");
                    double interetRate = Solicitor.GetValidpositiveDouble();
                    Console.WriteLine("Insira o novo numero de parcelas");
                    short numberInstallments = (short)Solicitor.GetValidInt();
                    selectPurchase.UpdateInstallment(interetRate,numberInstallments);
                    break;
                case 3:
                    selectPurchase.removePurchase();
                    break;
                case 4:   
                    SpecialMetod(ref selectPurchase, selectPurchase);
                    break;
                case 5:
                    Console.WriteLine("Insira o numero de parcelas que serão pagas");
                    Console.WriteLine($"No maximo {selectPurchase.Installment}");
                    short  value = Solicitor.GetShortInterval(0, selectPurchase.Installment);
                    Console.WriteLine($"{value} parcelas pagas");
                    selectPurchase.PayInstallment(value);
                    break;
            }
        }
        static void ContaEstudanteOptions(List<Student> purchases)
        {
            int count = 0;
            foreach(Purchase purchase in purchases)
            {
                Console.WriteLine($"{count}: {purchase}");
            }
            Console.WriteLine("Escolha uma compra pelo seu numero");
            int selectPurchaseindex = Solicitor.GetIntInterval(0, purchases.Count()-1);
            var selectPurchase = purchases[selectPurchaseindex];
            Console.WriteLine("0- Sair para o Menu");
            Console.WriteLine("1- Remover Compra");
            Console.WriteLine("2- Renegociar Compra");
            Console.WriteLine("3- Quitar compra");
            Console.WriteLine("4- Especial Metodo");
            int option= 0;
            if(purchases[selectPurchaseindex].Installment>0){
                Console.WriteLine("5- Pagar Parcela");
                option = Solicitor.GetIntInterval(0, 5);
            }else{
                option = Solicitor.GetIntInterval(0,4);
            }

            switch(option){
                case 1:
                    purchases.Remove(selectPurchase);
                    break;
                case 2:
                    Console.WriteLine("Insira a taxa de juros");
                    double interetRate = Solicitor.GetValidpositiveDouble();
                    Console.WriteLine("Insira o novo numero de parcelas");
                    short numberInstallments = (short)Solicitor.GetValidInt();
                    selectPurchase.UpdateInstallment(interetRate,numberInstallments);
                    break;
                case 3:
                    selectPurchase.removePurchase();
                    break;
                case 4:
                    SpecialMetod(ref selectPurchase, selectPurchase);
                    break;
                case 5:
                    Console.WriteLine($"Parcela pagas");
                    selectPurchase.PayInstallment();
                    break;
            }
        }
        static void SpecialMetod<T>(ref T x, Purchase pur)
        {
            var Student = new Student();
            if(x.GetType()== Student.GetType())
            {
                var std = (Student) pur;
                Console.WriteLine($"{std.Installment/2} {std.Price/2}");
            }else{
                Console.WriteLine($"{pur.Installment +pur.Price/2}");
            }
            
        }
    }
}