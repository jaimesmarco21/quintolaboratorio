using System;
class program
{
    static void Main()
    {
        string texto = "Hola";
        string invertido = "";
        for (int i = texto.Length - 1; i >= 0; i--) // Comenzamos desde elúltimo carácter.
        {
            invertido += texto[i]; // Agregamos cada letra al inicio del texto invertido.
        }
        Console.WriteLine(invertido);
    }
}