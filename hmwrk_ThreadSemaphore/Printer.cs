namespace hmwrk_ThreadSemaphore
{
    class Printer
    {
        public void Users(short user)
        {
            Console.WriteLine($"User " + user + " printing");
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }
    }
}
