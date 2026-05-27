
  /*
        Leia uma matriz de reais.

        Depois:

        ✔ conte quantos números pares existem na matriz
        ✔ encontre o maior valor da matriz
        ✔ informe em qual linha e coluna esse maior valor apareceu

        */



using System;

class Program
{
    static void Main() // 
        int N = 0;

        do
        {
            Console.Write("digite dimensao: ");
            N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.Write("digite dimensao válida.");
            }

        } while (N <= 0);

        double[,] matriz = new double[N, N];

        for (int linhas = 0; linhas < N; linhas++)
        {
            for (int colunas = 0; colunas < N; colunas++)
            {
                Console.Write($"matriz[{linhas},{colunas}]:");
                matriz[linhas, colunas] = double.Parse(Console.ReadLine());
            }
        }

        /*
        Leia uma matriz 3x3 de inteiros.

        Depois:

        ✔ conte quantos números pares existem na matriz
        ✔ encontre o maior valor da matriz
        ✔ informe em qual linha e coluna esse maior valor apareceu
        */

        int pares = 0;
        int impares = 0;
        int linhaDoMaior = 0;
        int colunaDoMaior = 0;

        double maior = matriz[0, 0];

        for (int linhas = 0; linhas < N; linhas++)
        {
            for (int colunas = 0; colunas < N; colunas++)
            {
                if (matriz[linhas, colunas] > maior)
                {
                    maior = matriz[linhas, colunas];
                    linhaDoMaior = linhas;
                    colunaDoMaior = colunas;
                }

                if (matriz[linhas, colunas] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine($"o maior valor é o {maior}, localizado na posicao [{linhaDoMaior},{colunaDoMaior}], alem disso, tivemos {pares}, pares e {impares} impares.");
    }
}