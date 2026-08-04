using System.Globalization;
using System.Net.WebSockets;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        //criar uma variavel
        // Sintaxe: tipo variavel nome_variavel = valor_variavel

        //tipos dados primarios
  
        //int -> Representacao de numeros inteiros

        int idade = 21;


        // double -> Representacao de Numeros Decimais
        double salario = 10352.25;
        float altura = 1.75f;  // acrescenta f no final
        decimal peso = 71.35m; //acrecenta m no final


        //String -> Representa um texto alphanumerico
        string nome = "Thomaz";
        string celular = "14996667788";
        string cpf = "123.456.789.03";
        

        // bool -> Representa um numero Booleano (true or false)
        bool estudante = true;
        bool temLimite = false;
        
        //DateTime -> representacao de data e hora
        DateTime cadastro = new DateTime(2026,08,04,09,15,32);
        DateOnly nascimento = new DateOnly(2010,01,20);

        /* ************************************************************************** */
    
        //Operadores Matematicos 
        // + -> soma
        // - -> subtrair
        /* * -> multlipicar */
        // / -> divisao
        // % -> resto divisao
        /* ˆ -> Exponenciacao */

        int n1 = 10;
        int n2 = 3; 
        double resultado = 0;
        
        //Calcular a soma dos dois numeros:  
        resultado = n1 + n2;
        Console.WriteLine("A soma dos dois numeros é: " + resultado);
    
        //Calcular a subtracao 
        resultado = n1 - n2;
        Console.WriteLine("A subtracao dos dois numeros é: " + resultado);
    
        //Calcular multiplicacao 
        resultado = n1 * n2;
        Console.WriteLine("A multiplicacao dos dois numeros é: " + resultado);

        //Calcular divisao 
        resultado = n1 / n2;
        Console.WriteLine("A divisao dos dois numeros é: " + resultado);


         //Calcular resto divisao 
        resultado = n1 % n2;
        Console.WriteLine("O resto divisao dos dois numeros é: " + resultado);

        //Operador incremento
        Console.WriteLine("Valor de N1: " + n1);
        n1++; // aumenta +1 no valor atual
        Console.WriteLine("Valor de N1: " + n1);

        //Operador de Incremento
        n1+=10;
        n1 = n1 + 10;
        Console.WriteLine("Valor de N1: " + n1);

        //Operador decremento
        Console.WriteLine("Valor de N1: " + n1);
        n1--; // aumenta +1 no valor atual
        Console.WriteLine("Valor de N1: " + n1);

        //Operador decremento
        n1-=10;
        n1 = n1 - 10;
        Console.WriteLine("Valor de N1: " + n1);


        /* ******************************************************************* */
        
        //Operadores Relacionais -> Realizam comparacoes 

        // > - maior que
        // < - menor que
        // >== - maior ou igual
        // <= - menor igual
        // == -> igualdade 
        // = -> Atribuicao
        // != -> Diferentes

        idade = 13;
        Console.WriteLine("A idade informada e maior que 18? " + (idade > 18));

        peso = 55;
        Console.WriteLine("O peso informado e menor que 60kg? " + (peso <= 60));

        estudante = false;
        Console.WriteLine("O nome informado e de um estudante? " + (estudante == true));

    /* *********************************************************************************************** */
    //Operadores Logicos -> permitem combinar duas ou mais condicoes
/*
    && -> E
    || -> ou
    ! -> operador de negacao
*/

    peso = 83;
    altura = 183;

    Console.WriteLine("Peso: " + peso + "Altura: " + altura );
    Console.WriteLine((peso <= 100 ) && (altura > 180));




    }
}