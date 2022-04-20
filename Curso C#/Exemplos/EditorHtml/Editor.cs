using System;
using System.Text;
namespace EditorHtml
{
    public static class Editor
    {
        public static void Show(){
            Console.BackgroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            StartEdit();

        }
        public static void StartEdit(){
            var file = new StringBuilder();
            do{
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            }while(Console.ReadKey().Key != ConsoleKey.Escape);
            Viewer.Show(file.ToString());



        }
    }
}