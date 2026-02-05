namespace Demo_IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company objCompany = new Company("Microsoft");

            Employee empFirst = new Employee();
            empFirst.Id = 101;
            empFirst.Name = "First Employee";
            empFirst.Salary = 1000M;

            objCompany.AddEmployee(empFirst);

            // Object Initialization!
            Employee empSecond                              // Declaration
                = new Employee()                            // Instantiation
            {                                               // Initialization
                Id = 102, 
                Name = "Second Employee", 
                Salary = 170.85M 
            };
            objCompany.AddEmployee(empSecond);


            Employee empThird
                = new Employee()
                {
                    Id = 103,
                    Name = "Third Employee",
                    Salary = 2050.50M
                };
            objCompany.AddEmployee(empThird);



            objCompany.DisplayInfo();
            Console.WriteLine();


            Console.WriteLine("--- Iterating through the employees collection using IEnumerator");
            objCompany.Reset();
            while(objCompany.MoveNext())
            {
                Employee? emp = objCompany.Current as Employee;
                if (emp is not null)
                {
                    Console.WriteLine("{0,2} {1,-30} {2,15:C}", emp.Id, emp.Name, emp.Salary);
                }
            }
        }
    }
}
