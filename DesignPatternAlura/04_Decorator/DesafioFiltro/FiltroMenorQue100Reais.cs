using DesignPatternAlura;
using DesignPatternAlura._04_Decorator.DesafioFiltro;
using System.Collections;

namespace DecoratorPattern.Filtros
{
    public class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais() : base() { }

        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList contas)
        {
            IList<Conta> listaFiltrada = new List<Conta>();

            foreach (Conta conta in contas)
            {
                if (conta.Saldo < 100) listaFiltrada.Add(conta);
            }

            foreach (Conta conta in Proximo(contas))
            {
                listaFiltrada.Add(conta);
            }

            return listaFiltrada;
        }
    }
}

