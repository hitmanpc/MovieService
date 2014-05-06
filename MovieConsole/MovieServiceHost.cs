using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace MovieConsole
{
    public class MovieServiceHost
    {
        public void CreateHostInstance()
        {
            Console.WriteLine("Please enter the service Base address: (i.e. localhost:1234)");
            var _host = Console.ReadLine();
            var baseAddress = "http://" + _host + "/Services/MovieService";

            if (String.IsNullOrEmpty(_host))
            {
                Console.WriteLine("Empty Host is not allowed Please re-enter a valid Host: ");
                return;
            }
            using (var host = new ServiceHost(typeof(MovieService.MovieService), new Uri(baseAddress)))
            {
                var serviceMetaData = new ServiceMetadataBehavior();
                serviceMetaData.HttpGetEnabled = true;
                serviceMetaData.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                var hostValid = host.BaseAddresses.Select(ba => ba.IsLoopback).FirstOrDefault();
                if (!hostValid)
                {
                    Console.WriteLine("host was not valid");
                    return;
                }
                host.Description.Behaviors.Add(serviceMetaData);

                host.Open();



                Console.WriteLine("Service is ready at the following address: {0}", baseAddress);


                
                var inteface = new MovieUserInterface();
                inteface.RunInterface();

                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();


            }
        }
    }
}
