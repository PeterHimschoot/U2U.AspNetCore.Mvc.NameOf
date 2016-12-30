using Microsoft.AspNetCore.Mvc.Routing;
using U2U.AspNetCore.Mvc.NameOf;

namespace Microsoft.Extensions.DependencyInjection
{
  public static class U2UExtensions
  {
    public static IServiceCollection AddNameOf(this IServiceCollection services)
    => services.AddSingleton<IUrlHelperFactory, U2UHelperFactory>();
  }
}
