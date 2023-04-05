internal class questao5
{
    private static void Main(string[] args)
    { 
        string nome = "juan";
        char[] letra = nome.ToCharArray();

        int inicio = 0;
        int fim = nome.Length - 1;

        while (inicio < fim)
        {
            // Troca os caracteres de posição
            char aux = letra[inicio];
            letra[inicio] = letra[fim];
            letra[fim] = aux;

            inicio++;
            fim--;
        }

        string reverse = new string(letra); 
        Console.WriteLine(reverse);

    }
}
