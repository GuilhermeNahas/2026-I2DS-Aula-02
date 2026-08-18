/*
- A chave representa o nome.
- O valor representa o telefone.

O programa deve permitir:

1. Cadastrar um contato.
2. Pesquisar um contato pelo nome.
3. Alterar o telefone de um contato.
4. Remover um contato.
5. Exibir todos os contatos.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> agenda = new Dictionary<string, string>();

        agenda.Add("Pai", "14991119090");
        agenda.Add("Mae", "14669696969");
        Console.WriteLine();

        foreach (var item in agenda)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine();
        agenda["14991119090"] = "14676767676767"; //alterar 

        agenda.Remove("Mae");
        Console.WriteLine();

        foreach (var item in agenda)
        {
            Console.WriteLine("");
        }
    }
}