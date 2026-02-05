namespace Demo_IEnumerator
{
    public class Company
        : System.Collections.IEnumerator
    {
        public string CompanyName { get; private set; }

        private System.Collections.ArrayList theEmployees { get; set; }

        public Company(string name)
        {
            CompanyName = name; 
            theEmployees = new System.Collections.ArrayList();

            this.Reset();
        }


        public void AddEmployee(Employee newEmployee)
        {
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


        #region System.Collections.IEnumerator members

        private int _currentIndex;

        public bool MoveNext()
        {
            if (_currentIndex < theEmployees.Count - 1)
            {
                _currentIndex++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public object? Current
        {
            get
            {
                return this.theEmployees[this._currentIndex];
            }
        }

        #endregion

    }
}
