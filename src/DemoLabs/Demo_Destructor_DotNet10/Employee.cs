using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Destructor_DotNet10
{
    internal class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor got called!");
        }

        ~Employee()
        {
            Console.WriteLine("Destructor got called!");
        }
    }
}
