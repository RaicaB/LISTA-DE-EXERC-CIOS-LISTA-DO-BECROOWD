using System;
class URI
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                string parity = (x % 2 == 0) ? "EVEN" : "ODD";
                string sign = (x > 0) ? "POSITIVE" : "NEGATIVE";

                Console.WriteLine($"{parity} {sign}");
            }
        }
    }
}
