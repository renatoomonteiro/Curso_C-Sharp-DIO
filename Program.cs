// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Teste 1234");

using System.Runtime.CompilerServices;
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

//Criando a nossa classe Calculadora
Calculadora calc = new Calculadora();
calc.Somar(10, 20);
calc.Subtrair(10, 5);
calc.Multiplicar(10, 5);
calc.Dividir(10, 2);
calc.Potencia(2, 3);



DateTime dataAtual = DateTime.Now; //Exibe data e hora atual do sistema em que o código está sendo executado
Console.WriteLine("Data e Hora Atual: " + dataAtual);

DateTime dataAtualMaisDias = DateTime.Now.AddDays(5); //Adiciona 5 dias a data atual
Console.WriteLine("Data e Hora Atual mais 5 dias: " + dataAtualMaisDias);

DateTime dataFormatada = DateTime.Now;
Console.WriteLine("Data Formatada: " + dataFormatada.ToString("dd/MM/yyyy")); //Formata a data no padrão brasileiro (dia/mês/ano)

DateTime dataFormatadaComHoraMinuto = DateTime.Now;
Console.WriteLine("Data Formatada: " + dataFormatadaComHoraMinuto.ToString("dd/MM/yyyy HH:mm"));//Formata a data no padrão brasileiro (dia/mês/ano hora:minuto)

//Operadores de atribuição

int a = 10;
int b = 20;
int c = a + b; //Operador de atribuição simples
c += 5; //Operador de atribuição simples

Console.WriteLine("\nOperador de atribuição simples: " + c);

//Cast - Casting
int d = Convert.ToInt32("5");
int e = int.Parse("10");

Console.WriteLine(d + e);

//Utilizando o Convert

int f = Convert.ToInt32(null);
Console.WriteLine(f);

//Exemplo de conversão utilizando o método ToString()
int inteiro = 5;
string g = inteiro.ToString();
Console.WriteLine(g);

//Casting implicito
int h = 17;
double i = h; //Conversão implícita de int para double
Console.WriteLine(i);

//Representação máxima de um inteiro

int j = int.MaxValue;
long k = j;

Console.WriteLine(k);

//Exemplo de cast Implícito
int expressao = 4 / 2 + 2;
Console.WriteLine(expressao);

//Exemplo de prioridade aritimética
int expressao2 = 4 / (2 + 2);
Console.WriteLine(expressao2);

//Exemplo de saída, caso haja falha na conversão
string l = "15-";
int m = 0;

int.TryParse(l, out m);
Console.WriteLine("Conversão realizada com sucesso: " + m);

//Exemplo de condicional if-else
int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


if(quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida.");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
}

//Aprendendo o switch case
Console.WriteLine("\nDigite uma letra");
string letra = Console.ReadLine();

//Verificar se é ou não uma vogal
switch (letra.ToLower())
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é vogal");
        break;
}

//Operador OR na prática
bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada não liberada");
}

//Operador AND na prática
bool possuiPresencaMinima = true;
double media = 5.5;

if(possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

//Operador OR na prática
bool possuiPresencaMinima2 = true;
double media2 = 5.5;

if(possuiPresencaMinima2 || media2 >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

//Operador NOT na prática
bool choveu = false;
bool estaTarde = false;

if(!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}

calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

//Incremento e Decremento

int numero = 10;
Console.WriteLine($"Valor inicial: {numero}");
numero++; //Incremento
Console.WriteLine($"Após o incremento: {numero}");

numero--; //Decremento
Console.WriteLine($"Após o decremento: {numero}");
numero += 5; //Adiciona 5 ao valor atual
Console.WriteLine($"Após adicionar 5: {numero}");

//Calculando Raiz Quadrada
calc.RaizQuadrada(9);
