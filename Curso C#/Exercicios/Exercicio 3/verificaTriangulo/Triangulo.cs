
namespace VerificaTriangulo
{
    public class Triangulo
    {
        private int retaA;
        private int retaB;
        private int retaC;

        public Triangulo(int retaA, int retaB, int retaC){
            this.retaA = retaA;
            this.retaB = retaB;
            this.retaC = retaC;

        }

        public bool verificaTipo(){
            if(Math.Abs(retaB-retaC)<retaA && retaA< retaB+retaC){
                return true;
            }else if(Math.Abs(retaA-retaC)<retaB && retaB< retaA+retaC){
                return true;
            }else if(Math.Abs(retaA- retaB)<retaC && retaC < retaA+retaB){
                return true;
            }
            return false;
        }

    }
}
