using System;

class DIO
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        if (N > 5 && N < 2000) //Validando a quantidade de números
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
                }
            }
    }
}
