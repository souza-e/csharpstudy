using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFundamentos.Interfaces;

namespace DesafioFundamentos.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int a, int b)
        {
            return a / b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}