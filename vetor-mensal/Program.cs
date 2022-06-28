using static System.Console;
using Newtonsoft.Json;
public class Dia
{
    public int dia { get; set; }
    public double valor { get; set; }
}

public class Program
{
    public static void Main()
    {
        Dia[] mes = new Dia[30];
        double maior = 0, menor = 0, media = 0;
        int diasUteis = 0;
        int i = 0;

        using (StreamReader r = new StreamReader("valoresMes.json"))
        {
            string json = r.ReadToEnd();
            mes = JsonConvert.DeserializeObject<Dia[]>(json);
        }
        
        while (mes[i].valor == 0)
        {
            i++;
        }
        menor = mes[i].valor;

        foreach (Dia dia in mes)
        {
            if (dia.valor != 0)
            {
                diasUteis++;
                media += dia.valor;
                if (dia.valor > maior)
                    maior = dia.valor;
                if (dia.valor < menor)
                    menor = dia.valor;
            }
        }

        WriteLine("O maior valor foi: " + maior);
        WriteLine("O menor valor foi: " + menor);
        WriteLine("A média foi: " + (media/diasUteis));
    }
}