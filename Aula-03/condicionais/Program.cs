internal class Program
{
    private static void Main(string[] args)
    {
        /* if (condicao)
        {
            codigo se verdadeiro 
        }else{
            codigo se falso
        }
        */

        //Verificar se uma idade e maior que 18 anos
int idade = 15; 

if (idade >= 18) 
{ 
    Console.WriteLine("Maior de idade");
} 
else 
{ 
    Console.WriteLine("Menor de idade"); 
}

    /* ********************************************** */
    Console.WriteLine("Digite sua nota: ");
    double nota = double.Parse(Console.ReadLine());

    if (nota >= 7)
    {
        Console.WriteLine("Aprovado");
    }
        else
        {
        Console.WriteLine("Reprovado");
        };

    /* *************************************** */

    bool bloqueado = false;

    if (!bloqueado)
    {
        Console.WriteLine("Acesso liberado");
    }
        else
        {
        Console.WriteLine("Acesso Negado"); 
        }
    
    /**********************************************************************/

    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Consultar");
    Console.WriteLine("3 - Excluir");
    Console.WriteLine("4 - Sair");

    Console.WriteLine("Escolha uma opcao: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Cadastro selecionado");
        break;
    
        case 2:
            Console.WriteLine("Consultar selecionado");
        break;

        case 3:
            Console.WriteLine("Excluir selecionado");
        break;    

        case 4:
            Console.WriteLine("Sair selecionado");
        break;

        default:
            Console.WriteLine("Opcao invalida");
            break;
    }

    



    }   
}
