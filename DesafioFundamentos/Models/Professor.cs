using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Professor : Pessoa
    {


        public decimal salario { get; set; }

        public override void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {idade} anos e meu salário é {salario:C}. Sou um professor excelente!");
        }
    }
}