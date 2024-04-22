////1. (Vetores Valores Pares e Ímpares) Faça um programa que leia 10 números inteiros e imprime os seguintes itens:
//a) somente os valores pares;
//b) somente os valores ímpares;
//c) somente a primeira e a última posição;

Console.WriteLine("--- Vetores Valores Pares e Ímpares ---\n");

int numero, contador = 1;
int[] numeros = new int[10];
int[] pares = new int[10];
int[] impares = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"{contador}º número: ");
    numero = int.Parse(Console.ReadLine() );
    numeros[i] = numero;
    contador++;
}

for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        pares[i] = numeros[i];
    }
    else
    {
        impares[i] = numeros[i];
    }
}

Console.WriteLine("\nPares: ");
for(int x = 0; x < 10; x++)
{
    if (pares[x] != 0)
        Console.WriteLine(pares[x]);
}

Console.WriteLine("\nÍmpares: ");
for(int y = 0; y < 10; y++)
{
    if (impares[y] != 0)
        Console.WriteLine(impares[y]);
}