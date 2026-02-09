namespace Demo_Delegates.Demo03
{
    public static class Demo
    {
        public static void RunThis()
        {
            // Process.DoSomething(Demo.ShowUpdateProgress );

            ProgressHandler objD = new ProgressHandler(Demo.ShowUpdateProgress);
            Process.DoSomething(objD);
        }

        private static void ShowUpdateProgress()
        {
            Console.WriteLine("--- CALLBACK METHOD was called using Delegate");
        }

    }

    public delegate void ProgressHandler();

    public class Process
    {
        public static void DoSomething(ProgressHandler? objD)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    // if(objD is not null)
                    // {
                    //    objD();
                    // }

                    objD?.Invoke();         // objD is not null, then invoke
                }
                Console.WriteLine("i = {0}", i);
            }
        }

    }


}
