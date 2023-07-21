namespace DesignPatternAlura._04_Decorator.DesafioImpostoAlto
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto() : base() { }

        public ImpostoMuitoAlto(Imposto imposto) : base(imposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
