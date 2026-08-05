/*
1. Solicitar usuário;
2. Solicitar senha;
3. Permitir até três tentativas;
4. Bloquear após três erros.
*/
internal class Program
{
    private static void Main(string[] args)
    {
        const string  usuario = "admin";
        const string senha = "1234";

        int tentativas = 0;
        const int maxTentativas = 3;
        bool loginSucesso = false;

        while (tentativas < maxTentativas && !loginSucesso)
        {
            Console.WriteLine($"--- Login (Tentativa {tentativas + 1} de {maxTentativas}) ---");
        }

    }
}