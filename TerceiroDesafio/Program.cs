using System;

class DIO
{
    static void Main(string[] args)
    {
        double S = 0, divisao;
        for (int i = 1; i <= 100; i++)
        {
            divisao = 1 / (double)i;
            S += divisao;
        }
        Console.WriteLine(Math.Round(S, 2));
    }
}