// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AppTodo.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using AppTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using AppTodo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/home/sheymor/Escritorio/carpeta/repo/AppTodo/App/Shared/MainLayout.razor"
       
    private Users users = new Users();
    async void respApi()
    {
        try
        {
            string api = "https://jsonplaceholder.typicode.com/users/1";
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(api);
            var search = JsonConvert.DeserializeObject<Users>(response);
            users.email = search.email;
            users.name = search.name;
            StateHasChanged();


        }
        catch (Exception)
        {
        }
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
