﻿using System;
class program
{
    static void Main()
    {
        string palabra = "Hola"; // Declaramos una cadena de texto.
        int contador = 0; // Inicializamos un contador.
        for (int i = 0; i < palabra.Length; i++)
        {
            contador++; // Incrementamos el contador por cada letra.
        }
        Console.WriteLine($"La palabra tiene {contador} letras.");
    }
}