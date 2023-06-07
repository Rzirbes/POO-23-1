// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

var host = new WebHostBuilder()
    .UseKestrel()
    .Configure(
        app => {
            app.Run(ContextBoundObject => ContextBoundObject.Response.WriteAsync("Olá Mundo"));
        }
    )
    .Build();
host.Run();
