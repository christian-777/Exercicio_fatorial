internal class Program
{
    private static void Main(string[] args)
    {
        //fatorial

        int num;
        double fat = 1;

        Console.WriteLine("digite o numero para o fatorial: ");
        num = int.Parse(Console.ReadLine());


        for (int i = num; i > 0; i--)
        {
            Console.WriteLine(fat + " * " + i);
            fat = fat * i;
        }

        Console.WriteLine("fatorial: " + fat);
    }
}