using DesignPatternAlura._06_Builder;

namespace DesignPatternAlura._07_Observer.DesafioBuilder
{
    public class NotaFiscalBuilderModificada
    {
        private string? RazaoSocial { get; set; }
        private string? Cnpj { get; set; }
        private double ValorBruto { get; set; }
        private double Impostos { get; set; }
        private string? Observacoes { get; set; }
        private DateTime Data { get; set; }

        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas;

        private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        public NotaFiscalBuilderModificada(IList<IAcaoAposGerarNota> lista)
        {
            Data = DateTime.Now;
            todasAcoesASeremExecutadas = lista;
        }

        public NotaFiscalBuilderModificada ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilderModificada ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilderModificada ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilderModificada Com(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilderModificada NaData(DateTime novaData)
        {
            Data = novaData;

            return this;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto,
                                Impostos, TodosItens, Observacoes);

            foreach (IAcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(notaFiscal);
            }
            return notaFiscal;
        }
    }
}
