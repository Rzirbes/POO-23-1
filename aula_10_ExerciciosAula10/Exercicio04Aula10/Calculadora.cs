using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04Aula10
{
    public class Calculadora : ICalculadora
    {
        public double Dividir(double num1, double num2)
        {
            var result = num1 / num2;
            Console.WriteLine(result);
            return result;
        }

        public double Multiplicar(double num1, double num2)
        {
            var result = num1 * num2;
            Console.WriteLine(result);
            return result;
        }

        public double Somar(double num1, double num2)
        {
            var result = num1 + num2;
            Console.WriteLine(result);
            return result;
        }

        public double Subtrair(double num1, double num2)
        {
            var result = num1 - num2;
            Console.WriteLine(result);
            return result;
        }
    }
}