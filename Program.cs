internal class Program
{
    private static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Ingresa el numero");
        number = Convert.ToInt32(Console.ReadLine());
        if (number%2 == 0) {
            Console.WriteLine("Es par Chamo");
        }

        else {
            Console.WriteLine("Es impar bro");
        }
    }
}