#pragma checksum "D:\development\blazor_crud\MainApp\Client\Pages\Worker\Form.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e52bbfd204bbdf1534fcce460acb9069bc225f60"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MainApp.Client.Pages.Worker
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\development\blazor_crud\MainApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\development\blazor_crud\MainApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\development\blazor_crud\MainApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\development\blazor_crud\MainApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\development\blazor_crud\MainApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\development\blazor_crud\MainApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\development\blazor_crud\MainApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\development\blazor_crud\MainApp\Client\_Imports.razor"
using MainApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\development\blazor_crud\MainApp\Client\_Imports.razor"
using MainApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\development\blazor_crud\MainApp\Client\_Imports.razor"
using MainApp.Shared.Models;

#line default
#line hidden
#nullable disable
    public partial class Form : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\development\blazor_crud\MainApp\Client\Pages\Worker\Form.razor"
       
    [Parameter] public Worker wor { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
