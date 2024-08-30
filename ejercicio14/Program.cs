using System;
class program
{
    static void Main()
    {
        int mayor = int.MinValue; // Inicializamos con el valor más bajo
        posible de un entero.
        int numero;
        Console.Write("Ingrese un número (0 para terminar): ");
        numero = int.Parse(Console.ReadLine());
        while (numero != 0)
        {
            if (numero > mayor) // Comparamos el número ingresado con elmayor actual.
            {
                mayor = numero; // Actualizamos el mayor si el númeroingresado es más grande.
            }
            Console.Write("Ingrese otro número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"El número mayor es: {mayor}");
    }
}
