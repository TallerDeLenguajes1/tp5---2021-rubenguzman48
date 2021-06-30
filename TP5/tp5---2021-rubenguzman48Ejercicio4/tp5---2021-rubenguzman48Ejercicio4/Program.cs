using System;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase\n");
            string frase = Console.ReadLine();

            Console.Write("Una parte de la cadena es : " + frase.Substring(0, 3) + "\n");
            Console.Write("La longitud de la cadena es : " + frase.Length + "\n");
            Console.Write("La cadena en mayuscula es: " + frase.ToUpper() + "\n");
            Console.Write("La cadena en minuscula es: " + frase.ToLower() + "\n");

            Console.WriteLine("Ingrese otra frase\n");
            string f1 = Console.ReadLine();

            Console.WriteLine(" ");

            Console.WriteLine(String.Concat(frase, f1));


            string[] partes = frase.Split(" ");
            foreach (var parte in partes)
            {
                Console.WriteLine($"Partes : {parte}");
            }

            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine().Trim();
            Console.WriteLine($"La palabra {palabra} {(frase.Contains(palabra) ? "esta en la frase" : "no esta en la frase")}");

            Console.WriteLine("\nIngrese una frase : ");
            string frase2 = Console.ReadLine();

            if (frase.CompareTo(frase2) > 0)
            {
                Console.WriteLine("Frase 1 es mas larga \n");
            }
            else
            {
                Console.WriteLine("Frase 2 mas larga\n");
            }

            if (frase == frase2)
            {
                Console.WriteLine("Las frases son iguales");
            }
            else
            {
                Console.WriteLine("Las frases son diferentes");
            }


            string texto = "uno;dos;tres;cuatro";
            char caracter = ';';
            string[] palabras = texto.Split(caracter);

            foreach (var pala in palabras)
            {
                Console.WriteLine($"Partes : {pala}");
            }


        }
    }
}