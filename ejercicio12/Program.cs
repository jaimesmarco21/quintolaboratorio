using System;
class program
{
    static void Main()
    {
        int suma = 0; // Variable para almacenar la suma.
        int numero;
        Console.Write("Ingrese un número (0 para terminar): ");
        numero = int.Parse(Console.ReadLine()); // Convertimos el texto
        ingresado a número.
        while (numero != 0) // El bucle se ejecuta mientras numero no sea 0.
        {
            suma += numero;
            Console.Write("Ingrese otro número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"La suma total es: {suma}");
    }
}
