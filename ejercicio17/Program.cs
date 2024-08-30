using System;
class program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese una operación (+, -, *, /): ");
        char operacion = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (operacion)
        {
            case '+':
                Console.WriteLine($"Resultado: {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"Resultado: {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"Resultado: {num1 * num2}");
                break;
            case '/':
                if (num2 != 0)
                {
                    Console.WriteLine($"Resultado: {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }
}
