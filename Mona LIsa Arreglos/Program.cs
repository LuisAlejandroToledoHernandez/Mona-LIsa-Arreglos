using System;

class Program
{
    static void Main()
    {

        string s = "Mona Lisa";

        Console.WriteLine("La cadena original es: " + s);

        int longitud = s.Length;
        Console.WriteLine("Longitud de la cadena es: " + longitud);

        string mayusculas = s.ToUpper();
        Console.WriteLine("la cadena en mayuscula es: " + mayusculas);

        string minusculas = s.ToLower();
        Console.WriteLine("La cadena en minuscula es: " + minusculas);

        char primerCaracter = s[0];
        Console.WriteLine("el caracter de la cadena es: " + primerCaracter);
        
        char reemplazada = s.Replace("mona", "lisa");
        Console.WriteLine("La cadena remplazada es: " + reemplazada);

        Console.ReadLine();
    }
}