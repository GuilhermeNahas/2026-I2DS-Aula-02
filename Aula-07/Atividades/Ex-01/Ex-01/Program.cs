/*- Adicionar inicialmente 5 frutas.
- Exibir todas as frutas cadastradas.
- Solicitar ao usuário uma nova fruta.
- Adicionar a nova fruta à lista.
- Exibir novamente a lista atualizada. */

internal class Program
{
    public class Frutas
    {
        public string fruta {get; set;}
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== LISTA FRUTAS ===");
        List<Frutas> listaFrutas = new List<Frutas>();

        Frutas fruta1 = new Frutas{fruta = "Banana"};
        Frutas fruta2 = new Frutas{fruta = "Maca"};
        Frutas fruta3 = new Frutas{fruta = "Pera"};
        Frutas fruta4 = new Frutas{fruta = "Uva"};
        Frutas fruta5 = new Frutas{fruta = "Acerola"};
        Frutas fruta6 = new Frutas{fruta = "Goiaba"};


        listaFrutas.Add(fruta1);
        listaFrutas.Add(fruta2);
        listaFrutas.Add(fruta3);
        listaFrutas.Add(fruta4);
        listaFrutas.Add(fruta5);

        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"{item.fruta}");
        }
        listaFrutas.Add(fruta6);
        Console.WriteLine();
        Console.WriteLine("=== LISTA ATUALIZADA ===");

        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"{item.fruta}");
        }

        
    }
}