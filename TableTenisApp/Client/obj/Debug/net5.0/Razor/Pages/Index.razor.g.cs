#pragma checksum "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1875ae14ea727f96fdb9941d59de6490a9b97d1"
// <auto-generated/>
#pragma warning disable 1591
namespace TableTenisApp.Client.Pages
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
#line 5 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
using System.Dynamic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 8 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
               Typo.h3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 8 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                               Align.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Class", "");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, "Ping Pong Players");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "<div class=\"col-sm\"><img src=\"images/logo2.png\" alt=\"logo\"></div>\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-sm d-flex align-items-center");
            __builder.OpenComponent<MudBlazor.MudText>(14);
            __builder.AddAttribute(15, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 16 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                           Typo.h5

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, @"
                There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form,
                by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage
                of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text.
            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDivider>(19);
            __builder.AddAttribute(20, "DividerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DividerType>(
#nullable restore
#line 25 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                         DividerType.Middle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Class", "my-6");
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenComponent<MudBlazor.MudText>(23);
            __builder.AddAttribute(24, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 26 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
               Typo.h3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 26 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                               Align.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "Class", "");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(28, "Top Players");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 27 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
 if (players == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<p class=\"text-center\">Loading...</p>");
#nullable restore
#line 30 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfChart>(30);
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryXAxis>(32);
                __builder2.AddAttribute(33, "ValueType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ValueType>(
#nullable restore
#line 34 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                      Syncfusion.Blazor.Charts.ValueType.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartSeriesCollection>(35);
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(37);
                    __builder3.AddAttribute(38, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 36 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                      ChartLine

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "XName", "X");
                    __builder3.AddAttribute(40, "YName", "Y");
                    __builder3.AddAttribute(41, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 36 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                                           ChartSeriesType.Column

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "Opacity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 36 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                                                                            0.5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "DashArray", "5,5");
                    __builder3.AddAttribute(44, "Fill", "blue");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 41 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudDivider>(45);
            __builder.AddAttribute(46, "DividerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DividerType>(
#nullable restore
#line 42 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                         DividerType.Middle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "Class", "my-6");
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.OpenComponent<MudBlazor.MudText>(49);
            __builder.AddAttribute(50, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 43 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
               Typo.h3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 43 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                               Align.Center

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "Class", "");
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(54, "Our Sponsors");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n<br>\r\n");
            __builder.OpenComponent<MudBlazor.MudCarousel<object>>(56);
            __builder.AddAttribute(57, "Class", "pa-4 mr-16");
            __builder.AddAttribute(58, "Style", "height:200px;");
            __builder.AddAttribute(59, "ShowArrows", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "ShowDelimiters", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "AutoCycle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(63);
                __builder2.AddAttribute(64, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 46 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                 transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 46 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                     Color.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(67, "div");
                    __builder3.AddAttribute(68, "class", "d-flex");
                    __builder3.AddAttribute(69, "style", "height:100%");
                    __builder3.OpenComponent<MudBlazor.MudIcon>(70);
                    __builder3.AddAttribute(71, "Class", "mx-auto my-auto");
                    __builder3.AddAttribute(72, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                    Icons.Custom.Brands.MicrosoftAzure

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 48 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                                                               Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(75);
                __builder2.AddAttribute(76, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 51 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                 transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 51 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                     Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(79, "div");
                    __builder3.AddAttribute(80, "class", "d-flex");
                    __builder3.AddAttribute(81, "style", "height:100%");
                    __builder3.OpenComponent<MudBlazor.MudIcon>(82);
                    __builder3.AddAttribute(83, "Class", "mx-auto my-auto");
                    __builder3.AddAttribute(84, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                    Icons.Custom.Brands.MudBlazor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(85, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 53 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                                                          Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCarouselItem>(87);
                __builder2.AddAttribute(88, "Transition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Transition>(
#nullable restore
#line 56 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                 transition

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 56 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                     Color.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(91, "div");
                    __builder3.AddAttribute(92, "class", "d-flex");
                    __builder3.AddAttribute(93, "style", "height:100%");
                    __builder3.OpenComponent<MudBlazor.MudIcon>(94);
                    __builder3.AddAttribute(95, "Class", "mx-auto my-auto");
                    __builder3.AddAttribute(96, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                    Icons.Custom.Brands.Facebook

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(97, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 58 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                                                                                         Size.Large

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDivider>(99);
            __builder.AddAttribute(100, "DividerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DividerType>(
#nullable restore
#line 62 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
                         DividerType.Middle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "Class", "my-6");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Index.razor"
      
    private Transition transition = Transition.Slide;
    //private int Index = -1; //default value cannot be 0 -> first selectedindex is 0.



    //Player[] players { get; set; }
    public List<Player> players;

    //public List<string> names { get; set; }
    public double[] Points { get; set; }
    public string[] Names { get; set; }
    public Syncfusion.Blazor.Charts.ChartSeries ChartData { get; set; }


    public string[] XAxisLabels = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" };

    public List<ExpandoObject> ChartLine { get; set; } = new List<ExpandoObject>();


    protected override async Task OnInitializedAsync()
    {
        await LoadPlayers();

        ChartLine = Enumerable.Range(0, players.Count).Select((x) =>
        {
            dynamic d = new ExpandoObject();
            if (x == 0)
            {
                d.X = players[x].Surname;
                d.Y = 0;
            }
            d.X = players[x].Surname;
            d.Y = players[x].Points;
            return d;
        }).Cast<ExpandoObject>().ToList<ExpandoObject>();

    }

    async Task LoadPlayers()
    {
        players = await http.GetJsonAsync<List<Player>>("api/players/chart");

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
