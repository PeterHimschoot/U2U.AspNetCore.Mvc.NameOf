using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace U2U.AspNetCore.Mvc.NameOf
{
  class U2UHelperFactory : UrlHelperFactory, IUrlHelperFactory
  {
    public IUrlHelper GetUrlHelper(ActionContext context)
    {
      var httpContext = context.HttpContext;
      if( httpContext == null || httpContext.Items == null )
      {
        // let base class throw the localized exception
        return base.GetUrlHelper(context);
      }

      object value;
      if (httpContext.Items.TryGetValue(typeof(IUrlHelper), out value) && value is IUrlHelper)
      {
        return (IUrlHelper)value;
      }

      var urlHelper = new U2UUrlHelper(context);
      httpContext.Items[typeof(IUrlHelper)] = urlHelper;

      return urlHelper;
    }
  }
}
