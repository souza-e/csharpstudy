using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Pessoa
    {

       public string nome { get; set; }
       public int idade { get; set; }
       public void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
        }
        
    }
}