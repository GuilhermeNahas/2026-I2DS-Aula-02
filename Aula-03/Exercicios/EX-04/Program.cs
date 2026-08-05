/*
Desenvolva um programa que simule um caixa eletrônico.

O usuário informa um valor de saque.

O sistema deve informar a quantidade de notas necessárias.
*/

using System;


internal class Program
{
    private static void Main(string[] args)
    {
        int valor;
        Console.WriteLine("Informe o valor do seu saque: ");
        valor = int.Parse(Console.ReadLine());

        int[] notas = { 100, 50, 20, 10, 5, 2 };

        for (int i = 0; i < notas.Length; i++)
        {
            int qtdNotas = valor / notas[i];
            
            if (qtdNotas > 0)
            {
                if (qtdNotas == 1)
                {
                    Console.WriteLine(qtdNotas + " nota de R$ " + notas[i]);
                }
                else
                {
                    Console.WriteLine(qtdNotas + " notas de R$ " + notas[i]);
                }

                valor = valor % notas[i]; 
            }
        }

        if (valor > 0)
        {
            Console.WriteLine("Não é possível sacar o valor restante de R$ " + valor + " com as notas disponíveis.");
        }
    }
}
