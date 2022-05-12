using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteiaFuncionario.Model
{
    internal class Sorteio
    {

        public Sorteio(string nome)
        {
            Nome = nome;
            Funcionarios = new List<string>();
            Sorteados = new List<string>();
            Data = DateTime.Now;
        }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public List<string> Sorteados { get; }     
        public List<string> Funcionarios { get; }


        public void AddFuncionario(string func)=> Funcionarios.Add(func);

        private void RemoveFuncionario(int index)=> Funcionarios.Remove(Funcionarios[index]);
        public string Sortear()
        {
            Random random = new Random();
            int sorteado = random.Next(0, Funcionarios.Count);
            string funcSorteado = Funcionarios[sorteado];
            if(Sorteados.Count() < Funcionarios.Count()){
                foreach(string jaSorteado in Sorteados)
                {   
                    if(funcSorteado == jaSorteado)
                        return Sortear();
                }
                RemoveFuncionario(sorteado);
                return funcSorteado;
            }
            throw new Exception("Impossivel sortear um nome");
        }
    }
}
