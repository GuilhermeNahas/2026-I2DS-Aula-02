using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Imprimindo numeros de 1 a 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Imprimindo numeros de 10 a 1");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

    /*********************************************************************/

        Console.WriteLine("Imprimir numeros de 1 a 10, utilizando while");
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        //solicitar senha ate acertar
        string senha = "";
        while (senha != "2444")
        {
            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();
        }

        Console.WriteLine("Acesso permitido");
    
        int num;
        do
        {
            Console.WriteLine("digite um numero positivo: ");
            num = int.Parse(Console.ReadLine());
        }while(num <= 0);
    
    
    }
}
