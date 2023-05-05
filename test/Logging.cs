using Common.Logging;
using Makaretu.Mdns.Simple;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Makaretu.Mdns
{
    [TestClass]
    public class Logging
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            // set logger factory
            var properties = new Common.Logging.Configuration.NameValueCollection
            {
                ["level"] = "TRACE",
                ["showLogName"] = "true",
                ["showDateTime"] = "true",
                ["dateTimeFormat"] = "HH:mm:ss.fff"

            };
            LogManager.Adapter = new ConsoleOutLoggerFactoryAdapter(properties);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
        }
    }
}
