namespace Modulo2
{
    public class Retangulo : FormaGeometrica
    {
        public double Largura { get; set; }
        public double Altura { get; set; }
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }
        public override double CalcularArea()
        {
            return Largura * Altura;
        }
    }
}
