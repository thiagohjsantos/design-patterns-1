namespace DesignPatternAlura.Responsability.DesafioRequisicaoWeb
{
    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }
}
