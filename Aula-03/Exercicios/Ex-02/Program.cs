//Desenvolva uma calculadora que permita ao usuário escolher uma operação matemática.

internal class Program
{
    private static void Main(string[] args)
    {
     int num1;
     int num2;

        Console.WriteLine("Digite o primeiro numero: ");
        num1 = int.Parse(Console.ReadLine());


        Console.WriteLine("Digite o segundo numero: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("1- Soma");
        Console.WriteLine("2- Subtracão");
        Console.WriteLine("3- multiplicacao");
        Console.WriteLine("4- Divisão");

        string operacao;

        Console.WriteLine("Selecione a operacão: ");
        operacao = Console.ReadLine();

                switch (operacao)
        {
            case "1": 
                Console.WriteLine(num1 + num2);
                break;
            case "2": 
                Console.WriteLine(num1 - num2);
                break;
            case "3": 
                Console.WriteLine(num1 * num2);

                break;
            case "4": 
                Console.WriteLine(num1 / num2);
                 break;
            default:
                Console.WriteLine("Operador informado não é válido.");
                break;
       
        }

    }
 }


