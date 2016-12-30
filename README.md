# U2U.AspNetCore.Mvc.NameOf

This package updates Mvc6 to allows the use of the `nameof()` keyword in your views 

For example, instead of using strings for the name of the controller and action

```
<a asp-controller="Home" asp-action="Index" class="navbar-brand">Index</a>
```

you can use `nameof()`

```
<a asp-controller="@nameof(HomeController)" asp-action="@nameof(HomeController.Index)" class="navbar-brand">Index</a>
```

## Setup
All you need to do extra is to add a `using` to your `_ViewImports.cshtml`

```
@using WebApplication2.Controllers
```

and in `Startup.ConfigureServices` add a call to `AddNameOf` after the call to `AddMvc`.

```
services.AddMvc();
services.AddNameOf();
```