using System;
class Program
{
    static void Main()
    {
        int filas = 5;
        for (int i = 1; i <= filas; i++)
        {
            for (int j = 1; j <= i; j++) // Bucle anidado que imprime los asteriscos.
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Imprime una nueva línea al final de cada fila.
        }
    }
}