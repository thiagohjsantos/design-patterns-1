using DesignPatternAlura;
using DesignPatternAlura.Strategy.DesafioInvestimentos;

namespace Strategy.TipoInvestimento
{
    public class Conservador : IInvestimento
    {
        public double Calcula(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
