using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Indexer
{
    public class Company
    {
        public string CompanyName { get; private set; }

        private System.Collections.ArrayList theEmployees { get; set; }
        private int counter;

        public Company(string name)
        {
            counter = 100;
            CompanyName = name; 
            theEmployees = new System.Collections.ArrayList();
        }


        public int NumberOfEmployees
        {
            get {  return counter; }
        }

        public void AddEmployee(string name, decimal salary)
        {
            Employee newEmployee = new Employee();

            newEmployee.Id = ++counter;
            newEmployee.Name = name;
            newEmployee.Salary = salary;

            theEmployees.Add(newEmployee);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Employees of {0}:", this.CompanyName.ToUpper());

            for(int i = 0; i < theEmployees.Count; i++)
            {
                Employee? emp = theEmployees[i] as Employee;
                if( emp is not null)
                {
                    Console.WriteLine("{0} {1} {2}", emp.Id, emp.Name, emp.Salary);
                }
            }
        }


        public Employee? FindEmployeeWithId(int idToFind)
        {
            Employee? empFound = null;
            for (int i = 0; i < theEmployees.Count; i++)
            {
                Employee? emp = theEmployees[i] as Employee;
                if (emp is not null && emp.Id == idToFind)
                {
                    empFound = emp;
                    break;
                }
            }
            return empFound;
        }

        public Employee? this[int idToFind]
        { 
            get 
            {
                Employee? empFound = null;
                for (int i = 0; i < theEmployees.Count; i++)
                {
                    Employee? emp = theEmployees[i] as Employee;
                    if (emp is not null && emp.Id == idToFind)
                    {
                        empFound = emp;
                        break;
                    }
                }
                return empFound;
            }
        }

        public Employee? this[string nameToFind]
        {
            get
            {
                Employee? empFound = null;

                /************************
                // 1. Need to know the Count
                // 2. Unbox
                // 3. Check if unboxed object is not null
                for (int i = 0; i < theEmployees.Count; i++)
                {
                    Employee? emp = theEmployees[i] as Employee;
                    if (emp is not null && emp.Name == nameToFind)
                    {
                        empFound = emp;
                        break;
                    }
                }
                *************/

                foreach (Employee emp in theEmployees)
                {
                    if(emp.Name == nameToFind)
                    {
                        empFound = emp;
                        break;
                    }
                }
                return empFound;
            }
        }

    }
}
