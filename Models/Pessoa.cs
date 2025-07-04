using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploExplorando.Models
{
    public class Pessoa
    {


        private string _nome;
        private int _idade;
        public string Nome
        {

            get => _nome.ToUpper();


            set
            {

                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");

                }

                _nome = value;
            }
        }
        public int Idade
        {

            get => _idade;
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser Menor que 0.");
                }
                _idade = value;
            }

        }

        public void Apresentar()
        {


            Console.WriteLine($"{Nome} tem {Idade} anos.");
        }


    }



}