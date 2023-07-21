using System.Collections;

namespace DesignPatternAlura._04_Decorator.DesafioFiltro
{
    public abstract class Filtro
    {
        public Filtro() { }

        protected Filtro OutroFiltro { get; private set; }

        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public abstract IList<Conta> Filtra(IList contas);

        protected IList<Conta> Proximo(IList contas)
        {
            if (OutroFiltro != null) return OutroFiltro.Filtra(contas);
            else return new List<Conta>();
        }
    }
}
