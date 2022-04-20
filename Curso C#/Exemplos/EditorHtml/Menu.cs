using System;
namespace EditorHtml{
    public static class Menu
    {
        public static void Show()
        {
            short option = 0;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            DrawScreen(30);
            WriteOptions();
            try{
                option = short.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Opcao invalida tente novamente");
                Console.ReadKey();
                Show();
            }
            HandleMenuOption(option);


        }
        public static void DrawScreen(int colunas)
        {
            DrawStartEndLine(colunas);
            for(int linhas = 0; linhas <=10; linhas++){
                Console.Write("|");
                for(int space = 0; space <=colunas; space++)
                    Console.Write(" ");
                Console.Write("|\n");    
            }   
            DrawStartEndLine(colunas);

        }
        private static void DrawStartEndLine(int colunas){
            Console.Write("+");
            for(int i = 0; i<= colunas; i++)
                Console.Write("-");
            Console.Write("+\n");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor Html");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opcao abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1- Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2- Abrir Arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0-Sair");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção: ");
        }
        public static void HandleMenuOption(short option){
            switch(option){
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Console.WriteLine("View");
                    break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);      
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção invalida, tente novamente");
                    Console.ReadKey();
                    Show();    
                    break;
            }

        }
    }
}