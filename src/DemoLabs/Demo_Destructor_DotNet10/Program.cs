namespace Demo_Destructor_DotNet10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine();
            Console.WriteLine("---- exiting main()");


            using (DisposableEmployee em = new DisposableEmployee())
            {
            }
        }
    }
}
