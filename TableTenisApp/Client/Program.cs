using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TableTenisApp.Client.Auth;
using Tewr.Blazor.FileReader;
using Syncfusion.Blazor;

namespace TableTenisApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDI0Nzg3QDMxMzkyZTMxMmUzMGZKTUpmTGZDZ05JN01MTXlyN2xOUVBaNGNQWWZscEIwNjVaYnhOdFhhazg9");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddFileReaderService(options =>
            {
                options.UseWasmSharedBuffer = true;
            });

            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped<JWTAuthenticationProvider>();

            builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationProvider>(provider => provider.GetRequiredService<JWTAuthenticationProvider>());

            builder.Services.AddScoped<ILoginService, JWTAuthenticationProvider>(provider => provider.GetRequiredService<JWTAuthenticationProvider>());

            builder.Services.AddMudServices();

            builder.Services.AddSyncfusionBlazor();

            await builder.Build().RunAsync();
        }
    }
}
