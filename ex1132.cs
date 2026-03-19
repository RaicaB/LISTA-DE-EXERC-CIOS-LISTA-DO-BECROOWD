using System;

class Program
{
    static void Main(string[] args)
    {
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());

        int menor = Math.Min(X, Y);
        int maior = Math.Max(X, Y);

        int soma = 0;

        for (int i = menor; i <= maior; i++)
        {
            if (i % 13 != 0) 
            {
                soma += i;
            }
        }

        Console.WriteLine(soma);
    }
}

