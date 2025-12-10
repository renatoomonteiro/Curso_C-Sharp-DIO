// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Teste 1234");

using Curso_C_SHARP_DIO.Models;

Pessoa p = new Pessoa();
p.Nome = "João";
p.Idade = 25;
p.Apresentar();

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Buta";
pessoa1.Idade = 26;
pessoa1.Apresentar();

string apresentacao = "Olá, seja bem vindo";
int quantidade = 10;
double altura = 1.80;
decimal preco = 1.80M; //Indicado para valores monetários
bool condicao = true;  

Console.WriteLine("\n"+ apresentacao);
Console.WriteLine("Quantidade: " + quantidade);
Console.WriteLine("Altura: " + altura.ToString("0.00"));
Console.WriteLine("Preço: " + preco);
Console.WriteLine("Condição: " + condicao);
