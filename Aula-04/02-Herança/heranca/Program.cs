internal class Program
{
    private static void Main(string[] args)
    {
/*
Heranca: uma subclasse (Classe filha) recebe os atributos e metodos da super classe (Classe Mae)
*/

        Animal animal01 = new Animal();
        Cachorro dog01 = new Cachorro();

        animal01.Nome = "Ferdinando";
        animal01.Idade = 2;

        Console . WriteLine($"Nome do animal: {animal01.Nome} - Idade {animal01.Idade}");

        dog01.Nome = "snoop";
        dog01.Idade = 5;
        dog01.Raca = "Vira lata";
        dog01.Latir();

        Console.WriteLine($"Nome: {dog01.Nome} | idade: {dog01.Idade} | Raca {dog01.Raca}");

    }
    //Super classe animal (Classe Mae)
    public class Animal
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
    }

    //Sub Classe cachorro (Classe filha)
    public class Cachorro : Animal
    {
        public string Raca {get; set;}
        public void Latir()
        {
            Console.WriteLine("Au Au");
        }
    }


}

