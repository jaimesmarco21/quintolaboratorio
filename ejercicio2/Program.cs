using System;
class program
{
    static void Main()
    {
        int suma = 0; // Inicializamos una variable para almacenar la suma.
        for (int i = 1; i <= 5; i++) // Iteramos desde 1 hasta 5.
        {
            suma += i; // Suma acumulada: suma = suma + i.
        }
        Console.WriteLine($"La suma es: {suma}");

    }
}
