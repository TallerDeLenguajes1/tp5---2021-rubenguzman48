using System;

namespace tp5___2021_rubenguzman48Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            float suma;
            float resta;
            float multi;
            float divi;
            int seleccion;
            int nuevo;


            do
            {
                Console.WriteLine("Seleccione la operacion a realizar 1: Suma - 2: Resta - 3: Multiplicacion - 4: Division");
                Console.WriteLine("1- Suma.");
                Console.WriteLine("2- Resta.");
                Console.WriteLine("3- Multiplicacion.");
                Console.WriteLine("4- Division.");

                seleccion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el primer numero");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());


                switch (seleccion)
                {
                    case 1:
                        suma = num1 + num2;
                        Console.WriteLine("El resultado de la suma es: "+suma);
                        break;
                    case 2:
                        resta = num1 - num2;
                        Console.WriteLine("El resultado de la resta es: "+resta);
                        break;
                    case 3:
                        multi = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicacion es: "+multi);
                        break;
                    case 4:
                        divi = num1 / num2;
                        Console.WriteLine("El resultado de la division es: "+divi);
                        break;
                }

                Console.WriteLine("Desea ralizar otro calculo?");
                Console.WriteLine("1- Si");
                Console.WriteLine("2- No");
                nuevo = Convert.ToInt32(Console.ReadLine());

            } while (nuevo == 1);
        }
    }
}
