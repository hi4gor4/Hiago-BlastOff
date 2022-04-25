using System.Text.RegularExpressions;

namespace ValidaTelefone // Note: actual namespace depends on the project name.
{
    internal class ValidaTelefone
    {
        private Regex capturanum;
        private Regex regexFormatada;
        public ValidaTelefone(){
            capturanum = new Regex(@"^([1-9]{3,4})-?([1-9]{4})$");

        }
        public string[] Valid(string num){
            string[] result = new string[4];    
            result[0] = $"Telefone: {num}";
            if (capturanum.IsMatch(num)){
                var encontrada = capturanum.Match(num); 
                if(encontrada.Groups[1].Value.Length== 3)
                    result[1] = "O Telefone possui 7 digitos vou adicionar o 3 na frente.";
                result[2] = $"Telefone Corrigido sem formatação: {encontrada.Groups[1].Value}{encontrada.Groups[2].Value}";
                result[3] = $"Telefone Corrigido sem formatação: {encontrada.Groups[1].Value}-{encontrada.Groups[2].Value}";
                
            }else if (capturanum.IsMatch(num)){
                var encontrada = capturanum.Match(num); 
                if(encontrada.Groups[1].Value.Length== 3)
                    result[1] = "O Telefone possui 7 digitos vou adicionar o 3 na frente.";
                result[2] = $"Telefone Corrigido sem formatação: 3{encontrada.Groups[1].Value}{encontrada.Groups[2].Value}";
                result[3] = $"Telefone Corrigido sem formatação: 3{encontrada.Groups[1].Value}-{encontrada.Groups[2].Value}";
            }else{
                result[1] = "É um numero invalido";
            }
            return result;

        }

    }
}