using DesignPatternAlura._04_Decorator.DesafioIKCV_ICPP;

namespace DesignPatternAlura._03_Template
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<string> listaOrcamento = new List<string>();

            foreach (Item item in orcamento.Itens)
            {
                if (listaOrcamento.Contains(item.Nome))
                    return true;
                else
                    listaOrcamento.Add(item.Nome);
            }
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
