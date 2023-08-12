namespace AutoResetEventAndManualResetEvent
{
    internal class Program
    {
        static AutoResetEvent autoResetEvent = new AutoResetEvent(false);

        static ManualResetEvent manualResetEvent = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            #region Example -1- AutoResetEvent
            //Thread newThread = new Thread(SomeMethod)
            //{
            //    Name = "NewThread"
            //};
            //newThread.Start();  //It will invoke the SomeMethod in a different thread

            ////To See how the SomeMethod goes in halt mode
            ////Once we enter any key it will call set method and the SomeMethod will Resume its work
            //Console.ReadLine();

            ////It will send a signal to other threads to resume their work
            //autoResetEvent.Set();
            #endregion

            #region Example -2- AutoResetEvent
            Thread newThread = new Thread(SomeMethod)
            {
                Name = "NewThread"
            };
            newThread.Start();

            Thread.Sleep(3000);
            Console.WriteLine("Releasing the WaitOne 1 by set 1");
            manualResetEvent.Set();

            //Thread.Sleep(5000);
            //Console.WriteLine("Releasing the WaitOne 2 by set 2");
            //autoResetEvent.Set();
            Console.ReadKey();

            
            #endregion
        }

        #region Example -1- AutoResetEvent
        //static void SomeMethod()
        //{
        //    Console.WriteLine("Starting...");
        //    //Put the current thread into waiting state until it receives the signal
        //    autoResetEvent.WaitOne();       //It will make the thread in halt mode
        //    Console.WriteLine("Finishing...");
        //    Console.ReadLine();         //To see the output in the console
        //}
        #endregion

        #region Example -2- ManualResetEvent
        static void SomeMethod()
        {
            Console.WriteLine("Starting 1...");
            manualResetEvent.WaitOne();     
            Console.WriteLine("Finishing 1...");
            Console.WriteLine();
            Console.WriteLine("Starting 2...");
            manualResetEvent.WaitOne();
            Console.WriteLine("Finishing 2...");

            Console.ReadLine();         
        }
        #endregion
    }
}