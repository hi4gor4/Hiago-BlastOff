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
    } 
}