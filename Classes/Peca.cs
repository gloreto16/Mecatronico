namespace Mecatronico
{
    public abstract class Peca
    {
        protected string Material{get; set;}
        protected string Tipo{get; set;}
        protected double Tamanho{get; set;}
        protected int Quantidade{get;set;}
        public abstract void mensagem();
        public abstract void calculo(); 
    }
}