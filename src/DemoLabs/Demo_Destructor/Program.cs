using System;

namespace Demo_Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CREATING Employee OBJECT");
            Employee emp1 = new Employee(1) { Name = "First Employee", Salary = 1000M };
            Console.WriteLine();

            Console.WriteLine("CALLING Work() for emp1");
            emp1.Work();
            Console.WriteLine();

            Console.WriteLine("CALLING m() to instantiate Employee #2 - (a)");
            m(name: "Employee #2 (a)");

            Console.WriteLine("CALLING n() to instantiate array of Employees [101-103]");
            n();

            Console.WriteLine("CALLING m() to instantiate Employee #2 - (b)");
            m(name: "Employee #2 (b)");

            Console.WriteLine("--------- EXITING MAIN");
            Console.WriteLine();
        }

        static void m( string name)
        {
            Employee emp2 = new Employee(2) { Name = name };

            Console.WriteLine("--- EXITING m()\n");
        }


        static void n()
        {
            Employee[] empArr = new Employee[3]
            {
                new Employee(101) { Name = "Employee 101", Salary = 505M}
                , new Employee(102) { Name = "Employee 102", Salary = 505M}
                , new Employee(103) { Name = "Employee 103", Salary = 505M}
            };

            Console.WriteLine("--- EXITING n()\n");
        }

    }
}
