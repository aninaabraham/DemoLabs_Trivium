namespace Demo_CopyTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------- reference copy version");
            Demo01.RunThis.Run1();

            Console.WriteLine("------------------------- shallow copy version");
            Demo01.RunThis.Run2();

            Console.WriteLine("------------------------- deep copy version");
            Demo01.RunThis.Run3();
        }
    }
}
