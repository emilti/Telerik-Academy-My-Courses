namespace StringsTest
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using StringsService;

    public class Host
    {
        public static void Main(string[] args)
        {
            Uri serviceAddress = new Uri("http://localhost:9000/StringsTestService");
            ServiceHost selfHost = new ServiceHost(typeof(StringsTestService));
            var smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);
            using (selfHost)
            {
                selfHost.Open();
                Console.WriteLine("Service started at http://localhost:9000/StringsTestService");
                Console.WriteLine("Press enter for exit");
                Console.ReadLine();
                selfHost.Close();
            }
        }
    }
}