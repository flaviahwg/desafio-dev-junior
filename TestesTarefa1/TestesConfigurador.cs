using DesafioDevJunior;

namespace TestesTarefa1
{
    [TestClass]
    public class TestesConfigurador
    {
        int elemParaSubstituir = 9;
        int elemSubstituto = 5;
        int elemParaRemover = 4;

        [TestMethod]
        public void SubstituirElemento9_Existente_SubstituicaoSucede()
        {
            //Arrange
            int[] arrayInicial = { 7, 5, 3, 9, 6, 4, 1 };
            int[] arrayEsperada = { 7, 5, 3, 5, 6, 4, 1 };
            Configurador configurador = new();

            //Act
            int[] arrayRecebida = configurador.SubstituirElemento(arrayInicial, elemParaSubstituir, elemSubstituto);

            //Assert
            CollectionAssert.AreEqual(arrayEsperada, arrayRecebida);

        }

        [TestMethod]
        public void SubstituirElemento9_Existente_SubstituicaoFalha()
        {
            //Arrange
            int[] arrayInicial = { 7, 5, 3, 9, 6, 4, 1 };
            int[] arrayEsperada = { 7, 5, 3, 10, 6, 4, 1 };
            Configurador configurador = new();

            //Act
            int[] arrayRecebida = configurador.SubstituirElemento(arrayInicial, elemParaSubstituir, elemSubstituto);

            //Assert
            CollectionAssert.AreNotEqual(arrayEsperada, arrayRecebida);

        }

        [TestMethod]
        public void SubstituirElemento9_NaoExistente_RetornaArrayInicial()
        {
            //Arrange
            int[] arrayInicial = { 7, 5, 3, 2, 6, 4, 1 };
            int[] arrayEsperada = { 7, 5, 3, 2, 6, 4, 1 };
            Configurador configurador = new();

            //Act
            int[] arrayRecebida = configurador.SubstituirElemento(arrayInicial, elemParaSubstituir, elemSubstituto);

            //Assert
            CollectionAssert.AreEqual(arrayEsperada, arrayRecebida);

        }

        [TestMethod]
        public void RemoverElemento4_Existente_RemocaoSucede()
        {
            //Arrange
            int[] arrayInicial = { 7, 5, 3, 2, 6, 4, 1 };
            int[] arrayEsperada = { 7, 5, 3, 2, 6, 1 };
            Configurador configurador = new();

            //Act
            int[] arrayRecebida = configurador.RemoverElemento(arrayInicial, elemParaRemover);

            //Assert
            Assert.AreEqual(arrayEsperada.Length, arrayRecebida.Length);
            CollectionAssert.AreEqual(arrayEsperada, arrayRecebida);

        }


        [TestMethod]
        public void RemoverElemento4_NaoExistente_RetornaArrayInicial()
        {
            //Arrange
            int[] arrayInicial = { 7, 5, 3, 2, 6, 9, 1 };
            int[] arrayEsperada = { 7, 5, 3, 2, 6, 9, 1 };
            Configurador configurador = new();

            //Act
            int[] arrayRecebida = configurador.RemoverElemento(arrayInicial, elemParaRemover);

            //Assert
            Assert.AreEqual(arrayEsperada.Length, arrayRecebida.Length);
            CollectionAssert.AreEqual(arrayEsperada, arrayRecebida);

        }
    }
}