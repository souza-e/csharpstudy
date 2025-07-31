using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Aluno : Pessoa
    {

        public Aluno(string nome) : base(nome)
        {

        }


        public int nota { get; set; }


        public override void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {idade} anos e minha nota é {nota}.e sou um aluno otimo");
        }
    }
}