using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int idade { get; set; }

        public string email { get; set; }

        // Método para apresentar a pessoa
        public virtual void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {idade} anos.");
        }

    }
}