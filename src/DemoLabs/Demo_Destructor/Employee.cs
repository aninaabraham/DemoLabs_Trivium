using System;

namespace Demo_Destructor
{
    internal class Employee
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public decimal Salary { get; set;  }

        static private int _counter;


        /// <remarks>
        ///     RULES FOR TYPE CONSTRUCTORS
        ///     1. Name of the Class 
        ///     2. No Arguments/Parameters
        ///     3. No Return Type
        ///     4. Has to static 
        ///     5. No Access Modifier
        /// </remarks>  
        static Employee()
        {
            _counter = 0;
        }


        /// <remarks>
        ///     RULES FOR INSTANCE CONSTRUCTORS
        ///     1. Name of the Class
        ///     2. Can have Arguments/parameters
        ///     3. No Return Type (returns always object of current type)
        ///     4. Cannot be static
        ///     5. Can have Access modifier
        ///     6. Can be parameterized (overloaded) or non-parameterized
        /// </remarks>  
        public Employee(int id)
        {
            // this.Id = ++_counter;
            this.Id = id;

            Console.WriteLine("Employee {0} object INSTANTIATED!", this.Id);
            //Console.WriteLine("---{0}: Induction Training done", this.Id);
            //Console.WriteLine("---{0}: Access Card is granted", this.Id);
            //Console.WriteLine("---{0}: Workstation is assigned", this.Id);
        }

        /// <remarks>
        ///     RULES FOR INSTANCE DESTRUCTOR
        ///     1. Name of the Class preceded with "~" ( tildé )
        ///     2. No arguments/parameters
        ///     3. No return type
        ///     4. Cannot be static (its always for the instance)
        ///     5. No access modifier (always public)
        ///     6. Cannot be parameterized (always non-parameterized)
        /// </remarks>  
        ~Employee()
        {
            //Console.WriteLine("---{0}: Work has to be transferred/reallocated to another employee", this.Id);
            //Console.WriteLine("---{0}: Return the Access Card", this.Id);
            //Console.WriteLine("---{0}: Workstation is surrendered", this.Id);
            Console.WriteLine("Employee {0}:{1} object is DESTROYED!", this.Id, this.Name);
        }


        public void Work()
        {
            Console.WriteLine("Employee {0}:{1} is working", this.Id, this.Name);
        }
    }
}
