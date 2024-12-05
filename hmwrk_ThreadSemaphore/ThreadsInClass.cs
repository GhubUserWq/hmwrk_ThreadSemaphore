namespace hmwrk_ThreadSemaphore
{
    class ThreadsInClass
    {
        public void Objects(short thread)
        {
            Console.WriteLine("Incoming: " + thread);
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }
    }
}
