namespace ClassLibraryDemo
{
    internal class LivroService
    {
        internal int CalculaExemplares(int numeroDeCaixas, int quantidadeDeLivrosPorCaixa)
        {
            //exemplo
            return numeroDeCaixas * quantidadeDeLivrosPorCaixa;
        }
        private double CalculaPesoDaCaixa(double pesoLivro, int quantidadeDeLivros)
        {
            //exemplo
            return pesoLivro * quantidadeDeLivros;
        }
    }
}
