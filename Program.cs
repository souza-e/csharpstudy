using System.Globalization;
using exemploExplorando.Models;




DateTime data = DateTime.Now;

Console.WriteLine(data.ToShortTimeString());










/*
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


decimal valorMonetario = 10.50m;


Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CurrentCulture));

int numero = 121313;

Console.WriteLine(numero.ToString("##-##-##"));

*/









/*
string numero1 = "10";
string numero2 = "20";

string resultado = numero1 + numero2;

Console.WriteLine(resultado);



*/

/*
Pessoa p1 = new Pessoa(nome: "Eduardo", sobrenome: "souza");



Pessoa p2 = new Pessoa(nome: "Amanda", sobrenome: "Kathllen");

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Inglês Básico";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();*/