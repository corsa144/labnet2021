using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Logic
    {
        public static int Dividir(int numero)
        {
            try
            {
                numero = numero / 0;
            }catch(DivideByZeroException ex)
            {
                throw new CustomException(ex.Message);
            }
            return numero;
        }

        public static float Dividir(int dividendo, int divisor)
        {
            float resultado = 0;
            try
            {
                //  resultado = dividendo / divisor;
               resultado = DividirExtensionMethod.DividirEnteros(dividendo, divisor);
            }catch(DivideByZeroException ex)
            {
                throw new CustomException($"Error. Solo Chuck Norris sabe dividir por cero. {ex.Message}");
            }catch(Exception ex)
            {
                throw new CustomException($"Seguro Ingreso una letra o no ingreso nada!. {ex.Message}");
            }
            return resultado;
        }
    }
}
