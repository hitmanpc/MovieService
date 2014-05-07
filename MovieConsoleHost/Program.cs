using System;

namespace MovieConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new MovieServiceHost();

            
            while (true)
            {
                Console.WriteLine("Press CTRL+C at anytime to stop");
                host.CreateHostInstance();
            }
            
        }
    }
}
