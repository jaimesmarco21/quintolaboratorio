using System;
class program
{
    static void Main()
    {
        int numero = 5;
        int factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i; // Multiplicamos el valor actual de factorial por i.
        }
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
}