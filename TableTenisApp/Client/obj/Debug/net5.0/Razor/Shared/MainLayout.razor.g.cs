#pragma checksum "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8385e7d31d9f046199ba7aa6418fd8754cfa8243"
// <auto-generated/>
#pragma warning disable 1591
namespace TableTenisApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using TableTenisApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using TableTenisApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using TableTenisApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using TableTenisApp.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Shared\MainLayout.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "page");
            __builder.AddAttribute(8, "b-ixgebja5z3");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "sidebar");
            __builder.AddAttribute(11, "b-ixgebja5z3");
            __builder.OpenComponent<TableTenisApp.Client.Shared.NavMenu>(12);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "main");
            __builder.AddAttribute(16, "b-ixgebja5z3");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "top-row px-2");
            __builder.AddAttribute(19, "b-ixgebja5z3");
            __builder.OpenComponent<TableTenisApp.Client.Shared.AuthLinks>(20);
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, "<a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-ixgebja5z3>About</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "content px-2");
            __builder.AddAttribute(26, "b-ixgebja5z3");
            __builder.AddContent(27, 
#nullable restore
#line 19 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
