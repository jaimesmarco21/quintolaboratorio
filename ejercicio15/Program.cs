using System;
class program
{
    static void Main()
    {
        int contador = 0;
        int numero;
        Console.Write("Ingrese un número (0 para terminar): ");
        numero = int.Parse(Console.ReadLine());
        while (numero != 0)
        {
            if (numero == 5) // Comprobamos si el número ingresado es 5.
            {
                contador++;
            }
            Console.Write("Ingrese otro número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"El número 5 fue ingresado {contador} veces.");
    }
}