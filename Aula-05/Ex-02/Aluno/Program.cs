using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
        //Principal || Main
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Cristiano";
        aluno1.Rm = 4110;
        aluno1.Email = "cristiano@gmail.com";
        aluno1.Nascimento = new DateTime(1900, 6, 23); 

        Console.WriteLine($"\n Aluno: {aluno1.Nome} || RM: {aluno1.Rm} || Email: {aluno1.Email}");

        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Diogo";
        aluno2.Rm = 6767;
        aluno2.Email = "cheroso@gmail.com";
        aluno2.Nascimento = new DateTime(2012, 12, 12); 

        Console.WriteLine($"\n Aluno: {aluno2.Nome} || RM: {aluno2.Rm} || Email: {aluno2.Email}");

        Aluno aluno3 = new Aluno();
        aluno3.Nome = "Natan ";
        aluno3.Rm = 1234;
        aluno3.Email = "jogadorMacedo@gmail.com";
        aluno3.Nascimento = new DateTime(2008, 12, 01); 

        Console.WriteLine($"\n Aluno: {aluno3.Nome} || RM: {aluno3.Rm} || Email: {aluno3.Email}");
}

    public class Aluno
    {
         public string Nome { get; set; } 
        public int Rm { get; set; } 
        public string Email { get; set; } 
        public DateTime Nascimento { get; set; } //Ano/ Mes/ Dia
    }
}