using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            int quadrado = i * i;
            int cubo = i * i * i;

            Console.WriteLine(i + " " + quadrado + " " + cubo);
        }
    }
}

