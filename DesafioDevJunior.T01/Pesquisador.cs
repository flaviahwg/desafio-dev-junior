namespace DesafioDevJunior
{
    public class Pesquisador
    {

        public int[] PesquisarIndexSomaDe2Elementos(int[] array, int somaAlvo)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == somaAlvo)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { -1, -1 }; // Se nenhuma solução foi encontrada;
        }
    }
}
