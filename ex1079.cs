using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o número de casos de teste:");
        if (!int.TryParse(Console.ReadLine(), out int quantidadeCasos)) return;

        for (int caso = 1; caso <= quantidadeCasos; caso++)
        {
            Console.WriteLine($"Digite os três valores reais do caso {caso}:");

            string[] partes;
            do
            {
                string entrada = Console.ReadLine();
                partes = entrada?.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
                if (partes == null || partes.Length < 3)
                    Console.WriteLine("Entrada inválida. Forneça três números separados por espaços.");
            } while (partes == null || partes.Length < 3);

            bool ok0 = TryParseAnyCulture(partes[0], out double valor1);
            bool ok1 = TryParseAnyCulture(partes[1], out double valor2);
            bool ok2 = TryParseAnyCulture(partes[2], out double valor3);

            if (!ok0 || !ok1 || !ok2)
            {
                Console.WriteLine("Um dos valores não é numérico. Repita o caso.");
                caso--; 
                continue;
            }

            double resultado = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10.0;
            Console.WriteLine($"Resultado do caso {caso}: {resultado:F1}");
        }

        Console.WriteLine("Todos os casos foram processados.");
    }

    static bool TryParseAnyCulture(string s, out double value)
    {
        if (double.TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands,
                            CultureInfo.InvariantCulture, out value)) return true;
        return double.TryParse(s, NumberStyles.Float | NumberStyles.AllowThousands,
                               CultureInfo.CurrentCulture, out value);
    }
}
