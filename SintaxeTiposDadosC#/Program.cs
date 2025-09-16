using System.ComponentModel.Design;
using SintaxeTiposDadosC.commom.Models; // Importando o namespace onde a classe Pessoa está localizada

// Recolher blocos de código ctrl + k depois ctrl + 0, expadir: depois ctrl + J

// Atribiu valor a varável Pessoa em Pessoa.cs
/* Pessoa pessoa1 = new Pessoa(); // pessoa1 variável do tipo Pessoa, ctlr k c: comenta
SintaxeTiposDadosC.commom.Models.Pessoa p = new Pessoa(); // outra forma é usar o namespace completo

pessoa1.Nome = "Leandro";
pessoa1.Idade = 35;
pessoa1.Apresentar();

DateTime dataAtual = DateTime.Now; // por padrão aparece dia e hora
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); */

/* combinando operadores
int a = 10;
int b = 20;

int c = a + b;

c += 5; // c = c + 5;
Console.WriteLine(c); */

/* Cast - Casting - Conversão
int d = Convert.ToInt32("5"); // int d = int.Parse("5")
Console.WriteLine(d); */

/* Converter para String
int inteiro = 5;
string e = inteiro.ToString(); */

/* Cast Implícito
int f = int.MaxValue; // int está contido em long
long g = f; */

/* Cast Seguro (Forçado em caso de erro)
string h = "15-";
int i = 0; // int i = Convert.(h) dá erro por conta do -
int.TryParse(h, out i); // converte em h, se der erro convernte em i */

/* Debugando e uso do if else
int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
Console.WriteLine("Venda inválida.");
}
else if (possivelVenda)
{
Console.WriteLine("Venda realizada.");
}
else
{
Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
} */

/* if else e switch case
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine(); // Readline: lê o que foi digitado

switch (letra)
{
case "a":
case "e":
case "i":
case "o":
case "u":
Console.WriteLine("Vogal");
break;

default: // como se fosse o else
Console.WriteLine("Não é uma vogal");
break;
} */
/* if (letra == "a" ||letra == "e" ||letra == "i" ||letra == "o" ||letra == "u") // ||: OU lógico exclusivo {Console.WriteLine("Vogal");} else {Console.WriteLine("Não é uma vogal");} */
/* if (letra == "a") {Console.WriteLine("Vogal");}
else if (letra == "b") {Console.WriteLine("Vogal");}
else {Console.WriteLine("Não é uma vogal");} */

// Somar, Potencia, Seno, Raiz quadrada
/*Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Potencia(3, 3);
calc.Seno(30);
calc.RaizQuadrada(9); */

/* Incremento decremento
int numeroIncremento = 10;

Console.WriteLine("Incrementando o 10");
numeroIncremento++; // numeroIncremento = numeroIncremento + 1; -- Decremento
Console.WriteLine(numeroIncremento); */

/* for
int numero = 5;

for (int i = 0; i <= 10; i++) // Três Sintaxes: declaração da variável, condição de parada, incremento
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
} */

/* while e uso do break
int numero = 5;
int i = 0; // Declaração da variável

while (i <= 10) // Condição de parada
{
    Console.WriteLine($"Execução {i}: {numero} x {i} = {numero * i}");
    i++; // Incremento

    if (i == 5)
    {
        break; // Interrompe a execução mesma se verdadeira, na condição do if
    }
} */

/* do while: executa primeiro depois verifica a condição
int soma = 0, numero = 0; // declarar duas variáveis do mesmo tipo em uma linha

do
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine()); // Readline recebe string, convert para int

    soma += numero; // soma = soma + numero;

} while (numero != 0); // Condição de parada

Console.WriteLine($"Total da soma dos números digitados é: {soma}"); */

/* Menu interativo

string opcao;
bool exibirMenu = true;

while (exibirMenu) // condição true, se chamada false encerra o loop
{
    Console.Clear(); // Limpa o menu
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Apagar cliente");
    Console.WriteLine("3 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Apagar cliente");
            break;

        case "3":
            Console.WriteLine("Encerrar");
            exibirMenu = false; // Encerra o loop, pois a condição do while ficou false, mas exibe o resto do código que está abaixo
            //Environment.Exit(0); // Encerra o loop, não mostra mais nada depois daqui
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;
    }
}

Console.WriteLine("O programa se encerrou"); */

/* array com for e foreach

int[] arraysInteiros = new int[3]; // array precisa de uma capacidade [3]

arraysInteiros[0] = 72;
arraysInteiros[1] = 64;
arraysInteiros[2] = 50;
//arraysInteiros[3] = 1; // posição inválida

// Redimensionar tamanho Resize ou Copy
// Array.Resize(ref arraysInteiros, arraysInteiros.Length * 2); //ref endereço do array, novo tamanho

// int[] arraysInteirosDobrado = new int[arraysInteiros.Length * 2];
// Array.Copy(arraysInteiros, arraysInteirosDobrado, arraysInteiros.Length);

Console.WriteLine("Array com for:");

// for tem que declarar a posição máxima (Lenght)
for (int i = 0; i < arraysInteiros.Length; i++) // Lenght capacidade do array
{
    Console.WriteLine($"Posição N° {i} : {arraysInteiros[i]}");
}

// foreach

Console.WriteLine("Array com foreach:");
//int iForeach = 0; //não precisa de contador(i), para declarar o valor

foreach (var valor in arraysInteiros) // Não depende da posição
{
    Console.WriteLine(valor);
//    Console.WriteLine($"Posição N° {iForeach} : {valor}");
    //    iForeach++;
} */

// Lista não precisa de capacidade máxima
// Pode adicionar e remover sem refazer todo o código

/* List<string> listaStrings= new List<string>();

listaStrings.Add("SP");
listaStrings.Add("BA");
listaStrings.Add("MG");
listaStrings.Add("RJ");

Console.WriteLine($"Itens na lista {listaStrings.Count} - Capacidade: {listaStrings.Capacity}");
// Count: quantos elementos tem atualmente
// Capacity: elementos que pode armazenar, se aumentar dobra a capacidade como padrão

listaStrings.Add("SC");

Console.WriteLine($"Itens na lista {listaStrings.Count} - Capacidade: {listaStrings.Capacity}");

listaStrings.Remove("MG");

Console.WriteLine($"Itens na lista {listaStrings.Count} - Capacidade: {listaStrings.Capacity}"); */
