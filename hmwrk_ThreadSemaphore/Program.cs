namespace hmwrk_ThreadSemaphore
{
    class Program
    {
        static void Main(string[] args)
        {
            Semaphore semaphoreObject = new Semaphore(initialCount: 3, maximumCount: 3, name: "Sinf");  // for class
            Semaphore semaphorePrinter = new Semaphore(initialCount: 2, maximumCount: 5, name: "Printer");  // for printer

            ThreadsInClass threadsInClass = new ThreadsInClass();
            Printer printer = new Printer();

            #region Class
            //for (short i = 1; i < 11; ++i)
            //{
            //    short j = i;
            //    Task.Factory.StartNew(() =>
            //    {
            //        semaphoreObject.WaitOne();
            //        threadsInClass.Objects(j);
            //        semaphoreObject.Release();
            //    });
            //}
            #endregion

            #region Printer
            //for (short i = 1; i < 6; ++i)
            //{
            //    short j = i;
            //    Task.Factory.StartNew(() =>
            //    {
            //        semaphorePrinter.WaitOne();
            //        printer.Users(j);
            //        semaphorePrinter.Release();
            //    });
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
