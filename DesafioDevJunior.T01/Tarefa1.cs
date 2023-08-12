using System.Text;

namespace DesafioDevJunior
{
    public class Tarefa1
    {
        public string ExecutarTarefa1()
        {
            int[] array = { 7, 5, 3, 9, 6, 4, 1 };
            int elemParaSubstituir = 9;
            int elemSubstituto = 5;
            int elemParaRemover = 4;

            Configurador config = new();
            int[] arrayConfig = config.ConfigurarArray(array, elemParaSubstituir, elemSubstituto, elemParaRemover);

            return ($" Array inicial: {Print(array)} " +
                $"\n Array configurada: {Print(arrayConfig)} " +
                $"\n Soma após a configuração: {arrayConfig.Sum()}");
        }

        public static string Print(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return "[]";
            }

            StringBuilder sb = new();
            sb.Append('[');

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);
                if (i < array.Length - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.Append(']');
            return sb.ToString();
        }
    }
}
