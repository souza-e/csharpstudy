using DesafioFundamentos.Interfaces;
using DesafioFundamentos.Models;


ICalculadora calculadora = new Calculadora();
Console.WriteLine(calculadora.Somar(5, 3));        // Saída: 8




ListaNome Lis = new ListaNome();

Lis.AdicionarNome();




/*
Aluno a1 = new Aluno("João");

a1.idade = 20;

*/



/*
Aluno a1 = new Aluno();
Professor p1 = new Professor();

a1.nome = "João";
a1.idade = 20;
a1.apresentar();
a1.nota = 85;
a1.email = "souza@hotmail.com";


p1.nome = "Maria";
p1.idade = 40;
p1.salario = 5000;
p1.apresentar();



*/











// Coloca o encoding para UTF8 para exibir acentuação
/*Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
*/