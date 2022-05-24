using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Calculadora
    {

        public double resultado;

        public Calculadora(double valor)
        {
            resultado = valor;
        }
        public void suma(double valor)
        {
            resultado += valor;
        }

        public void resta(double valor)
        {
            resultado -= valor;
        }

        public void multiplicacion(double valor)
        {
            resultado = resultado * valor;
        }

        public void division(double valor)
        {
            if(valor != 0)
            {
                resultado = resultado / valor;

            }
            else
            {
                Console.WriteLine("opa\n");
            }
        }

        public void limpiar(double resultado)
        {
            resultado = 0;
        }

    }
}
