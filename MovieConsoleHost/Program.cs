using System;

namespace MovieConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new MovieServiceHost();

            //var hostTask = new Task(host.CreateHostInstance);
            while (true)
            {
                Console.WriteLine("Press CTRL+C at anytime to stop");
                host.CreateHostInstance();
            }
            



            //hostTask.Start();
            //hostTask.Wait();

        }
    }
}
