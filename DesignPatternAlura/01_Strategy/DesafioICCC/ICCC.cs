namespace DesignPatternAlura.Strategy.DesafioICCC
{
    public class ICCC : Imposto
    {
        public ICCC() : base() { }

        public ICCC(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
            {
                return 0.05 * orcamento.Valor;
            }
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                return 0.07 * orcamento.Valor;
            }
            else
            {
                return 0.08 * orcamento.Valor + 30.0;
            }
        }
    }
}
