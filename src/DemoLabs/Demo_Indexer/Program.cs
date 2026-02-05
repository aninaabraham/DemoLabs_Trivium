namespace Demo_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company objCompany = new Company("Microsoft");

            Console.WriteLine("{0} created", objCompany.CompanyName);
            Console.WriteLine();

            objCompany.AddEmployee("First Employee", 1000M);
            objCompany.AddEmployee("Second Employee", 150.75M);
            objCompany.AddEmployee("Third Employee", 3000.80M);

            Console.WriteLine("--- after adding three employees:");
            objCompany.DisplayInfo();
            Console.WriteLine();



            // Employee empFound = objCompany["Second Employee"];

            int idToFind = 105;
            Employee? empFound = objCompany.FindEmployeeWithId(idToFind);
            if (empFound != null)
            {
                Console.WriteLine("Employee found");
                Console.WriteLine("{0} {1} {2}", empFound.Id, empFound.Name, empFound.Salary);
            }
            else
            {
                Console.WriteLine("Employee with ID == {0} NOT found", idToFind);
            }


            Employee? empWithId101 = objCompany[101];
            if (empWithId101 != null)
            {
                Console.WriteLine("Employee found using INDEXER");
                Console.WriteLine("{0} {1} {2}", empWithId101.Id, empWithId101.Name, empWithId101.Salary);
            }
            else
            {
                Console.WriteLine("Employee with ID == {0} NOT found", idToFind);
            }


            objCompany[103]?.Name = "changed name";

            Console.WriteLine("{0} {1}",
                objCompany["Second Employee"]?.Id, objCompany["Second Employee"]?.Name );
        }
    }
}
