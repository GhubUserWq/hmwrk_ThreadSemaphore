namespace hmwrk_ThreadSemaphore
{
    class Program
    {
        static void Main(string[] args)
        {
            Semaphore semaphoreObject = new Semaphore(initialCount: 3, maximumCount: 3, name: "PrinterApp"); //
            Printer printerObject = new Printer();

            for (int i = 0; i < 11; ++i)
            {
                int j = i;
                Task.Factory.StartNew(() =>
                {
                    semaphoreObject.WaitOne();
                    printerObject.Print(j);
                    semaphoreObject.Release();
                });
            }
            Console.ReadLine();
        }
    }

    class Printer
    {
        public void Print(int documentToPrint)
        {
            Console.WriteLine("Printing document: " + documentToPrint);
            //code to print document
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }
    }
}
