// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Create.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Create.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Create.razor"
using TableTenisApp.Client.Auth;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/players/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "F:\Pobrane F\TableTenisApp\TableTenisApp\Client\Pages\Players\Create.razor"
          

        private DisplayPlayerModel newPlayer = new DisplayPlayerModel();

        DateTime? date = DateTime.Today;

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

            using (var ms = await file.CreateMemoryStreamAsync((int)fileInfo.Size))
            {
                fileStream = new MemoryStream(ms.ToArray());
            }
        }

        async Task CreatePlayer()
        {

            // Create the content
            var content = new MultipartFormDataContent();
            content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");


            string extension = Path.GetExtension(fileName);
            fileName = newPlayer.Email.ToString();

            content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName + extension);

            string url = "https://localhost:44396";

            var response = await http.PostAsync($"{url}/api/pictures", content);

            if (response.IsSuccessStatusCode)
            {
                var uploadedFileName = await response.Content.ReadAsStringAsync();
                imagePath = $"{url}/{uploadedFileName}";
                message = "User Created";
                newPlayer.DateOfBirth = (DateTime)date;
                newPlayer.PicturePath = imagePath;
                await http.PostJsonAsync("api/players", newPlayer);
                navigationManager.NavigateTo("/players");
            }

        }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReader { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
