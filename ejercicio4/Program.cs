using System;
class program
{
    static void Main()
    {
        int numero = 3;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}