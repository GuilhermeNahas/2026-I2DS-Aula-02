/*
1. Cadastrar produtos;
2. Cadastrar preços;
3. Listar produtos cadastrados;
4. Pesquisar um produto pelo nome.
*/
internal class Program
{
 private static void Main(string[] args)
    {
        List<string> produtos = new List<string>();
        List<double> precos = new List<double>();
        string opcao = "";

        while (opcao != "5")
        {
            Console.Clear();
            Console.WriteLine("1. Cadastrar produto");
            Console.WriteLine("2. Cadastrar preco");
            Console.WriteLine("3. Listar produtos");
            Console.WriteLine("4. Pesquisar produto");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opcao: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do produto: ");
                    string nome = Console.ReadLine();
                    break;

                case "2":
                    Console.Write("Preco do produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    break;

                case "3":
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        Console.WriteLine($"Produto: {produtos[i]} - Preco: R$ {precos[i]}");
                    }
                    break;

                case "4":
                    Console.Write("Digite o nome para pesquisar: ");
                    string busca = Console.ReadLine();
                    int indice = produtos.IndexOf(busca); //procura pelo conteúdo da variável busca dentro da lista produtos

                    if (indice != -1)
                    {
                        Console.WriteLine($"Encontrado! Produto: {produtos[indice]} - Preco: R$ {precos[indice]}");
                    }
                    else
                    {
                        Console.WriteLine("Produto nao encontrado.");
                    }
                    break;
            }

            if (opcao != "5")
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
