using System;

namespace tp5___2021_rubenguzman48Ejercicio3
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
            int Pot;


            do
            {
                Console.WriteLine("Seleccione la opcion: ");
                Console.WriteLine("1- Opcion 1");
                Console.WriteLine("2- Opcion 2");

                seleccion = Convert.ToInt32(Console.ReadLine());



                switch (seleccion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El valor absoluto es: " + Math.Abs(num1));
                        Console.WriteLine("La cuadrado es: " + Math.Pow(num1, 2));
                        Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(num1));
                        Console.WriteLine("El seno del numero es: " + Math.Sin(num1 * Math.PI / 180));
                        Console.WriteLine("El coseno del numero es: " + Math.Cos(num1 * Math.PI / 180));
                        Console.WriteLine("La parte entera del numero es: " + Math.Truncate(num1));

                        break;

                    case 2:
                        Console.WriteLine("Ingrese el primer numero");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        if(num1 > num2)
                        {
                            Console.WriteLine("El mayor es: " + num1);
                            Console.WriteLine("El menor  es: " + num2);
                        }
                        else
                        {
                            Console.WriteLine("El mayor es: " + num2);
                            Console.WriteLine("El menor  es: " + num1);
                        }
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
