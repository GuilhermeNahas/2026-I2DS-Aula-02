internal class Program
{
    private static void Main(string[] args)
    {
        string nome = "";
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Olá, " + nome + " Seja bem-vindo!");

        int nota1;
        Console.Write("Digite o sua primeira nota: ");
        nota1 = int.Parse(Console.ReadLine());

        int nota2;
        Console.Write("Digite o sua segunda nota: ");
        nota2 = int.Parse(Console.ReadLine());

        int nota3;
        Console.Write("Digite o sua terceira nota: ");
        nota3 = int.Parse(Console.ReadLine());

        int media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("Sua media final foi " + media + ".");
        if (media >= 7)
        {
            Console.WriteLine("Resultado Final: Aprovado");

        } else
        {
            Console.WriteLine("Resultado Final: Reprovado");

        }


    }
}
