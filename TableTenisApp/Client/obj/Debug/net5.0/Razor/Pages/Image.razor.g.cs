#pragma checksum "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fa5ce8f958bfe80286e01ba5c31873f9b407500"
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
#line 3 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/image")]
    public partial class Image : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Upload file!</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-4");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "file");
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
                                                                async () => await OpenFileAsync()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(10, (__value) => {
#nullable restore
#line 14 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
                                     inputReference = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "ul");
            __builder.OpenElement(13, "li");
            __builder.AddContent(14, "File Name: ");
            __builder.AddContent(15, 
#nullable restore
#line 16 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
                                fileName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "li");
            __builder.AddContent(18, "Size: ");
            __builder.AddContent(19, 
#nullable restore
#line 17 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
                           size

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "li");
            __builder.AddContent(22, "Type: ");
            __builder.AddContent(23, 
#nullable restore
#line 18 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
                           type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-block btn-success");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
                                                            async () => await UploadFileAsync()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Upload File");
            __builder.CloseElement();
#nullable restore
#line 23 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
         if (!string.IsNullOrWhiteSpace(message))
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<div class=\"alert alert-success\">\r\n                File has been uploaded\r\n            </div>");
#nullable restore
#line 28 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-4");
#nullable restore
#line 31 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
         if (imagePath != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "img");
            __builder.AddAttribute(34, "style", "width:150px");
            __builder.AddAttribute(35, "src", 
#nullable restore
#line 33 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
                                           imagePath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 34 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Image.razor"
 
    ElementReference inputReference;
    string message = string.Empty;
    string imagePath = null;

    string fileName = string.Empty;
    string type = string.Empty;
    string size = string.Empty;

    Stream fileStream = null;

    async Task OpenFileAsync()
    {
        // Read the files
        var file = (await fileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

        if (file == null)
            return;

        // Get the info of that files
        var fileInfo = await file.ReadFileInfoAsync();
        fileName = fileInfo.Name;
        size = $"{fileInfo.Size}b";
        type = fileInfo.Type;

        using (var ms = await file.CreateMemoryStreamAsync((int)fileInfo.Size))
        {
            fileStream = new MemoryStream(ms.ToArray());
        }
    }

    async Task UploadFileAsync()
    {

        // Create the content
        var content = new MultipartFormDataContent();
        content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");

        content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName);

        string url = "https://localhost:44396";

        var response = await client.PostAsync($"{url}/api/players", content);

        if (response.IsSuccessStatusCode)
        {
            var uploadedFileName = await response.Content.ReadAsStringAsync();
            imagePath = $"{url}/{uploadedFileName}";
            message = "File has been uploaded successfully!";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReader { get; set; }
    }
}
#pragma warning restore 1591
