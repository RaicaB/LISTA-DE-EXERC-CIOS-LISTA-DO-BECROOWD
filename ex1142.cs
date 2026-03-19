using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int numero = 1;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(numero + " " + (numero + 1) + " " + (numero + 2) + " PUM");
            numero += 4; 
        }
    }
}
