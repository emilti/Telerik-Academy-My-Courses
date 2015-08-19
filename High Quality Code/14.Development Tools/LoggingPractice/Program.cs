namespace LoggingPractice
{   
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using log4net;
    using log4net.Config;

    public static class Log4NetExample
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4NetExample));

        public static void Main()
        {
            XmlConfigurator.Configure();
            Log.Info("Info logging");
            try
            {
                throw new Exception("Exception!");
            }
            catch (Exception e)
            {
                Log.Error("This is my error", e);
            }

            Console.WriteLine("[any key to exit]");
            Console.ReadKey();
        }
    }
}
