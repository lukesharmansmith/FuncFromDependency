using Microsoft.Extensions.DependencyInjection;

namespace DependencyFunc.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void AddDiagFunction(this IServiceCollection services)
        {
            DiagFunction.Register();
        }
    }
}
