internal class Program
{
    private static void Main(string[] args)
    {
        /*Vetores e Matrizes
        /*
        Vetor -> estrutura de dados utilizada para armazenar varios valores dentro de uma unica variavel

        tipo[] nome_vetor = new tipo[tamanho]
        */

        //iniciar um vetor -> lista de frutas

        string[]listaFrutas = {"Maca","Manga","Morango","Melancia","Melao" };

        Console.WriteLine("Acessar o terceiro elemento da lista");
        Console.WriteLine(listaFrutas[2]);

        Console.WriteLine("Alterar o segundo elemento da lista");
        listaFrutas[1] = "Banana";

        for (int i = 0; i < listaFrutas.Length; i++)
        {
            Console.WriteLine(listaFrutas[i]);
        }

        /**********************************************************/
        foreach (string fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }

    }
}