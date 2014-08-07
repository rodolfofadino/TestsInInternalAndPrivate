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

        protected double CalculaPesoDaCaixaComACaixa(double pesoLivro,double pesoCaixa, int quantidadeDeLivros)
        {
            //exemplo
            return (pesoLivro * quantidadeDeLivros)+pesoCaixa;
        }
    }
}
