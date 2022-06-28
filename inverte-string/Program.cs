using static System.Console;

public class Program
{
    public static void Main()
    {
        WriteLine("Escreva a string que deseja inverter");
        string inverte = ReadLine();
        int tamanho = inverte.Length;
        char[] invertida = new char[tamanho];

        if (inverte != null)
        {
            for (int i = 0; i < tamanho; i++)
            {
                invertida[invertida.Length - i - 1] = inverte[i];
            }
        }

        foreach (var item in invertida)
        {
            Write(item.ToString());
        }
    }
}
