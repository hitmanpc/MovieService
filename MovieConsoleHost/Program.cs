using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
