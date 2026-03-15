using System;

class URI
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro entre 1 e 1000:");
        int x = int.Parse(Console.ReadLine());

        if (x < 1 || x > 1000)
        {
            Console.WriteLine("Valor inválido!Digite um número entre 1 e 1000.");
        }
        else
        {

            Console.Write("Os números ímpares são:");
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}




