#pragma checksum "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbc29fdaef4e5400f932b5149518e42cf0925775"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\nahia\OneDrive\Desktop\school stuff\2020-2021\Advanced Prog\Hanoi-Tower\blazorserver01\Pages\Counter.razor"
       
  private int currentCount = 0;

List<Data.Rectangle> lines = new List<Data.Rectangle>();
  public Data.Rectangle l1 = new Data.Rectangle(1,"black");
  public Data.Rectangle l2 = new Data.Rectangle(2,"black");
  public Data.Rectangle l3 = new Data.Rectangle(3,"black");
public void listCreate(){
  lines.Add(l1);
  lines.Add(l2);
  lines.Add(l3);
}
  private void TowerClick(Data.Rectangle obj){
        if (obj.color == "black")
        {
          obj.color = "blue";
        }
        else
        obj.color = "black";
    }
  public Counter(){
    listCreate();
  }
    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
