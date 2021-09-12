using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionEnConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado;

            DividirPorCero();
            resultado = Dividir();
            Console.WriteLine($"{resultado}");

            Console.ReadKey();
        }

        public static void DividirPorCero()
        {
            int numero;
            Console.WriteLine("Igrese un numero que sera dividido por 0");
            string mensaje = Console.ReadLine();
            if (int.TryParse(mensaje, out numero))
            {
                try
                {
                    numero = numero / 0;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Se realizo la operacion");
                }
            }
            else
            {
                Console.WriteLine("No se ingreso un numero");
            }
        }

        public static string Dividir()
        {
            //string mensaje;
            int dividendo;
            int divisor;
            float resultado=0;
            StringBuilder cadena = new StringBuilder();
            Console.WriteLine("Ingrese dividendo:");
            if (int.TryParse(Console.ReadLine(), out dividendo))
            {
                Console.WriteLine("Ingrese Divisor:");
                if (int.TryParse(Console.ReadLine(), out divisor))
                {
                    try
                    {
                        resultado = dividendo / divisor;
                        cadena.AppendLine($"El resultado es: {resultado}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        cadena.AppendLine($"Error. Solo Chuck Norris divide por 0");
                        cadena.AppendLine($"{ex.Message}");
                    }
                    finally
                    {
                        cadena.AppendLine("Se realizo la operacion");
                    }

                }
                else
                {
                    cadena.AppendLine($"El divisor debe ser un numero entero");
                }
            }
            else
            {
                cadena.AppendLine($"El dividendo debe ser un numero entero");
            }

            return cadena.ToString();
        }
    }
}
