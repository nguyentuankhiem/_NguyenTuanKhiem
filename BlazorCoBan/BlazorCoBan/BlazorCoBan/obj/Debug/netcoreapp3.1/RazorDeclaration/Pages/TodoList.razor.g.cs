// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCoBan.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using BlazorCoBan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using BlazorCoBan.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\_Imports.razor"
using BlazorCoBan.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todolist")]
    public partial class TodoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\maico\ntk_repo\BlazorCoBan\BlazorCoBan\BlazorCoBan\Pages\TodoList.razor"
       
    public string announce { get; set; }

    public string newItem { get; set; }

    public List<TodoItem> TDL = new List<TodoItem>();

    public void Add()
    {
        if (!string.IsNullOrEmpty(newItem))
        {
            TDL.Add(new TodoItem(title: newItem));
            newItem = string.Empty;
            announce = string.Empty;
        }
    }

    public void Remove(TodoItem item)
    {
        TDL.Remove(item);
        announce = string.Empty;
    }

    public void Clear()
    {
        TDL.Clear();
        announce = string.Empty;
    }

    public void Save()
    {
        string path = "Data//tdl.json";
        if (TDL.Count > 0)
        {
            var json = JsonSerializer.Serialize(TDL);
            File.WriteAllText(path, json);
            announce = "Save successfully to the folder Data";
        }
        else
        {
            announce = "No data to save";
        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
