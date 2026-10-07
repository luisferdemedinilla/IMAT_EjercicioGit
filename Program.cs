namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(3,9));
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }
    }
     
}
