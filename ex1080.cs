using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vet = new int[100]; 
        int maior = 0;
        int posicao = 0;

        for (int i = 0; i < 100; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());
        }

        maior = vet[0];
        posicao = 1; 
        for (int i = 1; i < 100; i++)
        {
            if (vet[i] > maior)
            {
                maior = vet[i];
                posicao = i + 1;
            }
        }

        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}
