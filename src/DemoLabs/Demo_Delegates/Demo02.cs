namespace Demo_Delegates.Demo02
{
    public static class CalculatorExtensions
    {
        public static int Subtract(this Calculator objCalc, int x, int y)
        {
            // DOES NOT LEVERAGE THE ENCAPSULATED LOGIC OF THE CALCULATOR CLASS
            return x - y;
        }
    }

    // Type Developer Step 1. Defines the Delegate
    public delegate int ComputeHandler(int x, int y);

    public sealed class Calculator
    {
        // 1. Inheritance
        // 2. Extension
        // 3. Delegate
        public int Add(int x, int y)
        {
            int result = -1;

            Console.WriteLine("Encapsulated logic in Calculator.Add()");
            Console.WriteLine("1. Authentication");
            Console.WriteLine("2. Authorization");
            Console.WriteLine("3. Validation");
            Console.WriteLine("4. The Acitivity / The Process");
            result = x + y;

            Console.WriteLine("5. Audit Logging");
            Console.WriteLine();

            return result; 
        }

        // Type Developer Step 2. Defines the method to receive the Delegate variable
        public int Compute(ComputeHandler? objD, int x, int y)
        {
            Console.WriteLine("Encapsulated logic in Calculator.Compute() method");
            Console.WriteLine("1. Authentication");
            Console.WriteLine("2. Authorization");
            Console.WriteLine("3. Validation");

            Console.WriteLine("4. The Acitivity / The Process");
            int result = -1;

            // Type Developer Step 3. Check if the Delegate is subscribed
            if (objD is not null)
            {
                // Type Developer Step 4. invoke the method of the delegate
                // result = objD(x, y);         // short-cut version to invoke
                result = objD.Invoke(x, y);     // elaborate version to invoke
            }

            //int? result = objD?.Invoke(x, y);

            Console.WriteLine("5. Audit Logging");
            Console.WriteLine();
            return result;
        }

    }


    public static class Demo
    {
        public static void RunThis()
        {
            Calculator objCalc = new Calculator();
            int a = 10, b = 20;

            Console.WriteLine("--- Calling the Add() method of the object");
            Console.WriteLine("{0} + {1} == {2}", a, b, objCalc.Add(a, b));
            Console.WriteLine();

            Console.WriteLine("--- Calling the Subtract() method of the object using EXTENSIONS");
            Console.WriteLine(" {0} - {1} == {2}", a, b, objCalc.Subtract(a, b));
            Console.WriteLine();

            Console.WriteLine("--- calling the Multiply() method directly");
            Console.WriteLine(" {0} * {1} == {2}", a, b, Demo.Multiply(10, 20));
            Console.WriteLine();


            Console.WriteLine("--- calling the Multiply() method using the Delegate");
            // Object Developer 2: Call the method which receives the delegate variable
            //                     passing the method to be CALLED BACK.
            Console.WriteLine(" {0} * {1} == {2}", a, b, objCalc.Compute(Demo.Multiply, 10, 20) );
            Console.WriteLine();
        }

        // Object Developer 1: Defines the method that would eventually be called using the Delegate
        static int Multiply(int x, int y)
        {
            return x * y;
        }


    }

}
