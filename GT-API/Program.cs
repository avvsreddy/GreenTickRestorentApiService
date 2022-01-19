using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Unity;
using Unity.Microsoft.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GT_API
{
    public class Program
    {
        private static IUnityContainer _container;
        public static void Main(string[] args)
        {
            _container = new UnityContainer();
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseUnityServiceProvider()
                .UseStartup<Startup>()
                .Build();
    }
}
