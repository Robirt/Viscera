using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Viscera.WebUI.Components;
using Viscera.WebUI.Services;

var webAssemblyHostBuilder = WebAssemblyHostBuilder.CreateDefault();

webAssemblyHostBuilder.RootComponents.Add<App>("#app");
webAssemblyHostBuilder.RootComponents.Add<HeadOutlet>("head::after");

webAssemblyHostBuilder.Services.AddAuthorizationCore();

webAssemblyHostBuilder.Services.AddSingleton<AuthenticationStateProvider, AuthenticationStateService>();

await webAssemblyHostBuilder.Build().RunAsync();
