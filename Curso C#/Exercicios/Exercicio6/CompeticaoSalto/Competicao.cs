/*
namespace CompeticaoSalto
{
    internal class Competicao
    {
        private string nome;
        private List<Saltador> saltadores;

        public Competicao(string nome){
            this.nome = nome;
            this.saltadores = new List<Saltador>();
        }
        public void AdicionaSaltador(string nome, double salto){
            Saltador salt = new Saltador(nome, salto);
            saltadores.Add(salt);
        
        }

    
        public IEnumerable<Saltador> saltadoresOrdenados(){
            IEnumerable <Saltador> listaOrdenada  ;
            try{
                listaOrdenada = saltadores.OrderBy(x => x.GetSalto());
            }catch{
                Console.Write("Não foi possivel criar o podio da competição");
                return null;
            }
            return listaOrdenada;

        }

    }
}
*/