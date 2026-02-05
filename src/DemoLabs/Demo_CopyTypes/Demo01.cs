
// Demo of SHALLOW COPY
namespace Demo_CopyTypes.Demo01
{
    public class Car
    {
        public string RegNo { get; set;  }

        public Engine ObjEngine { get; set; }
    }

    public class Engine
    {
        public int BHP { get; set; }
    }

    public static class RunThis
    {
        public static void Run1()
        {
            Car objCar = new Car();
            objCar.RegNo = "KA 01 Car 01";
            objCar.ObjEngine = new Engine();
            objCar.ObjEngine.BHP = 1000;
            
            // Reference
            Car objCopy = objCar;

            Console.WriteLine("-- Before changing the data");
            Console.WriteLine("Car: {0} {1}", objCar.RegNo, objCar.ObjEngine.BHP);
            Console.WriteLine("CarCopy: {0} {1}", objCopy.RegNo, objCopy.ObjEngine.BHP);
            Console.WriteLine();

            objCopy.RegNo = "TN 01 Car 02";
            objCopy.ObjEngine.BHP = 5000;

            Console.WriteLine("-- After changing the data");
            Console.WriteLine("Car: {0} {1}", objCar.RegNo, objCar.ObjEngine.BHP);
            Console.WriteLine("CarCopy: {0} {1}", objCopy.RegNo, objCopy.ObjEngine.BHP);
            Console.WriteLine();
        }


        public static void Run2()
        {
            Car objCar = new Car();
            objCar.RegNo = "KA 01 Car 01";
            objCar.ObjEngine = new Engine();
            objCar.ObjEngine.BHP = 1000;


            // Shallow Copy
            Car objCopy = new Car();
            objCopy.RegNo = objCar.RegNo;           // value type assignment
            objCopy.ObjEngine = objCar.ObjEngine;   // reference type assignment

            Console.WriteLine("-- Before changing the data");
            Console.WriteLine("Car: {0} {1}", objCar.RegNo, objCar.ObjEngine.BHP);
            Console.WriteLine("CarCopy: {0} {1}", objCopy.RegNo, objCopy.ObjEngine.BHP);
            Console.WriteLine();

            objCopy.RegNo = "TN 01 Car 02";
            objCopy.ObjEngine.BHP = 5000;

            Console.WriteLine("-- After changing the data");
            Console.WriteLine("Car: {0} {1}", objCar.RegNo, objCar.ObjEngine.BHP);
            Console.WriteLine("CarCopy: {0} {1}", objCopy.RegNo, objCopy.ObjEngine.BHP);
            Console.WriteLine();
        }

        public static void Run3()
        {
            Car objCar = new Car();
            objCar.RegNo = "KA 01 Car 01";
            objCar.ObjEngine = new Engine();
            objCar.ObjEngine.BHP = 1000;

            // DEEP Copy
            Car objCopy = new Car();
            objCopy.RegNo = objCar.RegNo;                   // value type assignment
            objCopy.ObjEngine = new Engine();               // new nested object
            objCopy.ObjEngine.BHP = objCar.ObjEngine.BHP;   // value type assignment of the nested object

            Console.WriteLine("-- Before changing the data");
            Console.WriteLine("Car: {0} {1}", objCar.RegNo, objCar.ObjEngine.BHP);
            Console.WriteLine("CarCopy: {0} {1}", objCopy.RegNo, objCopy.ObjEngine.BHP);
            Console.WriteLine();

            objCopy.RegNo = "TN 01 Car 02";
            objCopy.ObjEngine.BHP = 5000;

            Console.WriteLine("-- After changing the data");
            Console.WriteLine("Car: {0} {1}", objCar.RegNo, objCar.ObjEngine.BHP);
            Console.WriteLine("CarCopy: {0} {1}", objCopy.RegNo, objCopy.ObjEngine.BHP);
            Console.WriteLine();
        }

    }

}
