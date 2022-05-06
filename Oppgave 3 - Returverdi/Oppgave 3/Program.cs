namespace Program
{
    class Program
    {
        static int num1 = 222;
        static int num2 = 444;
        static void Main(string[] args)
        {
            Console.WriteLine(retur());
            Console.ReadLine();
        }
        static int retur()
        {
            int result = num1 + num2;
            return result;
        }
    }
}