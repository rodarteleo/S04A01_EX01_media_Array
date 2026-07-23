using System.Security.Cryptography;

int [] arrayNum = new int[3];
var arrayNumComVar = new int[3];

// o var exige que a variável seja atribuída no momento da declaração, 
// caso contrário, o compilador não consegue inferir o tipo da variável. 
// No exemplo acima, `arrayNumComVar` é declarado como um array de inteiros com tamanho 3,
//  e o compilador infere corretamente o tipo como `int[]`.
// int[] arrayNumComVar2; A variável `arrayNumComVar2` é declarada como um array de inteiros, 
// mas não é inicializada no momento da declaração.
// Posso declarar e usar o var para inferir o tipo de uma variável, 
// mas é necessário inicializá-la no momento da declaração.

arrayNum[0] = 10;
Console.WriteLine(arrayNum[0]);
arrayNum[1] = 20;
Console.WriteLine(arrayNum[1]);
arrayNum[2] = 30;
Console.WriteLine(arrayNum[2]);

string[] arrayText = new string[3];
arrayText[0] = "Maça";
arrayText[1] = "Pêra";
arrayText[2] = "Uva";

Console.WriteLine(arrayText[0]);

//Faça um programa que pergunte o tamanho de um array de texto.
//Crie o array e depois preencha-o utilizando uma estrutura de repetição.
//Após preenchido exiba o array na tela para o usuário

Console.WriteLine("Qual o tamanho do seu array?");

int tamanhoArray = int.Parse(Console.ReadLine());

string[] textos = new string[tamanhoArray];

for (int i = 0; i < tamanhoArray; i++)
{
    Console.WriteLine($"Digite o {i+1}º nome: ");
    textos[i] = Console.ReadLine();
}

for (int i = 0; i < tamanhoArray; i++)
{
    Console.WriteLine($"O nome na posição {i} é {textos[i]}");
}

/// Crie um programa para cálculo de média que pergunte quantas notas serão calculadas,
/// obtenha os valores delas, realize o cálculo e exiba a nota média.

Console.WriteLine("===== Cálculo de Média Aritmética =====");
Console.WriteLine("Quantas notas definirão a média a ser calculada?");

int numNotas = int.Parse(Console.ReadLine());

// Criamos o array para armazenar as notas 
decimal[] notas = new decimal[numNotas];

// Criamos uma variável para ir acumulando a soma das notas
decimal somaNotas = 0;

for (int i = 0; i < numNotas; i++)
{
    Console.WriteLine($"Digite a {i+1}ª nota: ");
    notas[i] = decimal.Parse(Console.ReadLine());
    // Pegamos o valor que o usuário acabou de digitar e somamos ao total
    somaNotas += notas[i];
   
}

// O loop acabou! Agora que temos a soma total, calculamos a média fora do loop
decimal media = somaNotas / numNotas;

// Exibimos o resultado
// O :N2 no Console.WriteLine serve apenas para formatar o resultado com duas casas decimais na tela.
Console.WriteLine($"\nA média das {numNotas} notas é: {media:N2}");



// Exercicio Novo de LISTAS baseando no modelo de array strings acima

Console.WriteLine("Qual o tamanho de sua Lista?");

int tamanhoLista = int.Parse(Console.ReadLine());

List<string> textosLista = new List<string>();

for (int i = 0; i < tamanhoLista; i++)
{
    Console.WriteLine($"Digite o {i+1}º nome: ");
    textosLista.Add(Console.ReadLine());
}

Console.WriteLine($"Sua lista tem {textosLista.Count} itens/posições"); // O método Count funciona como Lenght no python

for (int i = 0; i < textosLista.Count; i++) // Este for só funciona após o for acima chegar ao fim
{
    Console.WriteLine($"O nome na posição {i} é {textosLista[i]}");
}

// Exercicio de LISTAS usando FOREACH baseando-se no modelo de lista acima.

Console.WriteLine("Qual o tamanho de sua Lista? (com foreach)");

int sizeListForeach = int.Parse(Console.ReadLine());

List<string> textsListForeach = new List<string>();

for (int i = 0; i < sizeListForeach; i++)
{
    Console.WriteLine($"Digite o {i+1}º nome: ");
    textsListForeach.Add(Console.ReadLine());
}

Console.WriteLine($"Sua lista tem {textsListForeach.Count} itens/posições"); // O método Count funciona como Lenght no python

int iterador = 0; // Cria o iterador para poder imprimir no console as posições dos indices para cada nome.
foreach(var item in textsListForeach) // poderia ser "foreach(string item in textsListForeach)
{
    Console.WriteLine($"O nome na posição {iterador} é {item}");
    iterador++;
}



// ==============================================================================
// Exercício - Criar lista e receber nomes, preenchendo a lista até o usuário 
// digitar "sair". Quando digitar "sair", deve mostrar todos os nomes preenchidos.
// ==============================================================================

// 1. Criamos a nossa lista de strings para guardar os nomes.
// Como a lista é dinâmica, ela começa vazia e vai crescendo conforme adicionamos itens.
List<string> listaNomes = new List<string>();

// 2. Criamos uma variável do tipo string chamada 'opcao' que vai controlar o nosso loop.
// Começamos ela vazia para que o programa entre no loop pela primeira vez.
string opcao = "";

Console.WriteLine("--- Cadastro de Nomes (Digite 'sair' para encerrar) ---");

// 3. Utilizamos o 'while'. Ele vai rodar ENQUANTO o que o usuário digitou for DIFERENTE de "sair"
while (opcao.ToLower() != "sair")
{
    Console.WriteLine("Digite um nome ou 'sair':");
    
    // Lemos o que foi digitado no console
    opcao = Console.ReadLine();

    // 4. Verificação importante: Se o usuário digitou "sair", NÃO queremos adicionar a
    // palavra "sair" na nossa lista de nomes! Por isso usamos este 'if'.
    if (opcao.ToLower() != "sair")
    {
        // Se NÃO for "sair", adicionamos o nome na lista usando o método .Add()
        listaNomes.Add(opcao);
        Console.WriteLine($"Nome '{opcao}' adicionado com sucesso!\n");
    }
}

// 5. Após sair do loop (quando o usuário digitar 'sair'), exibimos os resultados.
Console.WriteLine("\n--- Lista de Nomes Cadastrados ---");

// Usamos o 'foreach' que você colocou no seu código, que é a forma mais simples 
// e direta de passar por cada item da nossa lista.
foreach (string nome in listaNomes)
{
    Console.WriteLine("O nome é: " + nome);
}

Console.WriteLine("\nFim do programa!");