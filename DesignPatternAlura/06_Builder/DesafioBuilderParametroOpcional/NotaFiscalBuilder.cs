using DesignPatternAlura._07_Observer;

namespace DesignPatternAlura._06_Builder.DesafioBuilderParametroOpcional
{
    public class NotaFiscalBuilder
    {
        private string RazaoSocial { get; set; }
        private string Cnpj { get; set; }
        private double ValorBruto { get; set; }
        private double Impostos { get; set; }
        private string Observacoes { get; set; }
        private DateTime Data { get; set; }

        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas;

        private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder()
        {
            Data = DateTime.Now;
            todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            TodosItens.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            Data = novaData;

            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto,
                                Impostos, TodosItens, Observacoes);
        }
    }
}
