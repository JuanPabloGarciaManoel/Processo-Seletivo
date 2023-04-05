internal class questao2
{
    private static void Main(string[] args)
    {
        fibonacci();  
    }

    private static void verificar(int [] numero)

    {  
        Console.WriteLine("Informe um número: "+"\n");
        int confereNum = Convert.ToInt32(Console.ReadLine());

        bool encontrado = false;

        for (int i = 0; i < 10; i++)
        {            
            if(confereNum == numero[i]){
                encontrado = true;
                break;
            }
        }

        if(encontrado){
            Console.WriteLine("Este número pertence à sequência de Fibonacci");
        } else {
            Console.WriteLine("Este número não pertence à sequência de Fibonacci");
        }

    }

    static void fibonacci (){
       
        int[] numero = new int[10];

        int numeroAtual = 0;
        int proxNum = numeroAtual + 1;

        for (int i = 0; i < numero.Length; i++)
            {  
                int aux = numeroAtual;
                numeroAtual = proxNum;
                numero[i] = (proxNum = aux + numeroAtual);
                Console.Write(numero[i]+"\t");
            }

            verificar(numero);
           
        }

}
