#pragma checksum "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "515e146dc20a951b8122e6e5fb776d7bd7351437"
// <auto-generated/>
#pragma warning disable 1591
namespace TableTenisApp.Client.Pages.Players
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
#line 14 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\_Imports.razor"
using MudBlazor;

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
#line 4 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/players")]
    public partial class Players : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\">Players List</h3>");
#nullable restore
#line 12 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
 if (players == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p class=\"text-center\">Loading...</p>");
#nullable restore
#line 15 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
}
else if (players.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p>No players to display</p>");
#nullable restore
#line 19 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, @"<thead class=""thead-light""><tr><th scope=""col"">Name</th>
                        <th scope=""col"">Surname</th>
                        <th scope=""col"">Points</th>
                        <th scope=""col"">Country</th>
                        <th scope=""col"">Date Of Birth</th>
                        <th scope=""col"">Info</th>
                        <th scope=""col"">Edit</th>
                        <th scope=""col"">Delete</th></tr></thead>
                ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 38 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
                     foreach (var player in players)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 41 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
                             player.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 42 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
                             player.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 43 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
                             player.Points

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 44 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
                             player.Country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 45 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
                             player.DateOfBirth.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "type", "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
                                                              () => navigation.NavigateTo($"players/{player.Id}")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "class", "btn btn-outline-info");
            __builder.AddContent(32, "Info");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "td");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
                                                              () => navigation.NavigateTo($"players/edit/{player.Id}")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "class", "btn btn-outline-warning");
            __builder.AddContent(39, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
                                                              () => DeletePlayer(player)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "btn btn-outline-danger");
            __builder.AddContent(46, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Players.razor"
      

    //Player[] players { get; set; }
    public List<Player> players { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await LoadPlayers();
    }

    async Task LoadPlayers()
    {
        players = await http.GetJsonAsync<List<Player>>("api/players");
    }

    async Task DeletePlayer(Player player)
    {

        //int index = player.PicturePath.LastIndexOf('/');
        //string imgPath = "";

        //if (index != -1)
        //{
        //    Console.WriteLine(player.PicturePath.Substring(0, index)); // "My. name. is Bond"
        //    imgPath = player.PicturePath.Substring(index + 1); // "_James Bond!"
        //}
        //string rootPath = @"F:/Pobrane F/TableTenisApp/TableTenisApp/Server/wwwroot/Images/";

        //string path = rootPath + imgPath;
        //string backslash = @"\";
        //path = path.Replace('/', backslash[0]);
        //File.Delete(path);
        await http.DeleteAsync($"api/players/{player.Id}");
        await LoadPlayers();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
