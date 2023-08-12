using DesafioDevJunior;

namespace TestesTarefa3
{
    [TestClass]
    public class TestesPesquisador
    {
        [TestMethod]
        public void PesquisarIndexSomaDe2_Sucesso()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int somaAlvo = 9;
            int[] indicesEsperados = { 0, 1 };
            Pesquisador pesquisador = new();

            // Act
            int[] indicesRecebidos = pesquisador.PesquisarIndexSomaDe2Elementos(nums, somaAlvo);

            // Assert
            CollectionAssert.AreEqual(indicesEsperados, indicesRecebidos);

        }

        [TestMethod]
        public void PesquisarIndexSomaDe2_Falha_RetornaDefault()
        {
            // Arrange
            int[] nums = { 2, 7, 11, 15 };
            int somaAlvo = 10;
            int[] indicesEsperados = { -1, -1 };
            Pesquisador pesquisador = new();

            // Act
            int[] indicesRecebidos = pesquisador.PesquisarIndexSomaDe2Elementos(nums, somaAlvo);

            // Assert
            CollectionAssert.AreEqual(indicesEsperados, indicesRecebidos);

        }
    }
}