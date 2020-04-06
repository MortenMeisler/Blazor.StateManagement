using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorApp.StateManager.Services;

namespace BlazorApp.StateManager
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(typeof(IStateManager<>), typeof(StateManager<>));

            builder.Services.AddBaseAddressHttpClient();
            builder.Services.AddMsalAuthentication(options =>
            {
                var authentication = options.ProviderOptions.Authentication;
                authentication.Authority = "https://login.microsoftonline.com/22222222-2222-2222-2222-222222222222";
                authentication.ClientId = "33333333-3333-3333-33333333333333333";
                
            });

            await builder.Build().RunAsync();
        }
    }
}
