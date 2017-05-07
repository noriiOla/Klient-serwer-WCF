using RsiZ3Bookshelf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri root = new Uri("http://localhost:4000/task2");
            ServiceHost host = new ServiceHost(typeof(IssueTracker), root);

            try
            {
                WSHttpBinding binding = new WSHttpBinding();
                host.AddServiceEndpoint(typeof(IIssueTracker), binding, "Task2Service");

                ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                behavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(behavior);

                Console.WriteLine($"Root: {root.OriginalString}");
                host.Open();
                Console.WriteLine("Service started!");
                Console.ReadLine();
                host.Close();
            }
            catch (CommunicationException err)
            {
                Console.Error.WriteLine("Service failed!");
                Console.Error.WriteLine(err.Message);
                Console.ReadKey();
                host.Abort();
            }
        }
    }
}
