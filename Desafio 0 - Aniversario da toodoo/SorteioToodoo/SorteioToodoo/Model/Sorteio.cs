using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteiaFuncionario.Model
{
    public class Sorteio
    {

        public Sorteio(string nome)
        {
            Nome = nome;
            Participantes = new List<string>();
            Sorteados = new List<string>();
            Data = DateTime.Now;
        }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public List<string> Sorteados { get; set; }     
        public List<string> Participantes { get; set; }


        public void AddFuncionario(string func)=> Participantes.Add(func);
        public void AddSorteado(string sorteado) => Sorteados.Add(sorteado);
        public string Sortear()
        {
            Random random = new Random();
            int sorteado = random.Next(0, Participantes.Count);
            if(Sorteados.Count() < Participantes.Count() && Participantes.Count()>0){
                string funcSorteado = Participantes[sorteado];
                foreach(string jaSorteado in Sorteados)
                {   
                    if(funcSorteado == jaSorteado)
                        return Sortear();
                }
                Sorteados.Add(funcSorteado);
                return funcSorteado;
            }
            throw new Exception("Impossivel sortear um nome");
        }
    }
}
