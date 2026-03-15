using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Digite 2 valores inteiros:");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int soma = 0;

        if (x > y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        for (int i = x + 1; i < y; i++)
        {
            if (i % 2 != 0) 
            {
                soma += i;
            }
        }

        Console.WriteLine(soma);
    }
}
