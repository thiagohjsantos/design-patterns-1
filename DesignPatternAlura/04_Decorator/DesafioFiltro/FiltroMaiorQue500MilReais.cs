using DesignPatternAlura;
using DesignPatternAlura._04_Decorator.DesafioFiltro;
using System.Collections;

namespace DecoratorPattern.Filtros
{
    public class FiltroMaiorQue500MilReais : Filtro
    {
        public FiltroMaiorQue500MilReais() : base() { }

        public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList contas)
        {
            IList<Conta> listaFiltrada = new List<Conta>();

            foreach (Conta conta in contas)
            {
                if (conta.Saldo > 500000) listaFiltrada.Add(conta);
            }

            foreach (Conta conta in Proximo(contas))
            {
                listaFiltrada.Add(conta);
            }

            return listaFiltrada;
        }
    }
}

