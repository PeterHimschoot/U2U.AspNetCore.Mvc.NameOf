using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc;

namespace U2U.AspNetCore.Mvc.NameOf
{
  public class U2UUrlHelper : UrlHelper
  {
    public U2UUrlHelper(ActionContext context) : base(context) { }

    protected override VirtualPathData GetVirtualPathData(string routeName, RouteValueDictionary values)
    {
      var controller = (string) values[nameof(Controller)];
      if (controller.EndsWith(nameof(Controller)))
      {
        controller = controller.Substring(0, controller.Length - nameof(Controller).Length);
        values[nameof(Controller)] = controller;
      }
      return base.GetVirtualPathData(routeName, values);
    }
  }
}
