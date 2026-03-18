using System; 

class URI 

{ 

    static void Main(string[] args) 

    { 

         

        int N = int.Parse(Console.ReadLine()); 

        int[] vet = new int[N]; 

        for (int i = 0; i < N; i++) 

        { 

            vet[i] = int.Parse(Console.ReadLine()); 

        } 

  

  

        for (int i = 0; i < N; i++) 

        { 

  

  

            if (vet[i] == 0) 

            { 

                Console.WriteLine("NULL"); 

            } 

            else 

            { 

                if (vet[i] % 2 == 0 && vet[i] > 0) 

                { 

                    Console.WriteLine("EVEN POSITIVE"); 

                } 

                else if (vet[i] % 2 == 0 && vet[i] < 0) 

                { 

                    Console.WriteLine("EVEN NEGATIVE"); 

                } 

                else if (vet[i] % 2 != 0 && vet[i] > 0) 

                { 

                    Console.WriteLine("ODD POSITIVE"); 

                } 

                else 

                { 

                    Console.WriteLine("ODD NEGATIVE"); 

                } 

            } 

        } 

    } 

} 
