using System;
class program
{
    static void Main()
    {
        int[] numeros = { 1, 2, 3, 4, 5 }; // Declaramos un arreglo de enteros
        for (int i = 0; i < numeros.Length; i++) // Iteramos desde 0 hasta la longitud del arreglo.
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
