namespace Demo_Indexer
{
    public class Employee
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }



        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {
            Name = string.Empty;
        }
    }
}
