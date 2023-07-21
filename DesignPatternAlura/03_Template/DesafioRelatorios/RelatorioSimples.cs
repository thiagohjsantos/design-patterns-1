namespace DesignPatternAlura._03_Template.DesafioRelatorios
{
    public class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco simples");
        }

        protected override void Rodape()
        {
            Console.WriteLine("+55 (11) 1234-5678");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
        }
    }
}
