using System;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        int a = 0, b = 1;

        for (int i = 1; i <= N; i++)
        {
            if (i == 1)
                Console.Write(a);
            else if (i == 2)
                Console.Write(" " + b);
            else
            {
                int c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
        }

        Console.WriteLine();
    }
}
