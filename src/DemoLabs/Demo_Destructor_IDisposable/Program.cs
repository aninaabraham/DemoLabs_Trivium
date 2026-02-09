using System;

namespace Demo_Destructor_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // m(1);

            // m(2);


            // Demo of RESOURCE MANAGEMENT  (resource: e9)
            using(Employee e9 = new Employee(9))
            {
                e9.Name = "Employee #9";
                e9.Salary = 5050M;
                e9.Work();
            }                                   // implicitly calls Dispose() method only for e9

            using (Employee e10 = new Employee(10), 
                            e11 = new Employee(11))
            {
                e10.Work();
                e11.Work();
            }                                   // implicitly calls Dispose() method for e10 & e11

                n();

            Console.WriteLine("--- exiting main()");
            Console.WriteLine();
        }


        static void n()
        {
            Employee emp100 = new Employee(100) { Name = "Employee 100" };
            emp100.Work();
            // emp100.Dispose():
        }

        static void m(int id)
        {
            Console.WriteLine("---- CREATE THE OBJECT");
            Employee emp1 = new Employee(id) { Name = "Employee #1", Salary = 5000M };
            Console.WriteLine();

            Console.WriteLine("---- USE THE OBJECT");
            emp1.Work();
            Console.WriteLine();

            Console.WriteLine("---- DISPOSE THE OBJECT (first time)");
            emp1.Dispose();
            Console.WriteLine();

            Console.WriteLine("---- DISPOSE THE OBJECT (second time)");
            try
            {
                emp1.Dispose();
                Console.WriteLine();
            }
            catch(Exception ex) 
            {
                Console.WriteLine("something went wrong calling Dispose() method second time!");
                Console.WriteLine("MESSAGE: {0}", ex.Message);
                Console.WriteLine();
            }

            Console.WriteLine("---- USE THE OBJECT after disposing!");
            try
            {
                emp1.Work();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("something went wrong calling Work() method second time!");
                Console.WriteLine("MESSAGE: {0}", ex.Message);
                Console.WriteLine();
            }

            Console.WriteLine("----- Changing the Salary for a Disposed object");
            try
            {
                Console.WriteLine("Salary before change: {0}", emp1.Salary);
                emp1.Salary += (emp1.Salary * 0.5M);
                Console.WriteLine("Salary after change: {0}", emp1.Salary);
            }
            catch (Exception ex)
            {
                Console.WriteLine("something went wrong using the property SALARY!");
                Console.WriteLine("MESSAGE: {0}", ex.Message);
                Console.WriteLine();
            }
        }
    }
}
