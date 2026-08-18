internal class Program
{
    private static void Main(string[] args)
    {
var lista = new Dictionary<int, Funcionario>
        {
            { 1, new Funcionario { Matricula = 1, Nome = "Ana", Salario = 4500 } },
            { 2, new Funcionario { Matricula = 2, Nome = "Carlos", Salario = 2800 } },
            { 3, new Funcionario { Matricula = 3, Nome = "Beatriz", Salario = 6200 } },
            { 4, new Funcionario { Matricula = 4, Nome = "Daniel", Salario = 1900 } },
            { 5, new Funcionario { Matricula = 5, Nome = "Fernanda", Salario = 3500 } }
        };

        var ordenados = lista.Values.OrderBy(f => f.Salario);

        foreach (var f in ordenados)
        {
            Console.WriteLine($"{f.Nome} - Salário: R$ {f.Salario}");
        }
    }
}

// A classe deve ficar fora do método Main, mas dentro do namespace (ou do arquivo)
class Funcionario
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public decimal Salario { get; set; }
}