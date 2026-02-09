namespace Demo_Delegates.Demo01
{

    public class Car 
    {
        internal void DriveCar()
        {
            Console.WriteLine("CAR is being driven");
        }
    }

    public class Scooter
    {
        internal static void DriveScooter()
        {
            Console.WriteLine("SCOOTER is being driven");
        }
    }

    // Defines the Signature of the method that needs to be invoked
    // defines return type + argument list
    // DOES NOT INDICATE: method name, access modifer, type/instance member
    public delegate void DriveHandler();

    public class Driver
    {
        // overload         public void Drive(Car objCar) { ... }
        // boxing/unboxing  public void Drive(object objVehicle) { ... }
        // inhertance       public void Drive(Vehicle objBase) { ...}
        // interface        public void Drive(IVehicle obj) {...}
        // delegate

        public void Drive(DriveHandler? objD)
        {
            //Car objCar = new Car();
            //objCar.DriveCar();

            //DriveHandler objD = new DriveHandler(objCar.DriveCar);
            //objD();

            // Scooter.DriveScooter();

            Console.WriteLine("Driver is driving!!!!");

            // Check if delegate is "SUBSCRIBED" (i.e., is pointing to a method to be invoked)
            if (objD is not null)
            {
                objD();                 // invoke the method pointed to by the delegate
            }
            else
            {
                Console.WriteLine("NOTHING TO DRIVE");
            }
        }
    }

    public static class Demo
    {
        private static void m()
        {
            Console.WriteLine("m() called");
        }

        public static void RunThis()
        {
            Car objCar = new Car();
            Scooter objScooter  = new Scooter();
            Driver objDriver = new Driver();

            // implicitly instantiate the delegate variable
            // and assign the reference of the method to be invoked using the delegate
            objDriver.Drive( objCar.DriveCar );

            // explicitly
            DriveHandler objD = new DriveHandler(objCar.DriveCar);
            objDriver.Drive(objD);


            objDriver.Drive(Scooter.DriveScooter);

            objDriver.Drive(Demo.m);

            objDriver.Drive(null);
        }
    }
}
