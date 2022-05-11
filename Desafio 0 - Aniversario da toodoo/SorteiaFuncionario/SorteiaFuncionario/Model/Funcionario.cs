using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteiaFuncionario.Model
{
    internal class Funcionario
    {
        public Funcionario(string nome, int id)
        {
            Id = id;
            Nome = nome;
        }
        public int Id { get; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{Nome}  {Id}";
        }

    }
}
