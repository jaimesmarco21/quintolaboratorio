﻿using System;
class program
{
    static void Main()
    {
        Console.Write("Ingrese un número del 1 al 7 para el día de la semana: ");
        int dia = int.Parse(Console.ReadLine());
        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Número no válido.");
                break;
        }
    }
}
