using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Diretor :Professor
    {
        public override void apresentar()
        {
            Console.WriteLine($"Olá, meu nfffffome é {Nome}, tenho {idade} anos e meu salário é {salario:C}. Sou o diretor da escola e estou aqui para garantir a melhor educação!");
        }
    }
}