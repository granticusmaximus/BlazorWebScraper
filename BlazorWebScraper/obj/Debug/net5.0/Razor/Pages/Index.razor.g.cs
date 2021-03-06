#pragma checksum "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3f3d918296772307a80c8b721efaffa1feb112b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebScraper.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\_Imports.razor"
using BlazorWebScraper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\_Imports.razor"
using BlazorWebScraper.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
using BlazorWebScraper.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Scraped Local Restaurant Favorites Data</h1>");
#nullable restore
#line 8 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
 if (RestaurantListData == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div class=\"ring-2\"><div class=\"ball-holder\"><div class=\"ball\"></div></div></div>");
#nullable restore
#line 15 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Restaurant</th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 25 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
             foreach (var data in RestaurantListData)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 28 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
                         data.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<hr>\r\n\r\n");
            __builder.AddMarkupContent(9, "<h1>Scraped Local Cafe Favorites Data</h1>");
#nullable restore
#line 41 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
 if (CafeListData == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<div class=\"ring-2\"><div class=\"ball-holder\"><div class=\"ball\"></div></div></div>");
#nullable restore
#line 48 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "table");
            __builder.AddMarkupContent(12, "<thead><tr><th>Restaurant</th></tr></thead>\r\n        ");
            __builder.OpenElement(13, "tbody");
#nullable restore
#line 58 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
             foreach (var data in CafeListData)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "tr");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 61 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
                         data.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "\\Mac\Home\Desktop\Dev\Blazor\BlazorWebScraper\BlazorWebScraper\Pages\Index.razor"
      
    public List<string> RestaurantListData;
    public List<string> CafeListData;

    protected override async Task OnInitializedAsync()
    {
        RestaurantListData = await Scraper.TakeOutScrapping();
        CafeListData = await Scraper.CafeScrapping();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ScrapperService Scraper { get; set; }
    }
}
#pragma warning restore 1591
