using System.Text.RegularExpressions;

namespace ValidaCPF // Note: actual namespace depends on the project name.
{

    internal class Validador
    {
        private Regex verificador ;
        public Validador(){
            this.verificador = new Regex(@"^([0-9])([0-9])([0-9])[\.]([0-9])([0-9])([0-9])[\.]([0-9])([0-9])([0-9])-([0-9])([0-9])$");
        }    
        public bool validaFormato(string cpf){
            return this.verificador.IsMatch(cpf);
        }
        public bool ValidaCPF(string cpf){
            if(verificador.IsMatch(cpf)){
                var encontrada = verificador.Match(cpf); 
                return VerificaDigito(1,encontrada) && VerificaDigito(2,encontrada);
            }else{
                return false;
            }
        }
        private bool VerificaDigito(short num, Match digitos){
            int somatorio = 0;
            int j = 10;
            for(int i = num ; i <=num+8; i++){
                somatorio += int.Parse(digitos.Groups[i].Value)*j;
                j--;
            }
            int resto = somatorio%11;
            int digitoVerificado = 0;
            if(resto != 0 && resto != 1)
                digitoVerificado = 11-resto;

            return digitoVerificado == int.Parse(digitos.Groups[num + 9].Value);
        }
    }
}