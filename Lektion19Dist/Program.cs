using Business.Classes;
using Data.Classes;
using Data.Interfaces;
using Lektion19Dist;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<BookBusiness>();
builder.Services.AddSingleton<IData, DataLayer>();

await builder.Build().RunAsync();
