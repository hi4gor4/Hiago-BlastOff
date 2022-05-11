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
            Funcionarios = new List<Funcionario>();
            Data = DateTime.Now;
        }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public List<Funcionario> Funcionarios { get; }


        public void AddFuncionario(Funcionario func)=> Funcionarios.Add(func);

        private void RemoveFuncionario(int index)=> Funcionarios.Remove(Funcionarios[index]);
        public Funcionario Sortear()
        {
            Random random = new Random();
            int sorteado = random.Next(0, Funcionarios.Count);
            Funcionario funcSorteado = Funcionarios[sorteado];
            RemoveFuncionario(sorteado);
            return funcSorteado;
        }
    }
}
