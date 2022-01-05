using DependencyFunc.Extensions;

using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(FuncFromDependency.Startup))]

namespace FuncFromDependency
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDiagFunction();
        }
    }
}
