using DesignPatternAlura._05_State.DesafioEstadoConta;

namespace DesignPatternAlura
{
    public class Conta
    {
        public double Saldo { get; set; }
        public string? Nome { get; private set; }
        public int Numero { get; private set; }
        public string? Agencia { get; private set; }
        public DateTime DataAbertura { get; private set; }

        public IEstadoDaConta Estado;

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
            Estado.Deposita(this, valor);
        }
    }
}
