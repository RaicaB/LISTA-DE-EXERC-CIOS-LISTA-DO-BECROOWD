using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 9; i += 2)
        {
            int j = 7;
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                j += 2;
            }
        }
    }
}
