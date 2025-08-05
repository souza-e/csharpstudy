using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        public void AdicionarAluno(Pessoa aluno)
        {

            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {

            int quantidade = Alunos.Count;

            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {

            Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos matriculados no curso {Nome}:");
          
          for (int i = 0; i < Alunos.Count; i++)
            {
                // string texto = "Nº " + i + " - " + Alunos[i].NomeCompleto;
               
               string texto = $"Nº {i} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
          
            


        }
    }




}