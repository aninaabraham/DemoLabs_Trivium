namespace Demo_Array
{
    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of Rank 1  ("Rank" = Dimension)
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 2, 3, 4, 5 };             // size is implied
            int[] arr3 = [ 1, 2, 3, 4, 5 ];             // C# 8.0 feature


            // Working with the element (based upon the element type)
            int x = arr1[3];                            // == 4.  0 based index
            x = 500;
            Console.WriteLine("{0}, {1}", x, arr1[3]);  // x==500, arr1[3]==4

            // Working with the collection (reference type)
            int[] arrCopy = arr1;
            Console.WriteLine("{0}, {1}", arrCopy[3], arr1[3]);  // arrCopy[3]==4, arr1[3]==4
            arrCopy[3] = 700;
            Console.WriteLine("{0}, {1}", arrCopy[3], arr1[3]);  // arrCopy[3]==700, arr1[3]==700

            Console.WriteLine(arr1.Length);             // 5
            Console.WriteLine(arr1.GetLength(0));       // 5 (for Rank 1 == 5)



            // Array of Rank 2
            int[,] arr100a = new int[2, 4];        // Rank 0 == 2, Rank 1 == 4
            int[,] arr100b = new int[2, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 }
            };

            int y = arr100b[1, 2] ;               // == 7

            Console.WriteLine(arr100a.Length);             // 2 * 4 == 8
            Console.WriteLine(arr100a.GetLength(0));       // 2 (for Rank 0 == 2)
            Console.WriteLine(arr100a.GetLength(1));       // 4 (for Rank 1 == 4)



            // Array of Rank 3
            int[,,] arr1000 = new int[2, 3, 5];
            arr1000[0, 1, 3] = 100;


            // Array of Reference Types
            Employee[] arrEmployees;
            arrEmployees = new Employee[3];
            arrEmployees[0] = new Employee();
            arrEmployees[0].Id = 10;
            arrEmployees[0].Name = "First Employee";
            arrEmployees[1] = new Employee();
            arrEmployees[1].Id = 20;
            arrEmployees[1].Name = "Second Employee";
            arrEmployees[2] = new Employee();
            arrEmployees[2].Id = 30;
            arrEmployees[2].Name = "Third Employee";
            for(int i = 0; i < arrEmployees.Length; i++ )
            {
                Console.WriteLine("{0} {1}", arrEmployees[i].Id, arrEmployees[i].Name);
            }

            Employee[] arrEmployeesShallowCopy = new Employee[arrEmployees.Length];
            for (int i = 0; i < arrEmployees.Length; i++)
            {
                arrEmployeesShallowCopy[i] = arrEmployees[i];
            }


            Employee[] arrEmployeesDeepCopy = new Employee[arrEmployees.Length];
            for (int i = 0; i < arrEmployees.Length; i++)
            {
                arrEmployeesDeepCopy[i] = new Employee();
                arrEmployeesDeepCopy[i].Id = arrEmployees[i].Id;
                arrEmployeesDeepCopy[i].Name = arrEmployees[i].Name;
            }


            System.Collections.ArrayList arrListInt = new System.Collections.ArrayList();
            arrListInt.Add(10);             // arrListInt[0] == 10
            arrListInt.Add(20);             // arrListInt[1] == 20
            arrListInt.Add(30);             // arrListInt[2] == 30

            for (int i = 0; i < arrListInt.Count; i++)
            {
                Console.WriteLine("{0} : {1} {2}", i, arrListInt[i], arrListInt[i]?.GetType());
            }
            Console.WriteLine();

            Console.WriteLine("arrListInt[0] : {0}", arrListInt[0]);
            // arrListInt[0] = arrListInt[0] + 1;
            arrListInt[0] = (int)arrListInt[0] + 1;
            Console.WriteLine("arrListInt[0] : {0}", arrListInt[0]);
            Console.WriteLine();

            arrListInt.Remove(20);
            arrListInt.RemoveAt(2);




            Console.WriteLine("Number of elements in the ArrayList: {0}", arrListInt.Count);    // 3

            arrListInt.Add(40);             // arrListInt[3] == 40
            arrListInt.Add("hello world");  // arrListInt[4] == "hello world"

            Console.WriteLine("Number of elements in the ArrayList: {0}", arrListInt.Count);    // 5


            // arrListInt[5] == [ 10, 20, 30, 40, 50 ]
            int[] arrX = new int[5] { 10, 20, 30, 40, 50 };
            arrListInt.Add(arrX);
            Console.WriteLine("Number of elements in the ArrayList: {0}", arrListInt.Count);    // 6

            // arrListInt[5] == 10
            // arrListInt[6] == 20
            // arrListInt[7] == 30
            arrListInt.AddRange(arrX);

        }
    }
}
