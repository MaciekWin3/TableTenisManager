#pragma checksum "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dae2edd7186cd8b1690832aa5ccf90c431024f7"
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
#line 5 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
using TableTenisApp.Client.Auth;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/players/edit/{playerId:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n<br>\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex align-items-center justify-content-center");
            __builder.AddMarkupContent(3, "<h1 class=\"text-center\">Edit Player</h1>\r\n    <div class=\"p-2\"></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "p-2 bd-highlight col-example");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "max-width: 500px;");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                              Player

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 25 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                      EditPlayer

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<MudBlazor.MudCard>(16);
                __builder2.AddAttribute(17, "Class", "pa-4 mr-16");
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.TableTenisApp.Client.Pages.Players.Edit.TypeInference.CreateMudTextField_0(__builder3, 19, 20, "First name", 21, 
#nullable restore
#line 30 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                        () => Player.FirstName

#line default
#line hidden
#nullable disable
                    , 22, 
#nullable restore
#line 30 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                               Player.FirstName

#line default
#line hidden
#nullable disable
                    , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Player.FirstName = __value, Player.FirstName)));
                    __builder3.AddMarkupContent(24, "\r\n\r\n                    ");
                    __Blazor.TableTenisApp.Client.Pages.Players.Edit.TypeInference.CreateMudTextField_1(__builder3, 25, 26, "Surname name", 27, 
#nullable restore
#line 33 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                      () => Player.Surname

#line default
#line hidden
#nullable disable
                    , 28, 
#nullable restore
#line 33 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                               Player.Surname

#line default
#line hidden
#nullable disable
                    , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Player.Surname = __value, Player.Surname)));
                    __builder3.AddMarkupContent(30, "\r\n\r\n                    ");
                    __Blazor.TableTenisApp.Client.Pages.Players.Edit.TypeInference.CreateMudTextField_2(__builder3, 31, 32, "Email", 33, 
#nullable restore
#line 36 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                    () => Player.Email

#line default
#line hidden
#nullable disable
                    , 34, 
#nullable restore
#line 36 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                               Player.Email

#line default
#line hidden
#nullable disable
                    , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Player.Email = __value, Player.Email)));
                    __builder3.AddMarkupContent(36, "\r\n\r\n                    ");
                    __Blazor.TableTenisApp.Client.Pages.Players.Edit.TypeInference.CreateMudTextField_3(__builder3, 37, 38, "Country", 39, 
#nullable restore
#line 39 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                      () => Player.Country

#line default
#line hidden
#nullable disable
                    , 40, 
#nullable restore
#line 39 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                               Player.Country

#line default
#line hidden
#nullable disable
                    , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Player.Country = __value, Player.Country)));
                    __builder3.AddMarkupContent(42, "\r\n\r\n                    <br>\r\n                    ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(43);
                    __builder3.AddAttribute(44, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                 12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 42 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudDatePicker>(47);
                        __builder4.AddAttribute(48, "Label", "Date");
                        __builder4.AddAttribute(49, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 43 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                date

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(50, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => date = __value, date))));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(51, "\r\n                    <br>\r\n                    ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(52);
                    __builder3.AddAttribute(53, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                 12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(54, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 46 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.TableTenisApp.Client.Pages.Players.Edit.TypeInference.CreateMudNumericField_4(__builder4, 56, 57, "Points", 58, 
#nullable restore
#line 47 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                                             Variant.Text

#line default
#line hidden
#nullable disable
                        , 59, 
#nullable restore
#line 47 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                                                                   Margin.Dense

#line default
#line hidden
#nullable disable
                        , 60, 
#nullable restore
#line 47 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                      Player.Points

#line default
#line hidden
#nullable disable
                        , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Player.Points = __value, Player.Points)));
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n\r\n                    <br>\r\n\r\n                    ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(63);
                    __builder3.AddAttribute(64, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 52 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                 12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 52 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(67, "input");
                        __builder4.AddAttribute(68, "id", "input-b2");
                        __builder4.AddAttribute(69, "name", "input-b2");
                        __builder4.AddAttribute(70, "type", "file");
                        __builder4.AddAttribute(71, "class", "file btn btn-info");
                        __builder4.AddAttribute(72, "data-show-preview", "false");
                        __builder4.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 53 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                                                                                                              async () => await OpenFileAsync()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddElementReferenceCapture(74, (__value) => {
#nullable restore
#line 53 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                                                                                   inputReference = __value;

#line default
#line hidden
#nullable disable
                        }
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\r\n\r\n                    ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(76);
                    __builder3.AddAttribute(77, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 56 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                 12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 56 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                         12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(80, "div");
                        __builder4.AddAttribute(81, "class", "row");
                        __builder4.OpenElement(82, "div");
                        __builder4.AddAttribute(83, "class", "col-4");
#nullable restore
#line 60 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                 if (!string.IsNullOrWhiteSpace(message))
                                {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(84, "<div class=\"alert alert-success\">\r\n                                        File has been uploaded\r\n                                    </div>");
#nullable restore
#line 65 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(85, "\r\n                            ");
                        __builder4.OpenElement(86, "div");
                        __builder4.AddAttribute(87, "class", "col-4");
#nullable restore
#line 68 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                 if (imagePath != null)
                                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(88, "img");
                        __builder4.AddAttribute(89, "style", "width:150px");
                        __builder4.AddAttribute(90, "src", 
#nullable restore
#line 70 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                   imagePath

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 71 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                }

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(91, "\r\n                    <br>\r\n                    ");
                    __builder3.OpenElement(92, "button");
                    __builder3.AddAttribute(93, "class", "btn btn-block btn-success");
                    __builder3.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
                                                                        async () => await EditPlayer()

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(95, "Create Player");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Edit.razor"
       

    [Parameter]
    public int PlayerId { get; set; }


    DateTime? date = DateTime.Today;

    ElementReference inputReference;
    string message = string.Empty;
    string imagePath = null;

    string fileName = string.Empty;
    string type = string.Empty;
    string size = string.Empty;

    Stream fileStream = null;

    Player Player = new Player();

    protected async override Task OnParametersSetAsync()
    {
        Player = await http.GetJsonAsync<Player>($"api/players/{PlayerId}");
    }

    async Task EditPlayer()
    {

        // Create the content
        var content = new MultipartFormDataContent();
        content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");


        string extension = Path.GetExtension(fileName);
        fileName = Player.Email.ToString();

        content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName + extension);

        string url = "https://localhost:44396";

        var response = await http.PostAsync($"{url}/api/pictures", content);

        if (response.IsSuccessStatusCode)
        {
            var uploadedFileName = await response.Content.ReadAsStringAsync();
            imagePath = $"{url}/{uploadedFileName}";
            message = "User Created";
            Player.DateOfBirth = (DateTime)date;
            Player.PicturePath = imagePath;
            await http.PutJsonAsync($"api/players/{PlayerId}", Player);
            navigation.NavigateTo("players");

        }



    }

    async Task OpenFileAsync()
    {
        // Read the files
        var file = (await fileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

        if (file == null)
            return;

        // Get the info of that files
        var fileInfo = await file.ReadFileInfoAsync();
        fileName = fileInfo.Name;

        using (var ms = await file.CreateMemoryStreamAsync((int)fileInfo.Size))
        {
            fileStream = new MemoryStream(ms.ToArray());
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
    }
}
namespace __Blazor.TableTenisApp.Client.Pages.Players.Edit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMudNumericField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudNumericField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
