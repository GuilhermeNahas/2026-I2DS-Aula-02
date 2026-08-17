/*
1. Empilhe 4 ações;
2. Desempilhe (`Pop`) as 2 últimas ações;
3. A cada `Pop`, imprima qual ação foi desfeita.

**Conceitos:** `Stack<T>` • `Push()` • `Pop()`
*/


internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> historico = new Stack<string>();
        historico.Push("Digitar");
        historico.Push("Colar");
        historico.Push("Negrito");
        historico.Push("Apagar");

        string desfazer1 = historico.Pop();
        Console.WriteLine($"Ação desfeita: {desfazer1}");

        string desfazer2 = historico.Pop();
        Console.WriteLine($"Ação desfeita: {desfazer2}");

    }
}