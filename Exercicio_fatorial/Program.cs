using System.Collections.Concurrent;

internal class Program
{
    private static void Main(string[] args)
    {
        //fatorial

        int num, resposta;

        Console.WriteLine("informe o valor: ");
        num = int.Parse(Console.ReadLine());

        resposta = fat(num);
        Console.WriteLine("o fatorial de " + num + " eh: " + resposta);


        int fat(int valor)
        {
            if (valor == 0)
            {
                return 1;
            }
            else
            {
                return (valor * fat(valor - 1));
            }
        }
    }
}