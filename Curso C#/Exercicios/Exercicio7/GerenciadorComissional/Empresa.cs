using System;

namespace GerenciadorComissional
{
    internal class Empresa
    {
        private string nome;
        private int[] contadorComissional;
        private List<Funcionario> func; 
        
        public Empresa(string nome)
        {
            this.nome  = nome;
            this.contadorComissional = new int[9];
            this.func = new List<Funcionario>();
        }

        public void AddFuncionario(string nome, double comissao){
            if(comissao < 300){
                this.contadorComissional[0]++;
            }else if(comissao <400){
                this.contadorComissional[1]++;
            }else if(comissao < 500){
                this.contadorComissional[2]++;
            }else if(comissao<600){
                this.contadorComissional[3]++;
            }else if(comissao <700){
                this.contadorComissional[4]++;
            }else if(comissao <800){
                this.contadorComissional[5]++;
            }else if(comissao< 900){
                this.contadorComissional[6]++;
            }else if(comissao<1000){
                this.contadorComissional[7]++;
            }else{
                this.contadorComissional[8]++;
            }
            this.func.Add(new Funcionario(nome, comissao));
        }

        public  void OrdenaFuncionarios(){
            func = func.OrderBy(func => func.Comissao).ToList();
            Console.WriteLine("Printando Funcionarios");
            
        }
        public int verificaFaixa(short num){
            return this.contadorComissional[num-1];
        }

        public  void printFaixa(short num)
        {
            if(verificaFaixa(num) >0){
                Console.WriteLine("São eles:");
                OrdenaFuncionarios();
                int init=0 , fim = 0;
                for(int i = 0; i<num-1; i++ ){
                    init  +=  this.contadorComissional[i];
                }
                fim = init + contadorComissional[num-1];             
                for(int i = init; i < fim; i++)
                    Console.WriteLine(this.func[i].ToString());
            }
        }


    }    
    
}