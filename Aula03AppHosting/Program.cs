﻿

using Microsoft.AspNetCore.Hosting;

namespace Aula03AppHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()               
                .Build();
                
            host.Run();
        }
    }
}
