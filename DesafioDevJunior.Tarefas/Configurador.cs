namespace DesafioDevJunior
{
    public class Configurador
    {

        public int[] SubstituirElemento(int[] arrayOriginal, int elemParaSubstituir, int elemSubstituto)
        {
            int[] arrayModificada = new int[arrayOriginal.Length];
            Array.Copy(arrayOriginal, 0, arrayModificada, 0, arrayOriginal.Length);
            for (int i = 0; i < arrayOriginal.Length; i++)
            {
                if (arrayOriginal[i] == elemParaSubstituir)
                {
                    arrayModificada[i] = elemSubstituto; // efetuar substituição;
                }
            }

            return arrayModificada;
        }

        public int[] RemoverElemento(int[] arrayOriginal, int elemParaRemover)
        {
            int indexParaRemover = Array.IndexOf(arrayOriginal, elemParaRemover);

            if (indexParaRemover != -1)
            {
                int[] arrayModificada = new int[arrayOriginal.Length - 1];

                Array.Copy(arrayOriginal, 0, arrayModificada, 0, indexParaRemover); // seção anterior da array;
                Array.Copy(arrayOriginal, indexParaRemover + 1, arrayModificada, indexParaRemover, arrayOriginal.Length - indexParaRemover - 1); // seção posterior;

                return arrayModificada;
            }

            return arrayOriginal;
        }

        public int[] ConfigurarArray(int[] array, int elemParaSubstituir, int elemSubstituto, int elemParaRemover)
        {

            int[] result = SubstituirElemento(array, elemParaSubstituir, elemSubstituto);
            result = RemoverElemento(result, elemParaRemover);

            return result;
        }
    }
}
