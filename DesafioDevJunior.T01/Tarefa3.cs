using System.Text;

namespace DesafioDevJunior
{
    public class Tarefa3
    {
        public string ExecutarTarefa3()
        {
            int[] nums = { 2, 7, 11, 15 };
            int somaAlvo = 9;

            Pesquisador pesquisador = new();
            int[] indices = pesquisador.PesquisarIndexSomaDe2Elementos(nums, somaAlvo);

            if (indices[0] != -1)
            {
                return $"Soma da entrada: {somaAlvo} \n" +
                    $"{somaAlvo} é a soma de {nums[indices[0]]} + {nums[indices[1]]} \n" +
                    $"{nums[indices[0]]} (Index {indices[0]}) e {nums[indices[1]]} (Index {indices[1]}) foram encontrados na array de entrada";
            }

            return "Não foram encontrados resultados para a soma de entrada (alvo)";
        }
    }
}