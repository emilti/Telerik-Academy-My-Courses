using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using DateTimeConverter;



namespace Host 
{
    class Host
    {
        static void Main(string[] args)
        {
            Uri serviceAddress = new Uri("http://localhost:8000/DateTimeService");
            ServiceHost selfHost = new ServiceHost(typeof(DateTimeService));
            var smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);
            using (selfHost)
            {
                selfHost.Open();
                Console.WriteLine("Service started at http://localhost:8000/DateTimeService");
                Console.WriteLine("Press enter for exit");
                Console.ReadLine();
                selfHost.Close();
            }
        }
    }
}


