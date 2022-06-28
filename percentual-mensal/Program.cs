using static System.Console;
public class Estado
{
    public Estado(string? uf, double valor)
    {
        this.uf = uf;
        this.valor = valor;
    }

    public string? uf { get; set; }
    public double valor { get; set; }
}

public class Program
{
    public static void Main()
    {
        double total = 0;
        List<Estado> estados = new List<Estado>();
        estados.Add(new Estado("SP", 67836.43));
        estados.Add(new Estado("RJ", 36678.66));
        estados.Add(new Estado("MG", 29229.88));
        estados.Add(new Estado("ES", 27165.48));
        estados.Add(new Estado("OU", 19849.53));

        foreach (var item in estados)
        {
            total += item.valor;
        }

        foreach (var item in estados)
        {
            WriteLine($"{item.uf} teve {item.valor*100/total:0.##}% de participação");
        }
    }
}
