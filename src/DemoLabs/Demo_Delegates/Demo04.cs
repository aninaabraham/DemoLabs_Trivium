namespace Demo_Delegates.Demo04
{
    public delegate void ProcessHandler();

    static public class Demo
    {
        public static void RunThis()
        {
            Console.WriteLine("---- PROCESS A called");
            Process p1 = new Process();
            m(p1, 'A');
            Console.WriteLine();

            Console.WriteLine("---- PROCESS B called");
            Process p2 = new Process();
            m(p2, 'B');
            Console.WriteLine();


            // Delegate is subscribed to only one method 
            // (meaning: Delegate contains only one method to invoke!)
            Console.WriteLine("=== SINGLE CAST DELEGATE");
            Console.WriteLine("---- Method n() called passing the Delegate object");
            ProcessHandler objD1 = new ProcessHandler(p1.Step1);
            n(objD1);
            Console.WriteLine();


            Console.WriteLine("=== SINGLE CAST DELEGATE");
            ProcessHandler? objD1b = null;
            objD1b = new ProcessHandler(p1.Step1);
            n(objD1b);
            Console.WriteLine();


            int? i = null;
            i += 10;
            Console.WriteLine("i == {0}", i);
            Console.WriteLine("i == NULL ? {0}", i is null);
            Console.WriteLine();

            // Delegate is subscribed to more than one method 
            // (meaning: Delegate contains more than one method to invoke!)
            Console.WriteLine("=== MULTI- CAST DELEGATE");
            Console.WriteLine("---- Method n() called passing the Delegate object");
            ProcessHandler? objD2 = null; 
            objD2 += new ProcessHandler(p1.Step1);        // subscribe to Step1
            objD2 += new ProcessHandler(p1.Step3);                      // subscribe to Step3
            objD2 += new ProcessHandler(p1.Step5);                      // subscribe to Step5
            objD2 += new ProcessHandler(p1.Step2);                      // subscribe to Step2
            objD2 += new ProcessHandler(p1.Step10);                     // subscribe to Step10
            n(objD2);
            Console.WriteLine();

            Console.WriteLine("-- after adding two more steps!");
            objD2 += new ProcessHandler(p1.Step5);                      // subscribe to Step5
            objD2 += new ProcessHandler(p1.Step9);                      // subscribe to Step9
            n(objD2);
            Console.WriteLine();

            Console.WriteLine("-- after removing one of the steps!");   // LIFO: last in, first out
            objD2 -= new ProcessHandler(p1.Step5);                      // unsubscribe to Step5
            n(objD2);
            Console.WriteLine();


            Console.WriteLine("--- Delegate variable instantiated using another delegate object");
            if (objD2 is not null)
            {
                ProcessHandler objX = new ProcessHandler(objD2);
                n(objX);

                // changing the original delegate variable
                objD2 += new ProcessHandler(p1.Step8);

                Console.WriteLine("--- using objD2: after adding STEP 8 to objD2");
                n(objD2);
                Console.WriteLine();

                Console.WriteLine("--- using objX: after adding STEP 8 to objD2");
                n(objX);
                Console.WriteLine();
            }
        }

        private static void n(ProcessHandler? objD)
        {
            objD?.Invoke();
        }

        private static void m(Process p, char flag)
        {
            // 1.2.3.4.5.
            if(flag == 'A')
            {
                p.Step1();
                p.Step3();
                p.Step4();
                p.Step2();
                p.Step10();
            }
            else if(flag == 'B')
            {
                p.Step1();
                p.Step2();
                p.Step3();
                p.Step4();
                p.Step5();
            }
        }
    }


    class Process
    {
        public void Step1()
        {
            Console.WriteLine("Step 1 executed");
        }

        public void Step2()
        {
            Console.WriteLine("Step 2 executed");
        }

        public void Step3()
        {
            Console.WriteLine("Step 3 executed");
        }

        public void Step4()
        {
            Console.WriteLine("Step 4 executed");
        }

        public void Step5()
        {
            Console.WriteLine("Step 5 executed");
        }

        public void Step6()
        {
            Console.WriteLine("Step 6 executed");
        }

        public void Step7()
        {
            Console.WriteLine("Step 7 executed");
        }

        public void Step8()
        {
            Console.WriteLine("Step 8 executed");
        }

        public void Step9()
        {
            Console.WriteLine("Step 9 executed");
        }

        public void Step10()
        {
            Console.WriteLine("Step 10 executed");
        }

    }
}
