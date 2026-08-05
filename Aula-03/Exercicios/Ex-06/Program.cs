using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string continuar;

        do
        {
            Console.WriteLine("Informe um número:");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            Console.WriteLine("Deseja continuar? S/N");
            continuar = Console.ReadLine();

        } while (continuar == "S" || continuar == "s");
    }
}
