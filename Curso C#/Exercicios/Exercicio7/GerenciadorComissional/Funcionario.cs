using System;

namespace GerenciadorComissional
{
    internal class Funcionario
    {
        private double comissao;
        private string nome;
        public Funcionario(string nome, double comissao){
            this.nome = nome;
            this.comissao = comissao;
        }
        public string GetNome(){
            return this.nome;
        }

        public double GetComissao(){
            return this.comissao;
        }

        public override string ToString()
        {
            return $"{this.nome}: {this.comissao}";
        }
    }
}