#pragma checksum "C:\Users\esept\Source\Repos\AwardsMON2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c54cd7492cabbbb7f728863d9c8a7bc2c850abd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlzMON.Pages
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using BlzMON;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using BlzMON.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\esept\Source\Repos\AwardsMON2\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Доброе пожаловать!</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        Для начало работы пожалуйста авторизуйтесь.\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
