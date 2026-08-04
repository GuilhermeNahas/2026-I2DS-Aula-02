// EX 1 Criar um programa capaz de converter temperaturas entre diferentes unidades.
//Fahrenheit = (Celsius * 9 / 5) + 32

internal class Program
{
    private static void Main(string[] args)
{ 
    int celsius; 
    Console.WriteLine("Digite a temperatura em °C: "); 
    celsius = int.Parse(Console.ReadLine()); 
    
    int calculo = (celsius * 9 / 5) + 32; 
    
    Console.WriteLine("A conversão de °C para °F é: " + calculo); 
}

}