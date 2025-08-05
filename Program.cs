using System.Globalization;
using exemploExplorando.Models;







Dictionary<string, string> estados = new Dictionary<string, string>();


estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");


foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("SP");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

/*
Stack<int> pilha = new Stack<int>();



pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

pilha.Pop();
Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");

foreach (var item in pilha)
{
    Console.WriteLine(item);
}

/*

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach (var item in fila)
{
    Console.WriteLine(item);
}
*/










//new ExemploExcecao().Metodo1();





/*
try
{

    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");

}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");

}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");

}
finally
{
    Console.WriteLine("Chegou no finally");
}
*/


/*
DateTime data = DateTime.Now;

Console.WriteLine(data.ToShortTimeString());

*/








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