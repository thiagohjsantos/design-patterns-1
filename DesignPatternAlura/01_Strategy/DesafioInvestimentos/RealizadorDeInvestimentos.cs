using DesignPatternAlura;
using DesignPatternAlura.Strategy.DesafioInvestimentos;

namespace StrategyPattern
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(Conta conta, IInvestimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Deposita(resultado * 0.75);

            Console.WriteLine("Saldo pós investimento: " + conta.Saldo);
        }
    }
}
