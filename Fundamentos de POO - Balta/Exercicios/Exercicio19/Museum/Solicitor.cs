namespace UserSolicitor{
    public class Solicitor{
        public static short GetShortInterval(short start, short end ){
            short option = 0;
            try{
                option = short.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Valor invalido tente novamente");
                return GetShortInterval(start, end );
            }
            if(option >= start && option <= end){
                return option;
            }else{
                Console.WriteLine("O valor não corresponde a nenhuma opção, Tente novamente");
                return GetShortInterval(start, end ); 
            }
        }
        public static double GetValidpositiveDouble()
        {
            double value = GetValidDouble();
            if(value>0){
                return value;
            }else{
                Console.WriteLine("Insira um valor positivo, Tente novamente");
                return GetValidpositiveDouble();
            }
        }
        public static double GetValidDouble()
        {
          double value = 0;
            try{
                value = double.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Valor invalido tente novamente");
                return GetValidDouble();
            }  
            return value;

        }
        public static int GetValidInt()
        {
          int value = 0;
            try{
                value = int.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Valor invalido tente novamente");
                return GetValidInt();
            }  
            return value;

        }
    } 

}