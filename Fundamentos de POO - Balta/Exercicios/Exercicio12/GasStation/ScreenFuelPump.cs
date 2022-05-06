using FuelStation;

namespace GasStation
{
    public class ScreenFuelPump
    {
        public static void Show(FuelPump pump)
        {
            Console.Clear();
            DrawScreen(60);
            Console.SetCursorPosition(3,2);
            Console.WriteLine($"{pump.FuelType}");
            Console.SetCursorPosition(3,3);
            Console.WriteLine($"Valor por litro: {pump.ValueLiter}");
            Console.SetCursorPosition(3,4);
            Console.WriteLine($"Reservatorio {pump.Tank} litros");
            Console.SetCursorPosition(3,12);

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
    }
}