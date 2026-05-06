class program
{
    static void Main(string[] args)
    {
        char A = 'A';
        char Z = 'Z';
        do
        {
            
            Console.Write($"{A}");
            A++;
            if (A <= 'Z')
            {
                Console.Write(", ");
            } else
            {
                Console.WriteLine(".");
            }
        } while (A <= Z);


        do
        {
            Console.Write($"{Z}");
            Z--;
            if (Z >= 'A')
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine(".");
            }
        } while (Z >= 'A');












    }
}