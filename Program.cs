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


Console.WriteLine("Quantas notas definirão a média a ser calculada?");
// 1. Mudamos para 'int' porque a quantidade de notas é um número inteiro
int quantidadeNotas = int.Parse(Console.ReadLine()); 

// Criamos o array usando o int
float[] notas = new float[quantidadeNotas];
float soma = 0; // Criamos uma variável para acumular a soma das notas

for (int i = 0; i < quantidadeNotas; i++)
{
    // Usamos (i + 1) apenas na mensagem para exibir "1º nota" em vez de "0º nota"
    Console.WriteLine($"Digite a {i + 1}ª nota: ");
    
    // 2. Aqui convertemos a nota digitada corretamente para float usando float.Parse
    notas[i] = float.Parse(Console.ReadLine());
    
    // Vamos somando a nota atual ao total
    soma += notas[i];
}

Console.WriteLine("\n--- Notas Digitadas ---");
for (int i = 0; i < quantidadeNotas; i++)
{
    Console.WriteLine($"A nota na posição {i} é {notas[i]}");
}

// 3. Calculamos a média final dividindo a soma pela quantidade de notas
float mediaFinal = soma / quantidadeNotas;

Console.WriteLine($"\nA média final das notas é: {mediaFinal:F2}");