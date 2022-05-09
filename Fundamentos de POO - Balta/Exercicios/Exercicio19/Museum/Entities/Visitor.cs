namespace Museum.Entities
{
    public class Visitor
    {
        
        public static byte VINTAGE =1;
        public static byte NUMISMATICA = 2;
        public static byte HISTORIA_DA_MUSICA = 3;
        public static byte PINTURA = 4;
        public static byte ESCULTURA = 5;

        public Visitor(string name, string cpf, DateTime birthDate, byte themeCode)
        {
            Name = name;
            Cpf = cpf;
            BirthDate = birthDate;
            ThemeCode = themeCode;
            Themes = new List<byte>();
            Themes.Add(themeCode);
        }

        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public  byte ThemeCode { get; set; }
        public List<byte> Themes { get; set; }

        public static int Attractions(byte  session)
        {
            if(session == VINTAGE){
                return 135;
            }else if(session == NUMISMATICA ){
                return 300;
            }else if(session == HISTORIA_DA_MUSICA){
                return 67;
            }else if(session == PINTURA){
                return 72;
            }else if(session == ESCULTURA){
                return 46;
            }
            throw new IndexOutOfRangeException("Atração desconhecida");
        }
        public void AddTheme(byte themeCode){
            Themes.Add(themeCode);
            ThemeCode = themeCode;
        }
    }
}