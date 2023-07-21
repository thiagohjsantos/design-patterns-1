using DesignPatternAlura._05_State;
using DesignPatternAlura._05_State.DesafioDescontoExtra;

namespace DesignPatternAlura
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }

        public Orcamento()
        {
            EstadoAtual = new EmAprovacao();
        }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
