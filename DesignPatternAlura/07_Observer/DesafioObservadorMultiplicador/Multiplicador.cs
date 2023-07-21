using DesignPatternAlura._06_Builder;

namespace DesignPatternAlura._07_Observer.DesafioObservadorMultiplicador
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator) { Fator = fator; }

        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorBruto * Fator);
        }

    }
}
