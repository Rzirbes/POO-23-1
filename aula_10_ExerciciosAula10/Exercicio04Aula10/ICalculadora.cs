using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04Aula10
{
    public interface ICalculadora
    {
        public double Somar(double num1, double num2);
        public double Multiplicar(double num1, double num2);
        public double Dividir(double num1, double num2);
        public double Subtrair(double num1, double num2);
    }
}