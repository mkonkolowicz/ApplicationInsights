using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SampleCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TelemetryConfiguration.Active.InstrumentationKey = "1a1b0611-4801-4a35-86a1-94d2ac90e901";
            //var telemetry = new TelemetryClient();
            //telemetry.Context.InstrumentationKey = "1a1b0611-4801-4a35-86a1-94d2ac90e901";
            BuildWebHost(args).Run();

        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
