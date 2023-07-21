using DesignPatternAlura;
using DesignPatternAlura.Strategy.DesafioInvestimentos;

namespace Strategy.TipoInvestimento
{
    public class Moderado : IInvestimento
    {
        private Random _random;

        public Moderado()
        {
            _random = new Random();
        }

        public double Calcula(Conta conta)
        {
            if (_random.Next(2) == 0) return conta.Saldo * 0.025;
            else return conta.Saldo * 0.007;
        }
    }
}
