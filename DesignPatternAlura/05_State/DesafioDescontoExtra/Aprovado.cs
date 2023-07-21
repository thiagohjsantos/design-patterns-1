namespace DesignPatternAlura._05_State.DesafioDescontoExtra
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        private bool descontoFoiAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoFoiAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoFoiAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
