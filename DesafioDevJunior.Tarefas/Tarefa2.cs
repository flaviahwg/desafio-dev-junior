namespace DesafioDevJunior
{
    public class Tarefa2
    {
        public string PublicarResultado()
        {
            return " Com base nas informações limitadas fornecidas (\"Total = 100\" e \"Total123 = 15\"), é possível inferir que o resultado \n" +
                " da consulta com CodigoComprador <> 123 seria 85. Isso porque se temos um total de 100 registros e 15 deles são onde \n" +
                " CodigoComprador é igual a 123, os 85 registros restantes devem ser aqueles onde CodigoComprador é diferente \n" +
                " de 123 para que a soma total chegue a 100.\r";
        }
    }
}