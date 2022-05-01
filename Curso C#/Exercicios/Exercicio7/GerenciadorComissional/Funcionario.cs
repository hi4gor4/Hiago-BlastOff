using System;

namespace GerenciadorComissional
{
    internal class Funcionario
    {
        public double Comissao { get; set; }
        private string nome;
        public Funcionario(string nome, double comissao){
            this.nome = nome;
            this.Comissao = comissao;
        }
        public string GetNome(){
            return this.nome;
        }



        public override string ToString()
        {
            return $"{this.nome}: {this.Comissao}";
        }
    }
}