using System;
class program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine()); // Convertimos el texto ingresado a número.
        int i = 1; // Inicializamos i en 1.
        while (i <= n) // Mientras i sea menor o igual a n.
        {
            Console.WriteLine(i);
            i++; // Incrementamos i en 1.
        }
    }
}
