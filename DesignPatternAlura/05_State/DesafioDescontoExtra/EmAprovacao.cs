namespace DesignPatternAlura._05_State.DesafioDescontoExtra
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        private bool descontoFoiAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoFoiAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                descontoFoiAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
        }
    }
}
