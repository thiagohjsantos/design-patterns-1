namespace DesignPatternAlura.Responsability.DesafioVendaCasada.Descontos
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }

    }
}
