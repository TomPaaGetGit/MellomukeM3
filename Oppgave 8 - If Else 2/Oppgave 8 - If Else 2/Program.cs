namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CompNum(num1, num2));
        }
        static int CompNum(int num1, int num2)
        {
            if (num1 == num2)
            {
                return num1 * num2;
            } else
            {
                return num1 + num2;
            }
        }
    }
}