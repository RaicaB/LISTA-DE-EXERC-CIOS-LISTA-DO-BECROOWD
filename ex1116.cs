using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); 

        for (int i = 0; i < N; i++)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int X = int.Parse(entrada[0]);
            int Y = int.Parse(entrada[1]);

            if (Y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double resultado = (double)X / Y;
                Console.WriteLine(resultado.ToString("F1"));
            }
        }
    }
}

