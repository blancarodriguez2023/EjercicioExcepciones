using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    internal class Program
    {

        class Operaciones
        {
            public double Sumar(double a, double b)
            {
                return a + b;
            }

            public double Restar(double a, double b)
            {
                return a - b;
            }

            public double Multiplicar(double a, double b)
            {
                return a * b;
            }

            public double Dividir(double a, double b)
            {
                if (b != 0)
                {
                    return a / b;
                }
                else
                {
                    Console.WriteLine("No se puede dividir entre cero.");
                    return double.NaN;
                }
            }
        }

      
            static void Main()
            {
                Operaciones operaciones = new Operaciones();
                char opcion;

                do
                {
                    Console.WriteLine("Menú de Operaciones:");
                    Console.WriteLine("+ = Sumar");
                    Console.WriteLine("- = Restar");
                    Console.WriteLine("* = Multiplicar");
                    Console.WriteLine("/ = Dividir");
                    Console.WriteLine("S = Salir");
                    Console.Write("Elija una opción: ");
                    opcion = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (opcion == 'S' || opcion == 's')
                    {
                        Console.WriteLine("¡Hasta luego!");
                    }
                    else
                    {
                        Console.Write("Ingrese el primer número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        switch (opcion)
                        {
                            case '+':
                                Console.WriteLine($"Resultado: {operaciones.Sumar(num1, num2)}");
                                break;
                            case '-':
                                Console.WriteLine($"Resultado: {operaciones.Restar(num1, num2)}");
                                break;
                            case '*':
                                Console.WriteLine($"Resultado: {operaciones.Multiplicar(num1, num2)}");
                                break;
                            case '/':
                                Console.WriteLine($"Resultado: {operaciones.Dividir(num1, num2)}");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Intente nuevamente.");
                                break;
                        }
                    }
                } while (opcion != 'S' && opcion != 's');
               Console.ReadKey(); 

            }
        
    }
}
