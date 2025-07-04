using exemploExplorando.Models;



Pessoa p1 = new Pessoa(nome: "Eduardo", sobrenome: "souza");



Pessoa p2 = new Pessoa(nome: "Amanda", sobrenome: "Kathllen");

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Inglês Básico";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();