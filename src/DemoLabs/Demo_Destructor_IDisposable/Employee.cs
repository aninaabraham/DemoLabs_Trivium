using System;
using System.Security.Cryptography;

namespace Demo_Destructor_IDisposable
{

    /// <remarks>
    ///     Implementing the IDisposable interface
    ///     1. Add the interface and define the Dispose() method
    ///     2. Move the code from Destructor to Dispose() method
    ///     3. Whenever the object is no longer needed, you can invoke the Dispose() method
    ///     PROBLEMS: (implementing the interface does not mean the object is destroyed!)
    ///     (a) Dispose() needs to be called!
    ///         => Let the Destructor invoke the Dispose() method IF OBJECT HAS NOT BEEN DISPOSED!
    ///     (b) If Dispose() can be called more than once.
    ///         => constructor initializes flag; Dispose() changes the flag; on entry to Dispose() check!
    ///     (c) A method is still accessable even after object has disposed! 
    ///         => on entry to EVERY METHOD check the flag 
    ///     (d) Properties are accessible even after object has been disposed!
    ///         => check flag on GET and SET
    ///     (e) Data-Fields are accessible even after object has been disposed!
    ///         => convert data-fields to property signatures, and check flag on GET and SET
    ///     (f) Indexers are accessible even after object has been disposed!
    ///         => check flag on indexer's GET and SET accessors
    ///    BENEFIT:
    ///      USING block does resource management!
    ///      If required, you can SUPPRESS FINALIZATION
    /// </remarks>
    internal class Employee
        : System.IDisposable
    {
        public int Id { get; private set; }

        public string Name; 


        private decimal _salary;
        public decimal Salary { 
            get
            {
                CheckIfDisposed();

                return _salary;
            }
            set
            {
                CheckIfDisposed();

                _salary = value;
            }
        }


        public Employee(int id)
        {
            // this.Id = ++_counter;
            this.Id = id;

            this.IsDisposed = false;

            Console.WriteLine("Employee {0} object INSTANTIATED!", this.Id);
            Console.WriteLine("---{0}: Induction Training done", this.Id);
            Console.WriteLine("---{0}: Access Card is granted", this.Id);
            Console.WriteLine("---{0}: Workstation is assigned", this.Id);
        }

        ~Employee()
        {
            //Console.WriteLine("---{0}: Work has to be transferred/reallocated to another employee", this.Id);
            //Console.WriteLine("---{0}: Return the Access Card", this.Id);
            //Console.WriteLine("---{0}: Workstation is surrendered", this.Id);
            // Console.WriteLine("---{0}: Pay the last salary of the employee", this.Id);

            // Check if object has not been disposed.
            if (!this.IsDisposed)
            {
                // if not disposed, dispose it!
                Dispose();
            }

            Console.WriteLine("Employee {0}:{1} object is DESTROYED!", this.Id, this.Name);
        }

        #region System.IDisposable 

        private bool IsDisposed;

        private void CheckIfDisposed()
        {
            if (IsDisposed)
            {
                string objName = string.Format("Employee {0}:{1}", this.Id, this.Name.ToUpper());
                throw new ObjectDisposedException(objName);
                // return;
            }
        }

        public void Dispose()
        {
            CheckIfDisposed();

            Console.WriteLine("---{0}: Work has to be transferred/reallocated to another employee", this.Id);
            Console.WriteLine("---{0}: Return the Access Card", this.Id);
            Console.WriteLine("---{0}: Workstation is surrendered", this.Id);
            Console.WriteLine("---{0}: Pay the last salary of the employee", this.Id);
            Console.WriteLine("Employee {0}:{1} object is DISPOSED!", this.Id, this.Name);

            this.IsDisposed = true;

            // SUPPRESS FINALIZATION FOR CURRENT OBJECT
            // Inside the Garbage Collector's List (GC List)
            //   remove the pointer to the Destructor invocation for the current object 
            System.GC.SuppressFinalize(this);
        }

        #endregion



        public void Work()
        {
            CheckIfDisposed();

            Console.WriteLine("Employee {0}:{1} is working", this.Id, this.Name);
        }


    }
}
