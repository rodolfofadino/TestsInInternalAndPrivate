using System;
using System.Reflection;
using ClassLibraryDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTestDemo
{
    [TestClass]
    public class LivroServiceTest
    {
        [TestMethod]
        public void Verifica_Se_2_Caixas_Com_3_Livros_Tem_Um_Total_De_6_Livros()
        {
            const int numeroDeCaixas = 2;
            const int totalEmCadaCaixa = 3;

            var livroService = new LivroService();
            var totalDeLivros = livroService.CalculaExemplares(numeroDeCaixas, totalEmCadaCaixa);

            Assert.AreEqual(6,totalDeLivros);
        }

        [TestMethod]
        public void Verifica_Se_2_Livros_De_200_Gramas_Pesam_400_Gramas()
        {
            const int numeroDeLivros = 2;
            const double pesoDeCadaLivro= 0.2;

            var livroService = new LivroService();
            
            var bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;
            
            MethodInfo mInfoMethod = typeof(LivroService).GetMethod("CalculaPesoDaCaixa", bindingFlags);
            var pesoTotal = (double)mInfoMethod.Invoke(livroService, new object[] { pesoDeCadaLivro, numeroDeLivros });  

            Assert.AreEqual(0.4, pesoTotal);
        }

        [TestMethod]
        public void Verifica_Se_2_Livros_De_300_Gramas_Com_Uma_Caixa_De_100_Gramas_Pesam_700_Gramas()
        {
            const int numeroDeLivros = 2;
            const double pesoDeCadaLivro = 0.3;
            const double pesoDaCaixa = 0.1;

            var livroService = new LivroService();

            var bindingFlags = BindingFlags.Instance | BindingFlags.NonPublic;

            MethodInfo mInfoMethod = typeof(LivroService).GetMethod("CalculaPesoDaCaixaComACaixa", bindingFlags);
            var pesoTotal = (double)mInfoMethod.Invoke(livroService, new object[] { pesoDeCadaLivro, pesoDaCaixa,numeroDeLivros });

            Assert.AreEqual(0.7, pesoTotal);
        }
    }
}
