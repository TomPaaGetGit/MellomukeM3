namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            int argnr = 0;
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
                argnr++;
            }
            Console.WriteLine("Du har sendt med " + argnr + " argumenter.");
        }
    }
}