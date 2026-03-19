using System;

class Program
{
    static void Main(string[] args)
    {
        string? nLine = Console.ReadLine();
        if (nLine == null)
            return;

        int N = int.Parse(nLine); 

        int total = 0;
        int coelhos = 0;
        int ratos = 0;
        int sapos = 0;

        for (int i = 0; i < N; i++)
        {
            string? line = Console.ReadLine();
            if (line == null)
                continue;

            string[] entrada = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (entrada.Length < 2)
                continue;

            int quantidade = int.Parse(entrada[0]);
            char tipo = entrada[1][0];

            total += quantidade;

            if (tipo == 'C')
                coelhos += quantidade;
            else if (tipo == 'R')
                ratos += quantidade;
            else if (tipo == 'S')
                sapos += quantidade;
        }

        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + coelhos);
        Console.WriteLine("Total de ratos: " + ratos);
        Console.WriteLine("Total de sapos: " + sapos);

        double percCoelhos = total > 0 ? (coelhos * 100.0) / total : 0.0;
        double percRatos = total > 0 ? (ratos * 100.0) / total : 0.0;
        double percSapos = total > 0 ? (sapos * 100.0) / total : 0.0;

        Console.WriteLine("Percentual de coelhos: " + percCoelhos.ToString("F2") + " %");
        Console.WriteLine("Percentual de ratos: " + percRatos.ToString("F2") + " %");
        Console.WriteLine("Percentual de sapos: " + percSapos.ToString("F2") + " %");
    }
}
