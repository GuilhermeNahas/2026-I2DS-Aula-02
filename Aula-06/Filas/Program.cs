internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM FILAS (FIFO) ===");


        // 1 - Criar uma nova fila vazia
        Queue<string> filaBanco = new Queue<string>();

        // 2 - Adicionar elementos na fila
        filaBanco.Enqueue("Zuleika"); // Indice 0
        filaBanco.Enqueue("Asdrubal"); // Indice 1
        filaBanco.Enqueue("Pafuncio");  // Indice 2
        filaBanco.Enqueue("Epaminondas"); // Indice 3

        // 3 - Percorrer elementos de uma fila
        Console.WriteLine();
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 4 - Remover elementos de uma fila
        string pessoaRetirada = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O nome chamado foi: {pessoaRetirada}");

        filaBanco.Enqueue("Lucrécia");
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 5 - Verificar se existe  um determinado elemento na lista
        string procurar = "Pafuncio";
        bool achou = filaBanco.Contains(procurar);
        Console.WriteLine();

        if (achou)
        {
            Console.WriteLine($"{procurar} está na fila!");
        }
        else
        {
            Console.WriteLine($"{procurar} NAO esta na fila");
        }
    }
}