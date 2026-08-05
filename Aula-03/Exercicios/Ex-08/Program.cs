/*
1. Solicitar usuário;
2. Solicitar senha;
3. Permitir até três tentativas;
4. Bloquear após três erros.
*/
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        const string usuarioCorreto = "admin";
        const string senhaCorreta = "1234";

        int tentativas = 0;
        const int maxTentativas = 3;
        bool loginSucesso = false;

        while (tentativas < maxTentativas && !loginSucesso)
        {
            Console.Clear();
            Console.WriteLine($"--- Login (Tentativa {tentativas + 1} de {maxTentativas}) ---");

            Console.Write("Digite o usuário: ");
            string usuarioDigitado = Console.ReadLine();

            Console.Write("Digite a senha: ");
            string senhaDigitada = Console.ReadLine();

            if (usuarioDigitado == usuarioCorreto && senhaDigitada == senhaCorreta)
            {
                loginSucesso = true;
            }
            else
            {
                tentativas++;
                Console.WriteLine("Usuário ou senha incorretos!");
                Console.WriteLine("Pressione Enter para tentar novamente...");
                Console.ReadLine();
            }
        }

        if (loginSucesso)
        {
            Console.WriteLine("Login realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Conta bloqueada! Você excedeu o limite de 3 tentativas.");
        }
    }
}
