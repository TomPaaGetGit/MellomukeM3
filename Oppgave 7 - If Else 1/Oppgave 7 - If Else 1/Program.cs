namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            bool result = false;
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CompNum(num1, num2, result));
        }

        static bool CompNum(int num1, int num2, bool result)
        {

            if (num1 == num2)
            {
                result = true;
                return result;
            } else
            {
                result = false;
                return result;
            }
        }
    }
}