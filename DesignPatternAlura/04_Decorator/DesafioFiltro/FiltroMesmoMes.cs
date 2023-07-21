using DesignPatternAlura;
using DesignPatternAlura._04_Decorator.DesafioFiltro;
using System.Collections;

namespace DecoratorPattern.Filtros
{
    public class FiltroMesmoMes : Filtro
    {
        public FiltroMesmoMes() : base() { }

        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<Conta> Filtra(IList contas)
        {
            IList<Conta> listaFiltrada = new List<Conta>();

            foreach (Conta conta in contas)
            {
                if (conta.DataAbertura.Month == DateTime.Now.Month && conta.DataAbertura.Year == DateTime.Now.Year)
                {
                    listaFiltrada.Add(conta);
                }
            }

            foreach (Conta conta in Proximo(contas))
            {
                listaFiltrada.Add(conta);
            }

            return listaFiltrada;
        }
    }
}

