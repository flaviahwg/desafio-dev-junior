namespace DesafioDevJunior.Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Desafio Dev. Junior | Flavia Hollerweger \n");

            Tarefa1 tarefa1 = new();
            string resultadoT1 = tarefa1.ExecutarTarefa1();

            if (resultadoT1 != null)
            {
                Console.WriteLine("\n -- Tarefa 01 -- \n");
                Console.WriteLine(resultadoT1);
            }
            else
            {
                Console.WriteLine("Houve um problema ao executar a Tarefa 01");
            }

            Tarefa2 tarefa2 = new();
            string resultadoT2 = tarefa2.PublicarResultado();

            if (resultadoT2 != null)
            {
                Console.WriteLine("\n -- Tarefa 02 -- \n");
                Console.WriteLine(resultadoT2);
            }

            Tarefa3 tarefa3 = new();
            string resultadoT3 = tarefa3.ExecutarTarefa3();

            if (resultadoT3 != null)
            {
                Console.WriteLine("\n -- Tarefa 03 -- \n");
                Console.WriteLine(resultadoT3);
            }
            else
            {
                Console.WriteLine("Houve um problema ao executar a Tarefa 03");
            }
        }
    }
}