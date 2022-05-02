using System.Text.RegularExpressions;

namespace ValidaNome // Note: actual namespace depends on the project name.
{
    internal class VerificadorNominal
    {
        private Regex reg;
        public VerificadorNominal(){
            reg = new Regex(@"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇ]{2,}$");
        }
        public  bool ValidarNome(string nomeCompleto)
        {
            string[] partNome = nomeCompleto.Split(" ");
            bool verificador = true;
            foreach(string part in partNome){
                if(!reg.IsMatch(part))
                    verificador = false;
            }
            return verificador;
        }
        public string Minusculo(string nome)
        {
            if(this.ValidarNome(nome)){
                return nome.ToLower();
            }else{
                throw  new Exception("O nome inserido é invalido!");
            }
        }

        public string Maiusculo(string nome)
        {
            if(this.ValidarNome(nome)){
                return nome.ToUpper();
            }else{
                throw  new Exception("O nome inserido é invalido!");
            }
        }
        public int ConteNome(string nome)
        {
            if(this.ValidarNome(nome)){
                string str = nome.Trim(' ');
                return str.Length;
            }else{
                throw  new Exception("O nome inserido é invalido!");
            }
        }

        public int ContePrimeiroNome(string nome)
        {
            if(this.ValidarNome(nome)){
                string str = nome.Split(' ').First();
                return str.Length;
            }else{
                throw  new Exception("O nome inserido é invalido!");
            }
        }
    }
}