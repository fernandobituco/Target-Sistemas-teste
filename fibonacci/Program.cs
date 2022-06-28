using static System.Console;

namespace Target_sistemas_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEscolhido;
            int fibonacci = 1;

            WriteLine("Digite o número desejado");
            numeroEscolhido = Convert.ToInt32(ReadLine());
            while (true)
            {
                if (fibonacci == numeroEscolhido)
                {
                    System.Console.WriteLine("O número escolhido pertence à sequência de fibonacci");
                    break;
                }
                else if (fibonacci > numeroEscolhido)
                {
                    WriteLine("O número escolhido não pertence à sequência de fibonacci");
                    break;
                }
                else
                    fibonacci += fibonacci;
            }
        }
    }
}