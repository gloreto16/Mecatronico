namespace Mecatronico
{
    public class Parafuso:Peca
    {
        public Parafuso(string material, string tipo, double tamanho, int quantidade)
        {
            this.Material = material;
            this.Tipo = tipo;
            this.Tamanho = tamanho;
            this.Quantidade = quantidade;
        }
        public override void calculo()
        {
            throw new System.NotImplementedException();
        }
        public override void mensagem()
        {
            throw new System.NotImplementedException();
        }
    }
}