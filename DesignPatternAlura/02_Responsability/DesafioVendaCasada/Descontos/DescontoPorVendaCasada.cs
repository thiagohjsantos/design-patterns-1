namespace DesignPatternAlura.Responsability.DesafioVendaCasada.Descontos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (existeVendaCasadaEm(orcamento))
            {
                return orcamento.Valor * 0.5;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }

        private bool existeVendaCasadaEm(Orcamento orcamento)
        {
            return existe("CANETA", orcamento) && existe("LAPIS", orcamento);
        }

        private bool existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem)) return true;
            }
            return false;
        }
    }
}
