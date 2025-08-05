using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class ListaNome
    {


        public void AdicionarNome()
        {
            Console.WriteLine("Digite uma série de nomes separados por vírgula:");
            // Lê a linha com os nomes
            string linhaDeNomes = Console.ReadLine();

            // Separa os nomes e remove espaços extras
            List<string> nomes = linhaDeNomes
                .Split(',')
                .Select(nome => nome.Trim())
                .ToList();

            Console.WriteLine("Digite uma letra para filtrar os nomes:");
            // Lê a letra de filtro
            char letraFiltro = char.Parse(Console.ReadLine());

            // Filtra os nomes que começam com a letra (ignorando maiúsculas/minúsculas)
            List<string> filtrados = nomes
                .Where(nome => nome.StartsWith(letraFiltro.ToString(), StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Exibe os nomes filtrados ou mensagem padrão
            if (filtrados.Count == 0)
            {
                Console.WriteLine("Nenhum nome encontrado");
            }
            else
            {
                foreach (var nome in filtrados)
                {
                    Console.WriteLine(nome);
                }
            }

        }
    }
}